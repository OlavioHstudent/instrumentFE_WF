using System.Net;
using System.Net.Sockets;

namespace instrumentFE_WF
{
    public partial class Form1 : Form
    {
        int min_TCPport_value = 1;
        int max_TCPport_value = 65535;
        
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = false;
        }
        

        public String connection_error_handling(string user_input, string input_type)
        {
            textBox_connectionFeedback.Clear();
            textBox_connectionFeedback.Text = $"{user_input} is an invalid {input_type}\n" +
                                              $"Please enter a valid {input_type}.";
            return textBox_connectionFeedback.Text;
        }
        
        
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string in_DBIPaddress = textBox_DBIPaddress.Text;
            int in_TCPport = Convert.ToInt32(textBox2_TCPport.Text);
            
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(in_DBIPaddress, in_TCPport);

                if (client.Connected)
                {
                    textBox_connectionFeedback.Text = $"> Connection established with {in_DBIPaddress} through port {in_TCPport}";
                } 
            }

            catch  (System.Net.Sockets.SocketException)
            {

                if (!System.Net.IPAddress.TryParse(in_DBIPaddress, out IPAddress ipAddress))
                {
                    connection_error_handling(in_DBIPaddress, "IP address");
                    return;
                }
                
                if (in_TCPport < min_TCPport_value || in_TCPport > max_TCPport_value)
                {
                    connection_error_handling(Convert.ToString(in_TCPport), "port");
                    return;
                }
            }
             
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {

        }

        private void textBox_DBIPaddress_TextChanged(object sender, EventArgs e)
        {
            if (textBox_DBIPaddress.Text.Length > 0 && textBox2_TCPport.Text.Length > 0)
            {
                buttonConnect.Enabled = true;
            }
        }

        private void textBox2_TCPport_TextChanged(object sender, EventArgs e)
        {
            if (textBox_DBIPaddress.Text.Length > 0 && textBox2_TCPport.Text.Length > 0)
            {
                buttonConnect.Enabled = true;
            }
        }
    }
}