using SimpleTCP;
using SimpleTCP.Server;
using System;
using System.ComponentModel.Design;
using System.Net;
using System.Net.Sockets;

namespace TCP_IP_observer
{
    public partial class Form1 : Form
    {
        SimpleTcpServer server;
        List<User> users = new List<User>();
        string username = "";

        public Form1()
        {
            InitializeComponent();
            ComponentInit();
            server.ClientConnected += Server_ClientConnected;
            server.ClientDisconnected += Server_ClientDisconnected;
            server.DataReceived += Server_DataReceived;
        }

        private void Server_DataReceived(object? sender, SimpleTCP.Message e)
        {

            //untested
            if (e.MessageString.Contains("username:"))
            {
                username = e.MessageString.Split(':')[1];
            }
            else {
                string[] ipport = e.MessageString.Split(':');
                foreach (var user in users)
                {
                    if (ipport[0] == user.ip && Int32.Parse(ipport[1]) == user.port) {
                        username = user.nickname;
                    }
                    else
                    {
                        CheckUserAndConnect(e.TcpClient);
                    }
                } 
            }
            string tmp = e.MessageString.Remove(e.MessageString.Length - 1);
            label_logSystem.Text += "\n" + tmp;

            tmp = username + ": " + tmp;
            server.Broadcast(tmp);
        }

        private void Server_ClientDisconnected(object? sender, TcpClient e)
        {
            foreach (var item in listBox_listofconnected.Items)
            {
                if (e.Client.RemoteEndPoint.ToString() == item) { 
                    listBox_listofconnected.Items.Remove(item);
                    label_logSystem.Text += "\nKlient odpojen: " + e.Client.RemoteEndPoint.ToString();
                    break;
                } 
            }
        }

        private void Server_ClientConnected(object? sender, TcpClient e)
        {
            CheckUserAndConnect(e);
            //remove below
            RefreshClients();
            label_logSystem.Text += "\nKlient pøipojen: " + e.Client.RemoteEndPoint.ToString();
        }

        private void RefreshClients()
        {
            listBox_listofconnected.Items.Clear();
            foreach (var user in users)
            {
                listBox_listofconnected.Items.Add(user.nickname);
            }   

        }

        private void CheckUserAndConnect(TcpClient e)
        {
            if (e.Connected)
            {
                string ip = e.Client.RemoteEndPoint.ToString().Split(':')[0];
                string port = e.Client.RemoteEndPoint.ToString().Split(':')[1];
                if (!users.Contains(new User(username, ip, Int32.Parse(port))))
                {
                    users.Add(new User(username, ip, Int32.Parse(port)));
                }
                else {
                    label_logSystem.Text += "\nKlient již existuje";
                }
            }
        }

        private void ComponentInit()
        {
            button_off.Enabled = false;
            textBox_ip.Text = "10.30.1.19";
            textBox_port.Text = "8002";
            server = new SimpleTcpServer();   
        }

        private void button_off_Click(object sender, EventArgs e)
        {
            server.Stop();
            button_start.Enabled = true;
            button_off.Enabled = false;
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (server != null) { 
                    IPAddress ip = IPAddress.Parse(textBox_ip.Text);
                    int port = Int32.Parse(textBox_port.Text);  
                    server.Start(ip, port);
                    button_start.Enabled = false;
                    button_off.Enabled = true;
                    label_logSystem.Text += "\nServer bìží...";
                }
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.ToString());
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            //TODO
        }
    }
}