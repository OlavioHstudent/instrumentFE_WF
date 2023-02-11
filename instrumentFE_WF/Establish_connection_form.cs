using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace instrumentFE_WF {


    public partial class Establish_connection_form : Form {
        int min_TCPport_value = 1;
        int max_TCPport_value = 65535;

        int inputTCPport;
        int CheckVarTypeInt;

        public Establish_connection_form() {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e) {
            buttonConnect.Enabled = false;
            buttonDisconnect.Enabled = false;
            textBox_connectionFeedback.Text = "> Not connected";

            MainForm sensorDataForm = new MainForm();
            sensorDataForm.Show();
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

            public String connection_error_handling(string userInput = "Everything that is not numbers", string inputType = "") {
            textBox_connectionFeedback.Clear();
            textBox_connectionFeedback.Text = $"> Invalid {inputType}\n" +
                                              $"> Please enter a valid {inputType}.";
            return textBox_connectionFeedback.Text;
        }

        private void buttonConnect_Click(object sender, EventArgs e) {
            string in_DBIPaddress = textBox_DBIPaddress.Text;

            if (Int32.TryParse(textBox2_TCPport.Text, out CheckVarTypeInt)) {
                inputTCPport = Convert.ToInt32(textBox2_TCPport.Text);}
            else {
                textBox2_TCPport.ResetText();}

            try{
                TcpClient client = new TcpClient();
                client.Connect(in_DBIPaddress, inputTCPport);
                
                if (client.Connected){
                    buttonConnect.Enabled = false;
                    buttonDisconnect.Enabled = true;
                    // Send data to the server
                    textBox_connectionFeedback.Text = $"> Connection established\n" +
                                                      $"IP address: {in_DBIPaddress}\n" +
                                                      $"TCP port:   {inputTCPport}\n";

                    NetworkStream stream = client.GetStream();
                    string message = "Hello server";
                    byte[] messageBytes = Encoding.ASCII.GetBytes(message);
                    stream.Write(messageBytes, 0, messageBytes.Length);
                }
            }
            catch (System.Net.Sockets.SocketException){
                
                if (!System.Net.IPAddress.TryParse(in_DBIPaddress, out IPAddress ipAddress)){
                    connection_error_handling(in_DBIPaddress, "IP address");
                    return;}
                
                if (inputTCPport < min_TCPport_value || inputTCPport > max_TCPport_value){
                    connection_error_handling(Convert.ToString(inputTCPport), "port");
                    return;}}}

        private void buttonDisconnect_Click(object sender, EventArgs e) {
            buttonDisconnect.Enabled = false;
            DialogResult DisconnectYesNo = MessageBox.Show("Are you sure you want to disconnect?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (DisconnectYesNo == DialogResult.Yes) {
                TcpClient client = new TcpClient();
                client.Close();
                textBox2_TCPport.ResetText();
                textBox_DBIPaddress.ResetText();
                textBox_connectionFeedback.ResetText();
                textBox_connectionFeedback.Text = "> Not Connected";    }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}