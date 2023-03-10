using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace instrumentFE_WF {


    public partial class Form1 : Form {
        int min_TCPport_value = 1;
        int max_TCPport_value = 65535;
        int inputTCPport;
        int CheckVarTypeInt;

        public Form1() {
            InitializeComponent();
        }

        //Shit to do on load
        private async void Form1_Load(object sender, EventArgs e) {
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = false;
            textBox_connectionFeedback.Text = "> Not connected to any database";
        }

        //Main window funcitonality
        private void panel_Topcnct_MouseDown(object sender, MouseEventArgs e) {
            startPos = new Point(e.X, e.Y);
        }
        private void panel_Topcnct_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Point diff = new Point(e.X - startPos.X, e.Y - startPos.Y);
                this.Location = new Point(this.Location.X + diff.X, this.Location.Y + diff.Y);
            }
        }

        private void button_MinimizedCon_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_MaximizeCon_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button_ExitProgramCon_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        Point startPos;
        //Textbox functionality
        static void ClearLine(string text, int MoveBack, int xLines = 0) {
            if (MoveBack == 0) {
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.WriteLine(text);
            }
            if (MoveBack == 1) {
                Console.SetCursorPosition(0, Console.CursorTop - xLines);
                for (int i = 0; i < xLines; i++) {
                    Console.WriteLine(new string(' ', Console.BufferWidth));
                }
                Console.SetCursorPosition(0, Console.CursorTop - xLines);
            }
        }

        public String connection_error_handling(string userInput = "Everything that is not numbers", string inputType = "") {
            textBox_connectionFeedback.Clear();
            textBox_connectionFeedback.Text = $"> Invalid {inputType}\n" +
                                              $"> Please enter a valid {inputType}.";
            return textBox_connectionFeedback.Text;
        }

        //Buttons
        private void buttonConnect_Click(object sender, EventArgs e) {
            string in_DBIPaddress = textBox_DBIPaddress.Text;
            if (Int32.TryParse(textBox2_TCPport.Text, out CheckVarTypeInt)) {
                inputTCPport = Convert.ToInt32(textBox2_TCPport.Text);
            }
            else {
                textBox2_TCPport.ResetText();
            }
            try {
                TcpClient client = new TcpClient();
                client.Connect(in_DBIPaddress, inputTCPport);
                if (client.Connected) {
                    buttonConnect.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    // Send data to the server
                    textBox_connectionFeedback.Text = $"> Connection established\n" +
                                                      $"IP address: {in_DBIPaddress}\n" +
                                                      $"TCP port:   {inputTCPport}\n";
                    NetworkStream stream = client.GetStream();
                    DataTransfer dataTransfer = new DataTransfer(stream);
                    string availableCOMports = dataTransfer.ReceiveMessage();
                    MainForm MainForm = new MainForm(stream, dataTransfer, client, inputTCPport, availableCOMports);
                    MainForm.Show();
                    this.Hide();
                }
            }
            catch (System.Net.Sockets.SocketException) {

                if (!System.Net.IPAddress.TryParse(in_DBIPaddress, out IPAddress ipAddress)) {
                    connection_error_handling(in_DBIPaddress, "IP address");
                    return;
                }

                if (inputTCPport < min_TCPport_value || inputTCPport > max_TCPport_value) {
                    connection_error_handling(Convert.ToString(inputTCPport), "port");
                    return;
                }
            }
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
        //Textboxes
        private void textBox_DBIPaddress_TextChanged(object sender, EventArgs e) {
            if (textBox_DBIPaddress.Text.Length > 0 && textBox2_TCPport.Text.Length > 0) {
                buttonConnect.Enabled = true;
            }
        }

        private void textBox2_TCPport_TextChanged(object sender, EventArgs e) {
            if (textBox_DBIPaddress.Text.Length > 0 && textBox2_TCPport.Text.Length > 0) {
                buttonConnect.Enabled = true;
                AcceptButton = buttonConnect;
            }

            else if (textBox_DBIPaddress.Text.Length == 0 || textBox2_TCPport.Text.Length == 0) {
                buttonConnect.Enabled = false;
                AcceptButton = buttonConnect;
            }
        }
        private void textBox_connectionFeedback_TextChanged(object sender, EventArgs e) {
        }

        private void label2_Click(object sender, EventArgs e) {

        }
    }

    public class DataTransfer {

        private NetworkStream stream;
        private byte[] buffer = new byte[1024];

        public DataTransfer(NetworkStream stream) {
            this.stream = stream;
        }
        public void SendMessage(string message) {
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
        public string ReceiveMessage() {
            byte[] dataReceived = new byte[1024];
            int bytesRead = stream.Read(dataReceived, 0, dataReceived.Length);
            string MessageReceived = Encoding.ASCII.GetString(dataReceived, 0, bytesRead);

            return MessageReceived;
        }
    }

}