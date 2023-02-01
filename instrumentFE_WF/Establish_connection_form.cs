using System.Net;
using System.Net.Sockets;

namespace instrumentFE_WF {


    public partial class Establish_connection_form : Form {
        int min_TCPport_value = 1;
        int max_TCPport_value = 65535;

       /* TcpClient client = new TcpClient(); */

        public Establish_connection_form() {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) {
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = false;
            textBox_connectionFeedback.Text = "> Not connected";
        }

        static void ClearLine(string text, int MoveBack, int xLines = 0) {

            if (MoveBack == 0) {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine(text);    }

            if (MoveBack == 1) {
                Console.SetCursorPosition(0, Console.CursorTop - xLines);

                for (int i = 0; i < xLines; i++) {
                    Console.WriteLine(new string(' ', Console.BufferWidth));}

                Console.SetCursorPosition(0, Console.CursorTop - xLines);   }
        }

            public String connection_error_handling(string user_input, string input_type) {
            textBox_connectionFeedback.Clear();
            textBox_connectionFeedback.Text = $"> {user_input} is an invalid {input_type}\n" +
                                              $"> Please enter a valid {input_type}.";
            return textBox_connectionFeedback.Text;
        }

        private void buttonConnect_Click(object sender, EventArgs e) {
            string in_DBIPaddress = textBox_DBIPaddress.Text;
            int in_TCPport = Convert.ToInt32(textBox2_TCPport.Text);

            try {
                    TcpClient client = new TcpClient();
                client.Connect(in_DBIPaddress, in_TCPport);
                if (client.Connected) {
                    buttonConnect.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    textBox_connectionFeedback.Text = $"> Connection established\n" +
                                                      $"IP address: {in_DBIPaddress}\n" +
                                                      $"TCP port:   {in_TCPport}\n";
                    Form2 form2 = new Form2();}
            }
            catch (System.Net.Sockets.SocketException) {
                if (!System.Net.IPAddress.TryParse(in_DBIPaddress, out IPAddress ipAddress)) {
                    connection_error_handling(in_DBIPaddress, "IP address");
                    return;
                }
                if (in_TCPport < min_TCPport_value || in_TCPport > max_TCPport_value) {
                    connection_error_handling(Convert.ToString(in_TCPport), "port");
                    return; }}
        }

        private void buttonDisconnect_Click(object sender, EventArgs e) {
            buttonDisconnect.Enabled = false;
            DialogResult DisconnectYesNo = MessageBox.Show("Are you sure you want to disconnect?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DisconnectYesNo == DialogResult.Yes) {
                TcpClient client = new TcpClient();
                client.Close();
                textBox2_TCPport.ResetText();
                textBox_DBIPaddress.ResetText();
                textBox_connectionFeedback.ResetText();
                textBox_connectionFeedback.Text = "> Not Connected";

            }
        }
        private void textBox_DBIPaddress_TextChanged(object sender, EventArgs e) {
                if (textBox_DBIPaddress.Text.Length > 0 && textBox2_TCPport.Text.Length > 0) {
                    buttonConnect.Enabled = true;   }
            }
        private void textBox2_TCPport_TextChanged(object sender, EventArgs e) {
                if (textBox_DBIPaddress.Text.Length > 0 && textBox2_TCPport.Text.Length > 0) {
                    buttonConnect.Enabled = true;
                    AcceptButton = buttonConnect;   }
                
                else if (textBox_DBIPaddress.Text.Length == 0 || textBox2_TCPport.Text.Length == 0) {
                    buttonConnect.Enabled = false;
                    AcceptButton = buttonConnect;   }
            }
        private void textBox_connectionFeedback_TextChanged(object sender, EventArgs e) {
        }
    }
}