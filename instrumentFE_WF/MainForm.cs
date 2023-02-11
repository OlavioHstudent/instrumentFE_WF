using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace instrumentFE_WF
{
    public partial class MainForm : Form
    {
        string[] analogSignals;
        string[] digitalSignals;
        string[] fieldbusSignals;
        DateTime startTime;
        DateTime summaryTime;
        TimeSpan timeDiff;
        string timeDiffString;
        uint RecordTracker = 0;
        
        public MainForm()
        {
            InitializeComponent();
        }

//Shit to do on load
        private void app_Load(object sender, EventArgs e)
        {
            panel_tabConnections.Visible = true;
            panel_SensorData.Visible = false;

            startTime = DateTime.Now;
            maskedTextBox_LRV.Enabled = false;
            maskedTextBox_URV.Enabled = false;

            buttonConnect_Ino.Enabled = false;
            buttonDisconnect_Ino.Enabled = false;
            textBox_connectionFeedback_Ino.Text = "Not connected to any instrument yet";
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
                this.WindowState = FormWindowState.Maximized;
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
                Application.Exit();
            }
        }
        //Tabs
        //SensorData
        private void button_sensorData_Click(object sender, EventArgs e)
        {
            //Hide highlight and panel of other tabs
            button_InoConnection.BackColor = Color.FromArgb(31, 31, 31);
            button_Lists.BackColor = Color.FromArgb(31, 31, 31);

            panel_tabConnections.Visible = false;
            //panel_Lists.Visible = false;

            //Highlight this tab and show panel
            panel_SensorData.Visible = true;
            button_sensorData.BackColor = Color.FromArgb(56, 56, 56);
        }

        //Lists
        private void button_Lists_Click(object sender, EventArgs e)
        {
            //Hide highlight and panel of other tabs
            button_InoConnection.BackColor = Color.FromArgb(31, 31, 31);
            button_sensorData.BackColor = Color.FromArgb(31, 31, 31);

            panel_tabConnections.Visible = false;
            panel_SensorData.Visible = false;

            //Highlight this tab and show panel
            //panel_lists.Visible = true;
            button_Lists.BackColor = Color.FromArgb(56, 56, 56);
        }

        //Connections
        private void button_InoConnection_Click(object sender, EventArgs e)
        {
            //Hide highlight and panel of other tabs
            button_Lists.BackColor = Color.FromArgb(31, 31, 31);
            button_sensorData.BackColor = Color.FromArgb(31, 31, 31);

            //panel_lists.Visible = false;
            panel_SensorData.Visible = false;

            //Highlight this tab and show panel
            panel_tabConnections.Visible = true;
            button_InoConnection.BackColor = Color.FromArgb(56, 56, 56);
        }



        private void maskedTextBox_LRV_Click(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void button_Summary_Click(object sender, EventArgs e)
        {
            summaryTime = DateTime.Now;
            timeDiff = summaryTime.Subtract(startTime);
            timeDiffString = Convert.ToString(timeDiff);
            richTextBox_Summary.Text = $"Session timer: {timeDiffString.Substring(0, 8)}";
        }

        private void button_FromRadio_Click(object sender, EventArgs e)
        {
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

        private void buttonConnect_Ino_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textBox2_TCPport.Text, out CheckVarTypeInt))
            {
                inputTCPport = Convert.ToInt32(textBox2_TCPport.Text);
            }
            else
            {
                textBox2_TCPport.ResetText();
            }
        }
    }
}

