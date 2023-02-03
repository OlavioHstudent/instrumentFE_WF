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

        private void SensorData_Load(object sender, EventArgs e)
        {
            panel_SensorData.Visible = true;
            startTime = DateTime.Now;
            maskedTextBox_LRV.Enabled = false;
            maskedTextBox_URV.Enabled = false;

        }


        private void button_SensorData_Click(object sender, EventArgs e)
        {
            panel_SensorData.Visible = true;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void SensorData_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label_SensorName_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void SensorDataButton_Click(object sender, EventArgs e)
        {
            panel_SensorData.Visible = true;
        }

        private void button_ExitProgram_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes){
                Application.Exit();}
        }

        private void button_Connection_Click(object sender, EventArgs e)
        {
            panel_SensorData.Visible = false;
            panel__Connection.Visible = true;
        }

        Point startPos;
        private void SensorData_MouseDown(object sender, MouseEventArgs e){
            startPos = new Point(e.X, e.Y);
        }
        private void SensorData_MouseMove(object sender, MouseEventArgs e){
            if (e.Button == MouseButtons.Left)
            {
                Point diff = new Point(e.X - startPos.X, e.Y - startPos.Y);
                this.Location = new Point(this.Location.X + diff.X, this.Location.Y + diff.Y);
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

        private void button_Maximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
            else
                this.WindowState = FormWindowState.Maximized;
        }
    }
}

