using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Client
{

    public partial class fWindow : Form
    {
        private TcpClient client = null;
        private BinaryReader reading = null;
        private BinaryWriter writing = null;
        private bool activeCall = false;
        private User user = new User();
        private string messageSent = "";
        
        public fWindow()
        {
            InitializeComponent();
            webBrowser.DocumentText = "<html><body><h1>Komunikator</h1><br/><p style='border-bottom:2px solid black'>Połącz się z serwerem aby rozpocząć...</p></body></html>";

        }
        private void load()
        {

            // 
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            if (tbNickname.Text != "")
            {
                user.nick = tbNickname.Text;
                bwConnection.RunWorkerAsync();
                bCancel.Enabled = true;
                Connect.Enabled = false;
            }



        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            string host = tbHostAddress.Text;
            int port = System.Convert.ToInt16(nUDPort.Value);
            try
            {
                TcpClient client = new TcpClient();
                client = new TcpClient(host, port);
                NetworkStream ns = client.GetStream();
                reading = new BinaryReader(ns);
                writing = new BinaryWriter(ns);
                writing.Write(user.nick);
                activeCall = true;
                if (!bwConnection2.IsBusy)
                {
                    bwConnection2.RunWorkerAsync();
                }
                this.Invoke((MethodInvoker)delegate
                {
                    lbNotify.Text = "";
                    webBrowser.DocumentText = "<p style='margin:0;border-bottom:2px solid black'>Nawiązano połączenie z " + host + "</p>";
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    webBrowser.DocumentText += "<p style='margin:0;border-bottom:2px solid black'>Błąd: Nie udało się nawiązać połączenia!</p>";
                    MessageBox.Show(ex.ToString());
                    bCancel.Enabled = false;
                    Connect.Enabled = true;
                });
                activeCall = false;
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            disconnect();
        }

        private void disconnect()
        {
            Application.Exit();

            try
            {
                //if (activeCall)
                //{
                writing.Write(user.nick + "_" + "END");
                //}
                this.Invoke((MethodInvoker)delegate
                {
                    webBrowser.DocumentText += "<p style='margin:0;font-weight:bold'>Klient rozłączony.</p>";
                });
                //bwConnection.CancelAsync();
                //bwConnection2.CancelAsync();
                bCancel.Enabled = false;
                Connect.Enabled = true;
                //client = null;
                activeCall = false;
                /*
                if (!bwConnection.IsBusy)
                {
                    bwConnection.RunWorkerAsync();
                }
                */
            } catch {
                MessageBox.Show("cos poszlo nie tak");
            }
           
        }

        private void bwConnection2_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string messageReceived;
                while ((messageReceived = reading.ReadString()) != "END")
                {
                    switch (messageReceived.Split('_')[1])
                    {
                        case "END":
                            if(messageReceived.Split('_')[0] == "Server")
                                disconnect();
                            break;

                        case "%%notify%%":
                            this.Invoke((MethodInvoker)delegate
                            {
                                lbNotify.Text = messageReceived.Split('_')[0] + " is typing";
                            });
                            break;

                        case "%%disconnect%%":
                            this.Invoke((MethodInvoker)delegate
                            {
                                webBrowser.DocumentText += "<p style='margin:0;border-bottom:1px solid black; border-top:1px solid black; font-weight:bold; color:blue;'><span style=''>" + messageReceived.Split('_')[0] + " (" + DateTime.Now.ToString("HH:mm:ss") + ") </span><span style='color:red;'>- rozłączył się.</span></p>";
                            });
                            break;

                        case "%%connect%%":
                            this.Invoke((MethodInvoker)delegate
                            {
                                webBrowser.DocumentText += "<p style='margin:0;border-bottom:1px solid black; border-top:1px solid black; font-weight:bold; color:blue;'><span style=''>" + messageReceived.Split('_')[0] + " (" + DateTime.Now.ToString("HH:mm:ss") + ") -</span> połączył się.</p>";
                            });
                            break;

                        default:

                            this.Invoke((MethodInvoker)delegate
                            {
                                lbNotify.Text = "";
                                string color = "blue";
                                if (messageReceived.Split('_')[0] == "Server")
                                    color = "red";
                                webBrowser.DocumentText += "<p style='margin:0;'><span style='font-weight:bold; color:" + color + ";'>" + messageReceived.Split('_')[0] + " (" + DateTime.Now.ToString("HH:mm:ss")+ ") -</span> " + messageReceived.Split('_')[1] + "</p>";
                            });
                            break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Rozłączono ");
            }

        }

        private void send()
        {
            try {
                messageSent = user.nick + "_" + tbMessage.Text;
                writing.Write(messageSent);
                this.Invoke((MethodInvoker)delegate
                {
                    webBrowser.DocumentText += "<p style='margin:0;'><span style='font-weight:bold; color:green;'>" + user.nick + " (" + DateTime.Now.ToString("HH:mm:ss") + ") -</span> " + tbMessage.Text + "</p>";
                });
            }
            catch
            {
            }
                
            
        }
        private void bSend_Click(object sender, EventArgs e)
        {
            send();
            tbMessage.Clear();
        }


        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            try {
                if (tbMessage.Text != "")
                {
                    writing.Write(user.nick + "_" + "%%notify%%");
                }
                // enterKeyPressed();
                // MessageBox.Show("lol");
            }
            catch {
                MessageBox.Show("lol");
            }
           
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();
                tbMessage.Clear();
            }
        }

        private void bBold_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbMessage.Text += "<b></b>";
            });
        }

        private void bItalics_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbMessage.Text += "<i></i>";
            });
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                webBrowser.ShowSaveAsDialog();
            });
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                webBrowser.DocumentText = "";
            });
        }
    }
}
