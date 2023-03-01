using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Text;
using System.IO.Pipes;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace instrumentFE_WF
{
    public partial class MainForm : Form
    {
        private NetworkStream stream;

        string[] analogSignals;
        string[] digitalSignals;
        string[] fieldbusSignals;
        DateTime startTime;
        DateTime summaryTime;
        TimeSpan timeDiff;
        string   timeDiffString;
        uint     RecordTracker = 0;
        int      CheckVarTypeInt;
        int      inputCOMport;
        int      buttonColor = 38;

        string selectedComPort;
        string selectedBitRate;

        public string SensorName { get; set;}
        public string SerialNumber { get; set; }
        public string SignalType { get; set; }
        public string MeasureType { get; set; }
        public string Options { get; set; }
        public string LRV { get; set; }
        public string URV { get; set; }
        public string Comment { get; set; }

        public List<InstrumentGen> instrumentList = new List<InstrumentGen>();
        private InstrumentGen _instrumentGen = new InstrumentGen();

        public MainForm(NetworkStream stream){
            InitializeComponent();
            this.stream = stream;
            string message = "readscaled";
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }

//Shit to do on load
        private void app_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls) {
                control.Click += Control_Click;
            }

            panel_tabConnections.Visible = true;
            panel_SensorData.Visible = false;
            panel6_Help.Visible = false;

            startTime = DateTime.Now;
            maskedTextBox_LRV.Enabled = false;
            maskedTextBox_URV.Enabled = false;

            buttonConnect_Ino.Enabled = false;
            buttonDisconnect_Ino.Enabled = false;
            textBox_connectionFeedback_Ino.Text = "Not connected to any instrument yet";

            //List all IPv4 addresses
            List<string> servers = new List<string>();

            IPAddress[] addresslist = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress address in addresslist) {
                if (address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) {
                    servers.Add(address.ToString());}}
            
        }

        private void Control_Click(object sender, EventArgs e) {
            Control control = (Control)sender;
            control.Focus();
            
        }   
//Main window funcitonality
        Point startPos;
        private void appWindow_MouseDown(object sender, MouseEventArgs e){
            startPos = new Point(e.X, e.Y);
        }
        private void appWindow_MouseMove(object sender, MouseEventArgs e){
            if (e.Button == MouseButtons.Left){
                Point diff = new Point(e.X - startPos.X, e.Y - startPos.Y);
                this.Location = new Point(this.Location.X + diff.X, this.Location.Y + diff.Y);
            }
        }
        private void button_Maximize_Click(object sender, EventArgs e){
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button_Minimize_Click(object sender, EventArgs e){
                this.WindowState = FormWindowState.Minimized;
        }
        private void appWindow_MouseClick(object sender, MouseEventArgs e) {
            if (!panel6_Help.Bounds.Contains(e.Location)) {
                panel6_Help.Visible = false;
            }
        }
        //Exit
        private void button_ExitProgram_Click(object sender, EventArgs e){
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes){
                Application.Exit();}
        }

        //SensorData Tab
        private void button_sensorData_Click(object sender, EventArgs e){
            //Hide highlight and panel of other tabs
            button_InoConnection.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);
            button_Lists.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);

            panel_tabConnections.Visible = false;
            panel_ListsTab.Visible = false;

            //Highlight this tab and show panel
            panel_SensorData.Visible = true;
            button_sensorData.BackColor = Color.FromArgb(56, 56, 56);
        }

        //Lists Tab
        private void button_Lists_Click(object sender, EventArgs e){
            //Hide highlight and panel of other tabs
            button_InoConnection.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);
            button_sensorData.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);

            panel_tabConnections.Visible = false;
            panel_SensorData.Visible = false;

            //Highlight this tab and show panel
            panel_ListsTab.Visible = true;
            button_Lists.BackColor = Color.FromArgb(56, 56, 56);
        }

        //Connections
        private void button_InoConnection_Click(object sender, EventArgs e){
            //Hide highlight and panel of other tabs
            button_Lists.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);
            button_sensorData.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);

            panel_ListsTab.Visible = false;
            panel_SensorData.Visible = false;

            //Highlight this tab and show panel
            panel_tabConnections.Visible = true;
            button_InoConnection.BackColor = Color.FromArgb(56, 56, 56);
        }

//Buttons

        private void SendToBE(byte[] data) {
            stream.Write(data, 0, data.Length);
        }
        private void buttonConnect_Ino_Click(object sender, EventArgs e){
            string selectedComPort = Convert.ToString(comboBox_COMport.Text);
            string selectedBitRate = Convert.ToString(textBox_InoBitRate.Text);

            if (Int32.TryParse(textBox_InoBitRate.Text, out CheckVarTypeInt)){
                inputCOMport = Convert.ToInt32(textBox_InoBitRate.Text);}
            else{
                textBox_InoBitRate.ResetText();}

            if (Int32.TryParse(comboBox_COMport.Text, out CheckVarTypeInt)) {
                inputCOMport = Convert.ToInt32(comboBox_COMport.Text);
            }
            else {
                comboBox_COMport.ResetText();
            }

            if (comboBox_COMport.Text.Length > 1 && textBox_InoBitRate.Text.Length > 1) {
                try {
                    string message = "readscaled";
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    SendToBE(data);
                }
                catch { }
            }
        }

        private void maskedTextBox_LRV_Click(object sender, MaskInputRejectedEventArgs e){
        }

        private void button_Summary_Click(object sender, EventArgs e){
            summaryTime = DateTime.Now;
            timeDiff = summaryTime.Subtract(startTime);
            timeDiffString = Convert.ToString(timeDiff);
            richTextBox_Summary.Text = $"Session timer: {timeDiffString.Substring(0, 8)}";
        }

        private void button_FromRadio_Click(object sender, EventArgs e)
        {
            string sensorName   = maskedTextBox_SensorName.Text;
            string serialNumber = maskedTextBox_SerialNumber.Text;
            string signalType   = comboBox_SignalType.Text;
            string measureType  = comboBox_MeasureType.Text;
            string options      = listBox_Options.SelectedIndex.ToString();
            string lrv          = maskedTextBox_LRV.Text;
            string urv          = maskedTextBox_URV.Text;
            string comment      = listBox_Comment.Text;

            _instrumentGen.CreateInstrument(
                sensorName, 
                serialNumber, 
                signalType, 
                measureType, 
                options, 
                lrv, 
                urv, 
                comment
                );
            updatecomboBox_InstrumentList();
        }

        private void updatecomboBox_InstrumentList() {
            comboBox_InstrumentList.Items.Clear();
            comboBox_InstrumentList.Items.AddRange(_instrumentGen.GetInstruments().ToArray());
            comboBox_InstrumentList.DropDownHeight = comboBox_InstrumentList.ItemHeight * comboBox_InstrumentList.Items.Count;
            comboBox_InstrumentList.DisplayMember= "SensorName";
        }

        private void radioButton_RegisterNew_CheckedChanged(object sender, EventArgs e)
        {
            button_FromRadio.Text = "Register New";
        }

        private void radioButton_SaveChanges_CheckedChanged(object sender, EventArgs e)
        {
            button_FromRadio.Text = "Save Changes";
        }

        private void radioButton_Delete_CheckedChanged(object sender, EventArgs e)
        {
            button_FromRadio.Text = "Delete";
        }

        private void comboBox_SignalType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SignalType.SelectedItem == "Analog"){
                maskedTextBox_LRV.Enabled = true;
                maskedTextBox_URV.Enabled = true;
            }
        }

        private void label_Unit_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_Options_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            panel6_Help.Visible = true;
            panel6_Help.Focus();
        }

        private void panel_Help_Paint(object sender, PaintEventArgs e) {

        }

        private void panel6_Help_MouseEnter(object sender, EventArgs e) {

        }

        private void panel6_Help_Leave(object sender, EventArgs e) {
            panel6_Help.Visible = false;
            panel10.Focus();
        }

        private void panel__Connection_Click(object sender, EventArgs e) {
            panel__Connection.Focus();
        }

        private void comboBox_COMport_TextChanged(object sender, EventArgs e) {
            if (comboBox_COMport.Text.Length > 0 && textBox_InoBitRate.Text.Length > 0) {
                buttonConnect_Ino.Enabled = true;
            }
        }

        private void textBox_InoBitRate_TextChanged(object sender, EventArgs e) {
            if (comboBox_COMport.Text.Length > 0 && textBox_InoBitRate.Text.Length > 0) {
                buttonConnect_Ino.Enabled = true;
                AcceptButton = buttonConnect_Ino;
            }

            else if (comboBox_COMport.Text.Length == 0 || textBox_InoBitRate.Text.Length == 0) {
                buttonConnect_Ino.Enabled = false;
                AcceptButton = buttonConnect_Ino;
            }
        }
    }
}

