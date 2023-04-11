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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ScottPlot;
using static ScottPlot.Plottable.PopulationPlot;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace instrumentFE_WF
{
    public partial class MainForm : Form
    {
        private NetworkStream stream;
        private DataTransfer dataTransfer;
        private TcpClient client;
        string[] analogSignals;
        string[] digitalSignals;
        string[] fieldbusSignals;
        DateTime startTime;
        DateTime summaryTime;
        TimeSpan timeDiff;
        string timeDiffString;
        uint RecordTracker = 0;
        int CheckVarTypeInt;
        int inputCOMport;
        int buttonColor = 38;
        int CurrentTCPforBE;
        string selectedComPort;
        string selectedBitRate;
        string availableComPorts;
        string fetchedSensorData;
        double[] ReadSensorDataY = new double[1];
        double[] ReadSensorDataX = Array.Empty<double>();
        int[] datax = new int[0];
        string checkConnectionINO = "";
        string password = "";

        public string SensorName { get; set; }
        public string SerialNumber { get; set; }
        public string SignalType { get; set; }
        public string MeasureType { get; set; }
        public string Options { get; set; }
        public string LRV { get; set; }
        public string URV { get; set; }
        public string Comment { get; set; }

        public List<InstrumentGen> instrumentList = new List<InstrumentGen>();
        private InstrumentGen _instrumentGen = new InstrumentGen();

        public MainForm(NetworkStream stream, DataTransfer dataTransfer, TcpClient client, int ConnectedToTcpBE, string availableComports)
        {
            InitializeComponent();
            this.stream = stream;
            this.dataTransfer = dataTransfer;
            CurrentTCPforBE = ConnectedToTcpBE;
            availableComPorts = availableComports;
        }

        InstrumentManager _instrumentManager = new InstrumentManager();

        //Shit to do on load
        private void load_instrumentData()
        {
            var instruments = _instrumentManager.GetAll();

            foreach (var instrument in instruments)
            {
                updatecomboBox_InstrumentList();
            }
        }
        private void app_Load(object sender, EventArgs e)
        {
            try
            {
                load_instrumentData();
            }
            catch (Exception ex)
            {
                maskedTextBox_readwriteFeedback.Text = ex.Message;
                Exception innerException = ex.InnerException;
                while (innerException != null)
                {
                    richTextBox_comments.Text = innerException.Message;
                    innerException = innerException.InnerException;
                }
            }


            foreach (Control control in this.Controls)
            {
                control.Click += Control_Click;
            }
            string[] listAvailComPorts = availableComPorts.Split(',');
            comboBox_COMport.Items.Clear();
            foreach (string AvailablePort in listAvailComPorts)
            {
                comboBox_COMport.Items.Add(AvailablePort.Substring(3, 1));
            }


            textBox_currentCOM.Text = "No";
            panel_TabsConnections.Visible = true;
            panel_SensorData.Visible = false;
            startTime = DateTime.Now;
            maskedTextBox_LRV.Enabled = true;
            maskedTextBox_URV.Enabled = true;
            button_readconf.Enabled = false;
            button_writeconf.Enabled = false;
            button_readscaled.Enabled = false;
            button_readstatus.Enabled = false;
            buttonConnect_Ino.Enabled = false;
            buttonDisconnect_Ino.Enabled = false;
            panel_dataVis.Visible = false;
            button_FromRadio.Enabled = false;
            textBox_connectionFeedback_Ino.Text = "Not connected to any instrument yet";
            textBox_BE_currentTCP.Text = CurrentTCPforBE.ToString();



        }

        private void Control_Click(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            control.Focus();

        }
        //Main window funcitonality
        Point startPos;
        private void appWindow_MouseDown(object sender, MouseEventArgs e)
        {
            startPos = new Point(e.X, e.Y);
        }
        private void appWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point diff = new Point(e.X - startPos.X, e.Y - startPos.Y);
                this.Location = new Point(this.Location.X + diff.X, this.Location.Y + diff.Y);
            }
        }
        private void button_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Exit
        private void button_ExitProgram_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataTransfer.SendMessage("EXIT");
                Application.Exit();
            }
        }

        //SensorData Tab
        private void button_sensorData_Click(object sender, EventArgs e)
        {
            //Hide highlight and panel of other tabs
            button_InoConnection.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);
            //button_Lists.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);

            panel_TabsConnections.Visible = false;
            //panel_ListsTab.Visible = false;

            //Highlight this tab and show panel
            panel_SensorData.Visible = true;
            button_sensorData.BackColor = Color.FromArgb(56, 56, 56);
        }

        private void button_Lists_Click(object sender, EventArgs e)
        {
        }

        private void button_dataChart_Click(object sender, EventArgs e)
        {
            //Hide highlight and panel of other tabs
            button_sensorData.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);
            button_InoConnection.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);

            panel_SensorData.Visible = false;
            panel_TabsConnections.Visible = false;

            //Highlight this tab and show panel
            panel_dataVis.Visible = true;
            button_dataChart.BackColor = Color.FromArgb(56, 56, 56);
        }

        //Connections
        private void button_InoConnection_Click(object sender, EventArgs e)
        {
            //Hide highlight and panel of other tabs
            button_sensorData.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);
            button_dataChart.BackColor = Color.FromArgb(buttonColor, buttonColor, buttonColor);

            panel_SensorData.Visible = false;
            panel_dataVis.Visible = false;
            //Highlight this tab and show panel
            panel_TabsConnections.Visible = true;
            button_InoConnection.BackColor = Color.FromArgb(56, 56, 56);
        }

        private void buttonConnect_Ino_Click(object sender, EventArgs e)
        {
            string selectedComPort = Convert.ToString(comboBox_COMport.Text);
            string selectedBitRate = Convert.ToString(textBox_InoBitRate.Text);
            textBox_connectionFeedback_Ino.Text = "Connecting ...";
            if (Int32.TryParse(textBox_InoBitRate.Text, out CheckVarTypeInt))
            {
                inputCOMport = Convert.ToInt32(textBox_InoBitRate.Text);
            }
            else
            {
                textBox_InoBitRate.ResetText();
            }

            if (Int32.TryParse(comboBox_COMport.Text, out CheckVarTypeInt))
            {
                inputCOMport = Convert.ToInt32(comboBox_COMport.Text);
            }
            else
            {
                comboBox_COMport.ResetText();
            }

            if (textBox_InoBitRate.Text.Length > 1)
            {
                try
                {
                    dataTransfer.SendMessage($"COMcon {selectedComPort} + {selectedBitRate}");
                    checkConnectionINO = dataTransfer.ReceiveMessage();
                    if (checkConnectionINO == "Connection success")
                    {
                        buttonConnect_Ino.Enabled = false;
                        button_readconf.Enabled = true;

                        button_readscaled.Enabled = true;
                        button_readstatus.Enabled = true;
                        textBox_currentCOM.Text = "Yes";
                        textBox1_currentBEcom.Text = selectedComPort;
                        textBox_currentbitrate.Text = selectedBitRate;
                        textBox_connectionFeedback_Ino.Text = $"Connected to COM port {selectedComPort} at {selectedBitRate} bit rate";
                        buttonDisconnect_Ino.Enabled = true;
                    }
                    else if (checkConnectionINO == "Connection failed")
                    {
                        System.Threading.Thread.Sleep(0);
                        textBox_connectionFeedback_Ino.Text = $"Connection FAILED through COM port {selectedComPort} at {selectedBitRate} bit rate\nPlease try another COM port";
                    }
                }
                catch { }
            }
        }

        private void buttonDisconnect_Ino_Click(object sender, EventArgs e)
        {
            dataTransfer.SendMessage("COMdis");
            System.Threading.Thread.Sleep(0);
            textBox_connectionFeedback_Ino.Text = dataTransfer.ReceiveMessage();
            if (textBox_connectionFeedback_Ino.Text == "Disconnected from instrument")
            {
                buttonConnect_Ino.Enabled = true;
                textBox_currentCOM.Text = "No";
                textBox1_currentBEcom.Text = "";
                textBox_currentbitrate.Text = "";
                buttonDisconnect_Ino.Enabled = false;

                button_readconf.Enabled = false;
                button_writeconf.Enabled = false;
                button_readscaled.Enabled = false;
                button_readstatus.Enabled = false;
            }
        }
        private void maskedTextBox_LRV_Click(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void button_Summary_Click(object sender, EventArgs e)
        {
            summaryTime = DateTime.Now;
            timeDiff = summaryTime.Subtract(startTime);
            timeDiffString = Convert.ToString(timeDiff);
        }

        private void button_FromRadio_Click(object sender, EventArgs e)
        {
            try
            {

                Instrument instrument = new Instrument();
                instrument.instrumentName = maskedTextBox_SensorName.Text;
                instrument.serialNumber = maskedTextBox_SerialNumber.Text;
                instrument.signalType = comboBox_SignalType.Text;
                instrument.registerDate = DateTime.Now.ToString();
                instrument.measureType = comboBox_MeasureType.Text;
                instrument.options = richTextBox_options.Text;
                instrument.lrv = maskedTextBox_LRV.Text;
                instrument.urv = maskedTextBox_URV.Text;
                instrument.comment = richTextBox_comments.Text;

                if (_instrumentManager.Add(instrument))
                {
                    maskedTextBox_SensorName.ResetText();
                    maskedTextBox_SerialNumber.ResetText();
                    comboBox_SignalType.ResetText();
                    comboBox_MeasureType.ResetText();
                    richTextBox_options.ResetText();
                    checkBox_Registered.Checked = false;
                    richTextBox_comments.ResetText();
                    Console.WriteLine(instrument.instrumentName);
                    updatecomboBox_InstrumentList();
                    load_instrumentData();


                }
                /* if _dbContext.SaveChanges(); */

                /*
                string sensorName = maskedTextBox_SensorName.Text;
                string serialNumber = maskedTextBox_SerialNumber.Text;
                string signalType = comboBox_SignalType.Text;
                string measureType = comboBox_MeasureType.Text;
                string options = richTextBox_options.Text.ToString();
                string lrv = maskedTextBox_LRV.Text;
                string urv = maskedTextBox_URV.Text;
                string comment = richTextBox_comments.Text;

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
                */


            }
            catch (Exception ex)
            {
                maskedTextBox_readwriteFeedback.Text = ex.Message;
            }
        }

        private static void WriteToLogFile(InstrumentGen instrumentToLog)
        {
            string fileName = "InstrumentList.txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
            // Open the file for writing
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"Registered at FUNCTIONALITY NOT IMPLEMENTED YET\n" +
                        $"Sensor Name = {instrumentToLog.SensorName}\n" +
                        $"Serial Number = {instrumentToLog.SerialNumber}\n" +
                        $"SignalType = {instrumentToLog.SignalType}\n" +
                        $"MeasureType = {instrumentToLog.MeasureType}\n" +
                        $"Options = {instrumentToLog.Options}\n" +
                        $"LRV = {instrumentToLog.LRV}\n" +
                        $"URV = {instrumentToLog.URV}\n" +
                        $"Comment = {instrumentToLog.Comment}\n" +
                        $"\r\n");
                }
                fs.Close();
            }
        }
        private static void WriteSensorDataToLogFile(double[] data)
        {
            string fileName = "SensorData.txt";
            string filePath = Path.Combine(Environment.CurrentDirectory, fileName);
            using (FileStream fs = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        sw.WriteLine($"{i * 5}s: {data[i]} lx");
                    }
                }
                fs.Close();
            }
        }
        private void updatecomboBox_InstrumentList()
        {
            comboBox_InstrumentList.Items.Clear();
            comboBox_InstrumentList.Items.AddRange(_instrumentManager.GetAll().ToArray());
            comboBox_InstrumentList.DropDownHeight = comboBox_InstrumentList.ItemHeight * comboBox_InstrumentList.Items.Count;
            comboBox_InstrumentList.DisplayMember = "InstrumentName";
            /*
            InstrumentGen instrumentToLog = comboBox_InstrumentList.Items[comboBox_InstrumentList.Items.Count - 1] as InstrumentGen;
            WriteToLogFile(instrumentToLog);
            
            maskedTextBox_readwriteFeedback.Text = $"instrument {instrumentToLog.SensorName} has been saved to file";
            */
        }
        private void button_selectInstrument_Click(object sender, EventArgs e)
        {
            Instrument selectedInstrument = comboBox_InstrumentList.SelectedItem as Instrument;
            if (selectedInstrument != null)
            {
                maskedTextBox_SensorName.Text = selectedInstrument.instrumentName;
                maskedTextBox_SerialNumber.Text = selectedInstrument.serialNumber;
                comboBox_SignalType.Text = selectedInstrument.signalType;
                comboBox_MeasureType.Text = selectedInstrument.measureType;
                richTextBox_options.Text = selectedInstrument.options;
                maskedTextBox_LRV.Text = selectedInstrument.lrv;
                maskedTextBox_URV.Text = selectedInstrument.urv;
                richTextBox_comments.Text = selectedInstrument.comment;
                checkBox_Registered.Checked = true;
            }
        }

        private void label_selectSensor_Click(object sender, EventArgs e)
        {
            {
            }
        }

        private void radioButton_RegisterNew_CheckedChanged(object sender, EventArgs e)
        {
            button_FromRadio.Text = "Register New";
            if (maskedTextBox_SensorName.Text != "" &&
                maskedTextBox_SerialNumber.Text != "" &&
                comboBox_SignalType.Text != "" &&
                comboBox_MeasureType.Text != "" &&
                richTextBox_options.Text != "" &&
                maskedTextBox_LRV.Text != "" &&
                maskedTextBox_URV.Text != "")
            {
                button_FromRadio.Enabled = true;

            }
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
            if (comboBox_SignalType.SelectedItem == "Analog")
            {
                maskedTextBox_LRV.Enabled = true;
                maskedTextBox_URV.Enabled = true;
            }
        }

        private void label_Unit_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox_Options_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel_Help_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Help_MouseEnter(object sender, EventArgs e)
        {

        }

        private void panel6_Help_Leave(object sender, EventArgs e)
        {
        }

        private void panel__Connection_Click(object sender, EventArgs e)
        {
        }

        private void comboBox_COMport_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_COMport.Text.Length > 0 && textBox_InoBitRate.Text.Length > 0)
            {
                buttonConnect_Ino.Enabled = true;
            }
        }

        private void textBox_InoBitRate_TextChanged(object sender, EventArgs e)
        {
            if (comboBox_COMport.Text.Length > 0 && textBox_InoBitRate.Text.Length > 0)
            {
                buttonConnect_Ino.Enabled = true;
                AcceptButton = buttonConnect_Ino;
            }

            else if (comboBox_COMport.Text.Length == 0 || textBox_InoBitRate.Text.Length == 0)
            {
                buttonConnect_Ino.Enabled = false;
                AcceptButton = buttonConnect_Ino;
            }
        }



        private void button_config_Click(object sender, EventArgs e)
        {
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox_URV_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label_readwrite_Click(object sender, EventArgs e)
        {

        }

        private void label_InoBitRate_Click(object sender, EventArgs e)
        {

        }

        private void button_readconf_Click(object sender, EventArgs e)
        {
            dataTransfer.SendMessage("readconf");
            //System.Threading.Thread.Sleep(3000);
            string readconf = dataTransfer.ReceiveMessage();
            if (readconf.Substring(0, 8) == "readconf")
            {
                string[] readconfSplit = readconf.Split(';');
                string readName = readconfSplit[1];
                float readlrv = float.Parse(readconfSplit[2]);
                float readurv = float.Parse(readconfSplit[3]);
                int readalarml = Convert.ToInt32(readconfSplit[4]);
                int readalarmh = Convert.ToInt32(readconfSplit[5]);
                maskedTextBox_devicename.Text = readName;
                maskedTextBox_LRV.Text = Convert.ToString(readlrv);
                maskedTextBox_URV.Text = Convert.ToString(readurv);
                maskedTextBox_alarml.Text = Convert.ToString(readalarml);
                maskedTextBox_alarmh.Text = Convert.ToString(readalarmh);
                maskedTextBox_readwriteFeedback.Text = "'Read configuration' successful";
            }
        }

        private void button_writeconf_Click(object sender, EventArgs e)
        {
            string name = maskedTextBox_devicename.Text;
            string lrv = Convert.ToString(maskedTextBox_LRV.Text);
            string urv = Convert.ToString(maskedTextBox_URV.Text);
            string alarml = Convert.ToString(maskedTextBox_alarml.Text);
            string alarmh = Convert.ToString(maskedTextBox_alarmh.Text);
            password = maskedTextBox_writePassword.Text;
            string writeconf = $">{password}>{name};{lrv};{urv};{alarml};{alarmh}";
            if (password == "")
            {
                password = "abcdef";
            }
            dataTransfer.SendMessage(writeconf);
            string writeconfFeedback = dataTransfer.ReceiveMessage();
            if (writeconfFeedback.Substring(0, 8) == "You failed! Try again...?")
                maskedTextBox_readwriteFeedback.Text = "Wrong password. Please try again.";
        }

        private void button_readstatus_Click(object sender, EventArgs e)
        {
            dataTransfer.SendMessage("readstatus");
            string readstatus = dataTransfer.ReceiveMessage();
            maskedTextBox_readwriteFeedback.Text = $"{readstatus}";
        }
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button_readscaled_Click(object sender, EventArgs e)
        {
            if (1 == 1)
            { //Modify to match instrument/sensor
                formsPlot1.Plot.XLabel("Time (s)");
                formsPlot1.Plot.YLabel("Lux (lx)");
                formsPlot1.Plot.SetAxisLimits(null, null, 0, 500);
            }
            timer_readData.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Jeg vet jeg kunne gjort alt i ticken her mer ressurseffektivt, men jeg føler det er noe jeg 
            //best kan utføre når det finnes tid, så det er ikke mangel på forståelse.
            dataTransfer.SendMessage("readscaled");
            fetchedSensorData = dataTransfer.ReceiveMessage().Substring(11);
            ReadSensorDataY[ReadSensorDataY.Length - 1] = float.Parse(fetchedSensorData);
            maskedTextBox_currentReading.Text = fetchedSensorData;
            Array.Resize(ref ReadSensorDataY, ReadSensorDataY.Length + 1);
            datax = Enumerable.Range(0, ReadSensorDataY.Length).ToArray();
            ReadSensorDataX = datax.Select(i => (double)i * 5).ToArray();
            formsPlot1.Plot.AddScatter(ReadSensorDataX, ReadSensorDataY);
            maskedTextBox_HighestReading.Text = ReadSensorDataY.Max().ToString("F2");
            maskedTextBox_LowestReading.Text = ReadSensorDataY.Min().ToString("F2");
            maskedTextBox_AverageReading.Text = ReadSensorDataY.Average().ToString("F2");
            formsPlot1.Plot.SetOuterViewLimits(0, (ReadSensorDataY.Length - 1) * 5, 0, 500);
            formsPlot1.Plot.AxisAutoX();
            formsPlot1.Refresh();

        }

        private void button_StopReadscaled_Click(object sender, EventArgs e)
        {
            timer_readData.Stop();
            WriteSensorDataToLogFile(ReadSensorDataY);
        }

        private void maskedTextBox_writePassword_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBox_devicename.Text) ||
                string.IsNullOrEmpty(maskedTextBox_LRV.Text) ||
                string.IsNullOrEmpty(maskedTextBox_URV.Text) ||
                string.IsNullOrEmpty(maskedTextBox_alarml.Text) ||
                string.IsNullOrEmpty(maskedTextBox_alarmh.Text))
            {

                maskedTextBox_readwriteFeedback.Text = "Please fill in all the fields";
            }
            else if (!string.IsNullOrEmpty(maskedTextBox_devicename.Text) &&
                     float.TryParse(maskedTextBox_LRV.Text, out _) &&
                     float.TryParse(maskedTextBox_URV.Text, out _) &&
                     int.TryParse(maskedTextBox_alarml.Text, out _) &&
                     int.TryParse(maskedTextBox_alarmh.Text, out _) &&
                     checkConnectionINO == "Connection success")
            {
                button_writeconf.Enabled = true;

            }
        }

        private void button_writeconf_MouseHover(object sender, EventArgs e)
        {
            if (!button_writeconf.Enabled)
            {
                maskedTextBox_readwriteFeedback.Text = "Writeconfig requires a password";
            }
        }

        private void comboBox_InstrumentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}

