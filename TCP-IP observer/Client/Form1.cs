using SimpleTCP;
using System.ComponentModel;

namespace Client
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client;
        public Form1()
        {
            InitializeComponent();
            InitComponent();
            richTextBox_msg.KeyDown += RichTextBox_msg_KeyDown;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object? sender, SimpleTCP.Message e)
        {
            label_msgs.Text += "\n" + e.MessageString;
        }

        private void RichTextBox_msg_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tmp = $"{textBox_nickname};{richTextBox_msg.Text}";
                client.WriteLineAndGetReply(tmp, TimeSpan.FromSeconds(1));
                richTextBox_msg.Clear();
            }
        }

        private void InitComponent()
        {
            button_disconnect.Enabled = false;
            textBox1.Text = "10.30.1.19:8002";
            client = new SimpleTcpClient();
        }

        private void button_connect_Click(object sender, EventArgs e)
        {
            string[] ip_port = textBox1.Text.Split(':');
            try
            {
                client.Connect(ip_port[0], Int32.Parse(ip_port[1]));
                client.WriteLineAndGetReply($"username:{textBox_nickname.Text};", TimeSpan.FromSeconds(1));
                button_connect.Enabled = false;
                button_disconnect.Enabled = true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button_disconnect_Click(object sender, EventArgs e)
        {
            client.Disconnect();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}