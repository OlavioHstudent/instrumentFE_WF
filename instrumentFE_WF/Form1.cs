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
            try
            {
                TcpClient client = new TcpClient();
                client.Connect(textBox_DBIPaddress.Text, Convert.ToInt32(textBox2_TCPport.Text));

                if (client.Connected)
                {
                    textBox_connectionFeedback.Text = "Connected";
                }
                else
                {
                    textBox_connectionFeedback.Text = "Not Connected";
                }
            }

            catch  (System.Net.Sockets.SocketException)
            {
                string check_input_ipAddress = textBox_DBIPaddress.Text;
                int check_input_port = Convert.ToInt32(textBox2_TCPport.Text);

                if (!System.Net.IPAddress.TryParse(check_input_ipAddress, out IPAddress ipAddress))
                {
                    Console.WriteLine("asf");
                    connection_error_handling(check_input_ipAddress, "IP address");
                    return;
                }
                
                if (check_input_port < min_TCPport_value || max_TCPport_value > 65535)
                {
                    connection_error_handling(Convert.ToString(check_input_port), "port");
                    return;
                }
            }
             
        }

        private void buttonDisconnect_Click(object sender, EventArgs e)
        {

        }


    }
}