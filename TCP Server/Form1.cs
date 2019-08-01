using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TCP_Server
{
    public partial class fWindow : Form
    {
        private TcpListener server;
        private TcpClient client;
        private List<BinaryWriter> writers = new List<BinaryWriter>();
        private bool activeCall = false;
        public string selectedIp = "";
        
        public fWindow()
        {
            InitializeComponent();
            loadIpAddresses();
            webBrowser.DocumentText = "<html><body><h1>Komunikator</h1><br/><p style='border-bottom:2px solid black'>Uruchom serwer aby rozpocząć...</p></body></html>";

        }
        private void loadIpAddresses()
        {

            string HostName = Dns.GetHostName();
            IPHostEntry AddressesIP = Dns.GetHostEntry(HostName);
            string firstEntry = "127.0.0.1";
            IPAddress firstIp = null;

            firstIp = IPAddress.Parse(firstEntry);
            foreach (IPAddress AddressIP in AddressesIP.AddressList)
            {
                if (AddressIP.IsIPv6LinkLocal || AddressIP.IsIPv6Multicast || AddressIP.IsIPv6SiteLocal || AddressIP.IsIPv6Teredo)
                {
                    continue;
                }
                cbAddressList.Items.Add(firstIp);
                cbAddressList.Items.Add(AddressIP.ToString());
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            startServer();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            shutdownServer();
        }

        private void shutdownServer()
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    webBrowser.DocumentText += "<p style='margin:0; font-weight:bold;border-top:1px solid black; border-bottom:1px solid black;'>Serwer wyłączony.</p>";
                    bStart.Enabled = true;
                    bStop.Enabled = false;
                });
                broadcastMessage("END", null, "Server");
                bwConnection.CancelAsync();
                server.Stop();
            }
            catch
            {
                MessageBox.Show("wyłączenie poszlo nie tak");
            }

        }

        private void disconnectClient( TcpClient client, BinaryWriter writer, string nickDisconnected )
        {
            broadcastMessage("%%disconnect%%", writer, nickDisconnected);

            foreach ( BinaryWriter i in writers)
            {
                if( i == writer )
                {
                    writers.Remove(i);
                }
            }
            this.Invoke((MethodInvoker)delegate
            {
                webBrowser.DocumentText += "<p style='margin:0; font-weight:bold;border-top:1px solid black; border-bottom:1px solid black;'><span style='color:blue;'>" + nickDisconnected + "</span><span style='color:#ffffff'> rozłączył się.</span></p>";
                webBrowser.Update();
            });
            
        }

        private void startServer()
        {
            IPAddress adresIP = null;

            try
            {
                adresIP = IPAddress.Parse(selectedIp);
                bStart.Enabled = false;
                bStop.Enabled = true;

                int port = System.Convert.ToInt16(nUDPort.Value);

                server = new TcpListener(adresIP, port);
                server.Start();
                if (!bwConnection.IsBusy)
                {
                    bwConnection.RunWorkerAsync();
                }
                this.Invoke((MethodInvoker)delegate
                {
                    webBrowser.DocumentText = "<p>Uruchomiono serwer, oczekiwanie na połączenie...</p>";
                });
            }
            catch
            {
                MessageBox.Show("Błędny format adresu IP!", "Błąd!");
                return;
            }
           
        }

        private void bwConnection_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true) {
                listen();
            }
        }
        
        private void listen()
        {
            try
            {
                TcpClient client = server.AcceptTcpClient();
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += bwConnection2_DoWork;

                if (!bw.IsBusy) {
                    bw.RunWorkerAsync(client);
                }
            }
            catch
            {
                //activeCall = false;
                //MessageBox.Show("NOPE");
            }

        }

        private void bwConnection2_DoWork(object sender, DoWorkEventArgs e)
        {
            TcpClient client = (TcpClient)e.Argument;
            IPEndPoint IP = (IPEndPoint)client.Client.RemoteEndPoint;
            NetworkStream ns = client.GetStream();
            BinaryReader reading = new BinaryReader(ns);
            BinaryWriter writing = new BinaryWriter(ns);   
            writers.Add(writing);

            String  guest = reading.ReadString();

            broadcastMessage("%%connect%%", null, guest);

            this.Invoke((MethodInvoker)delegate
            {
                activeCall = true;
                lbNotify.Text = "";
                webBrowser.DocumentText += "<p style='margin:0;font-weight:bold;border-top:1px solid black; border-bottom:1px solid black'>" + guest + " połączył się z " + IP.ToString() + ".</p>";
                webBrowser.Update();

            });
            try
            {
                string messageReceived;
                while ((messageReceived = reading.ReadString()) != "POMIDORZAQ!@WSX231GFDWYEr7$%#%#JOl")
                {
                    switch (messageReceived.Split('_')[1])
                    {
                        case "END":
                            disconnectClient( client, writing, messageReceived.Split('_')[0] );
                            break;

                        case "%%notify%%":
                            this.Invoke((MethodInvoker)delegate
                            {
                                lbNotify.Text = messageReceived.Split('_')[0] + " is typing";
                                broadcastMessage(messageReceived.Split('_')[1], writing, guest);
                            });
                            break;

                        default:

                            this.Invoke((MethodInvoker)delegate
                            {
                                lbNotify.Text = "";
                                webBrowser.DocumentText += "<p style='margin:0;'><span style='font-weight:bold; color:blue;'>" + messageReceived.Split('_')[0] + " (" + DateTime.Now.ToString("HH:mm:ss") + ") -</span> " + messageReceived.Split('_')[1] + "</p>";
                                webBrowser.Update();
                            });
                            
                            broadcastMessage(messageReceived.Split('_')[1], writing, guest);
                            break;
                    }
                }
            }
            catch
            {
                this.Invoke((MethodInvoker)delegate
                {
                    webBrowser.DocumentText += "<p style='margin:0;font-weight:bold; border-top:1px solid black; border-bottom:1px solid black'><span style='color:blue;'>" + guest + "</span> rozłączył się.</p>";
                    webBrowser.Update();
                });
            }
        }
        
        private void broadcastMessage(String message, BinaryWriter ignoreWriter, String guest)
        {
            foreach (BinaryWriter writer in writers) {
                if (writer == ignoreWriter) continue;
                writer.Write(guest + "_" + message);
            }
        }

        private void send()
        {

           try {
                string messageSent = tbMessage.Text;
                broadcastMessage(messageSent, null, "Server");
                this.Invoke((MethodInvoker)delegate
                {
                    webBrowser.DocumentText += "<p style='margin:0;'><span style='font-weight:bold; color:green;'>Server (" + DateTime.Now.ToString("HH:mm:ss") + ") -</span> " + messageSent + "</p>";
                    webBrowser.Update();
                });
            } catch {
                MessageBox.Show("HA nie wyslesz");
            }
               
        }

        private void bSend_Click(object sender, EventArgs e)
        {
            send();
            tbMessage.Clear();
        }

        private void tbMessage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                send();
                tbMessage.Clear();
            }
        }

        private void cbAddressList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedIp = cbAddressList.SelectedItem.ToString();
        }

        private void tbMessage_TextChanged(object sender, EventArgs e)
        {
            try {
                if (tbMessage.Text != "")
                {
                    broadcastMessage("%%notify%%", null, "Server");
                }
            } catch{}
           
        }

        private void bBold_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbMessage.Text += "<b></b>";
            });
        }

        private void bItalic_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                tbMessage.Text += "<i></i>";
            });
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                webBrowser.DocumentText = "";
            });
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                webBrowser.ShowSaveAsDialog();
            });
        }

        private void cbAddressList_TextChanged(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate
            {
                selectedIp = cbAddressList.Text;
            });
        }
    }
}
