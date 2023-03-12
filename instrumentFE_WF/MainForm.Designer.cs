namespace instrumentFE_WF
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_TopBar = new System.Windows.Forms.Panel();
            this.button_Minimize = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.button_Maximize = new System.Windows.Forms.Button();
            this.button_ExitProgram = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TopLogo = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_dataChart = new System.Windows.Forms.Button();
            this.button_sensorData = new System.Windows.Forms.Button();
            this.button_InoConnection = new System.Windows.Forms.Button();
            this.panel5_Help = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_selectInstrument = new System.Windows.Forms.Button();
            this.label_chooseinstrument = new System.Windows.Forms.Label();
            this.comboBox_InstrumentList = new System.Windows.Forms.ComboBox();
            this.panel_SensorData = new System.Windows.Forms.Panel();
            this.label_instrumentpanel = new System.Windows.Forms.Label();
            this.listBox_Comment = new System.Windows.Forms.ListBox();
            this.listBox_Options = new System.Windows.Forms.ListBox();
            this.button_FromRadio = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton_Delete = new System.Windows.Forms.RadioButton();
            this.radioButton_SaveChanges = new System.Windows.Forms.RadioButton();
            this.radioButton_RegisterNew = new System.Windows.Forms.RadioButton();
            this.label_Comment = new System.Windows.Forms.Label();
            this.label_Options = new System.Windows.Forms.Label();
            this.comboBox_MeasureType = new System.Windows.Forms.ComboBox();
            this.label_SignalType = new System.Windows.Forms.Label();
            this.label_MeasureType = new System.Windows.Forms.Label();
            this.comboBox_SignalType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_RegDate = new System.Windows.Forms.Label();
            this.checkBox_Registered = new System.Windows.Forms.CheckBox();
            this.label_Registered = new System.Windows.Forms.Label();
            this.label_SerialNumber = new System.Windows.Forms.Label();
            this.maskedTextBox_SerialNumber = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_SensorName = new System.Windows.Forms.MaskedTextBox();
            this.label_SensorName = new System.Windows.Forms.Label();
            this.panel_TabsConnections = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_COMport = new System.Windows.Forms.ComboBox();
            this.buttonConnect_Ino = new System.Windows.Forms.Button();
            this.label_InoComPort = new System.Windows.Forms.Label();
            this.textBox_InoBitRate = new System.Windows.Forms.TextBox();
            this.textBox_connectionFeedback_Ino = new System.Windows.Forms.RichTextBox();
            this.buttonDisconnect_Ino = new System.Windows.Forms.Button();
            this.label_InoBitRate = new System.Windows.Forms.Label();
            this.panel_dataVis = new System.Windows.Forms.Panel();
            this.label_currentReading = new System.Windows.Forms.Label();
            this.maskedTextBox_currentReading = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_AverageReading = new System.Windows.Forms.MaskedTextBox();
            this.label_AverageReading = new System.Windows.Forms.Label();
            this.label_LowestReading = new System.Windows.Forms.Label();
            this.maskedTextBox_LowestReading = new System.Windows.Forms.MaskedTextBox();
            this.label_HighestReading = new System.Windows.Forms.Label();
            this.maskedTextBox_HighestReading = new System.Windows.Forms.MaskedTextBox();
            this.button_StopReadscaled = new System.Windows.Forms.Button();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.button_readscaled = new System.Windows.Forms.Button();
            this.maskedTextBox_devicename = new System.Windows.Forms.MaskedTextBox();
            this.label_Unit = new System.Windows.Forms.Label();
            this.maskedTextBox_URV = new System.Windows.Forms.MaskedTextBox();
            this.label_URV = new System.Windows.Forms.Label();
            this.maskedTextBox_LRV = new System.Windows.Forms.MaskedTextBox();
            this.label_LRV = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox_readwriteFeedback = new System.Windows.Forms.MaskedTextBox();
            this.label_writePassword = new System.Windows.Forms.Label();
            this.maskedTextBox_writePassword = new System.Windows.Forms.MaskedTextBox();
            this.button_readstatus = new System.Windows.Forms.Button();
            this.label_readwrite = new System.Windows.Forms.Label();
            this.maskedTextBox_alarmh = new System.Windows.Forms.MaskedTextBox();
            this.button_writeconf = new System.Windows.Forms.Button();
            this.label_alarmh = new System.Windows.Forms.Label();
            this.button_readconf = new System.Windows.Forms.Button();
            this.maskedTextBox_alarml = new System.Windows.Forms.MaskedTextBox();
            this.label_alarml = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_Help = new System.Windows.Forms.Button();
            this.button_File = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_currentbitrate = new System.Windows.Forms.TextBox();
            this.label_currentbitrate = new System.Windows.Forms.Label();
            this.textBox1_currentBEcom = new System.Windows.Forms.TextBox();
            this.label_currentCOM = new System.Windows.Forms.Label();
            this.textBox_currentCOM = new System.Windows.Forms.TextBox();
            this.label_BE_currentCOM = new System.Windows.Forms.Label();
            this.textBox_BE_currentTCP = new System.Windows.Forms.TextBox();
            this.label_BE_currentTCP = new System.Windows.Forms.Label();
            this.timer_readData = new System.Windows.Forms.Timer(this.components);
            this.panel_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5_Help.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_SensorData.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_TabsConnections.SuspendLayout();
            this.panel_dataVis.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_TopBar
            // 
            this.panel_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_TopBar.Controls.Add(this.button_Minimize);
            this.panel_TopBar.Controls.Add(this.flowLayoutPanel3);
            this.panel_TopBar.Controls.Add(this.button_Maximize);
            this.panel_TopBar.Controls.Add(this.button_ExitProgram);
            this.panel_TopBar.Controls.Add(this.flowLayoutPanel2);
            this.panel_TopBar.Controls.Add(this.tableLayoutPanel1);
            this.panel_TopBar.Controls.Add(this.flowLayoutPanel1);
            this.panel_TopBar.Controls.Add(this.TopLogo);
            this.panel_TopBar.Location = new System.Drawing.Point(0, 0);
            this.panel_TopBar.Margin = new System.Windows.Forms.Padding(0);
            this.panel_TopBar.Name = "panel_TopBar";
            this.panel_TopBar.Size = new System.Drawing.Size(1040, 32);
            this.panel_TopBar.TabIndex = 13;
            this.panel_TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appWindow_MouseDown);
            this.panel_TopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.appWindow_MouseMove);
            // 
            // button_Minimize
            // 
            this.button_Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Minimize.FlatAppearance.BorderSize = 0;
            this.button_Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Minimize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_Minimize.Location = new System.Drawing.Point(944, 0);
            this.button_Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.button_Minimize.Name = "button_Minimize";
            this.button_Minimize.Size = new System.Drawing.Size(32, 32);
            this.button_Minimize.TabIndex = 41;
            this.button_Minimize.Text = "—";
            this.button_Minimize.UseVisualStyleBackColor = true;
            this.button_Minimize.Click += new System.EventHandler(this.button_Minimize_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(150, 32);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1047, 27);
            this.flowLayoutPanel3.TabIndex = 15;
            // 
            // button_Maximize
            // 
            this.button_Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_Maximize.FlatAppearance.BorderSize = 0;
            this.button_Maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Maximize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_Maximize.Location = new System.Drawing.Point(976, 0);
            this.button_Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.button_Maximize.Name = "button_Maximize";
            this.button_Maximize.Size = new System.Drawing.Size(32, 32);
            this.button_Maximize.TabIndex = 40;
            this.button_Maximize.Text = "◻";
            this.button_Maximize.UseVisualStyleBackColor = true;
            this.button_Maximize.Click += new System.EventHandler(this.button_Maximize_Click);
            // 
            // button_ExitProgram
            // 
            this.button_ExitProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_ExitProgram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_ExitProgram.FlatAppearance.BorderSize = 0;
            this.button_ExitProgram.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_ExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExitProgram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_ExitProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_ExitProgram.Location = new System.Drawing.Point(1008, 0);
            this.button_ExitProgram.Margin = new System.Windows.Forms.Padding(0);
            this.button_ExitProgram.Name = "button_ExitProgram";
            this.button_ExitProgram.Size = new System.Drawing.Size(32, 32);
            this.button_ExitProgram.TabIndex = 39;
            this.button_ExitProgram.Text = "X";
            this.button_ExitProgram.UseVisualStyleBackColor = true;
            this.button_ExitProgram.Click += new System.EventHandler(this.button_ExitProgram_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(144, 32);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(739, 613);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 35);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(128, 40);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // TopLogo
            // 
            this.TopLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopLogo.Image = global::instrumentFE_WF.Properties.Resources.app_icon;
            this.TopLogo.Location = new System.Drawing.Point(472, 0);
            this.TopLogo.Name = "TopLogo";
            this.TopLogo.Size = new System.Drawing.Size(32, 32);
            this.TopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopLogo.TabIndex = 17;
            this.TopLogo.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel4.Controls.Add(this.button_dataChart);
            this.panel4.Controls.Add(this.button_sensorData);
            this.panel4.Controls.Add(this.button_InoConnection);
            this.panel4.Location = new System.Drawing.Point(0, 64);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1040, 40);
            this.panel4.TabIndex = 14;
            // 
            // button_dataChart
            // 
            this.button_dataChart.FlatAppearance.BorderSize = 0;
            this.button_dataChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_dataChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dataChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_dataChart.Location = new System.Drawing.Point(176, 0);
            this.button_dataChart.Name = "button_dataChart";
            this.button_dataChart.Size = new System.Drawing.Size(89, 40);
            this.button_dataChart.TabIndex = 39;
            this.button_dataChart.Text = "Data chart";
            this.button_dataChart.UseVisualStyleBackColor = true;
            this.button_dataChart.Click += new System.EventHandler(this.button_dataChart_Click);
            // 
            // button_sensorData
            // 
            this.button_sensorData.FlatAppearance.BorderSize = 0;
            this.button_sensorData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_sensorData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sensorData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_sensorData.Location = new System.Drawing.Point(0, 0);
            this.button_sensorData.Name = "button_sensorData";
            this.button_sensorData.Size = new System.Drawing.Size(89, 40);
            this.button_sensorData.TabIndex = 38;
            this.button_sensorData.Text = "Config";
            this.button_sensorData.UseVisualStyleBackColor = true;
            this.button_sensorData.Click += new System.EventHandler(this.button_sensorData_Click);
            // 
            // button_InoConnection
            // 
            this.button_InoConnection.FlatAppearance.BorderSize = 0;
            this.button_InoConnection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_InoConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_InoConnection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_InoConnection.Location = new System.Drawing.Point(88, 0);
            this.button_InoConnection.Name = "button_InoConnection";
            this.button_InoConnection.Size = new System.Drawing.Size(89, 40);
            this.button_InoConnection.TabIndex = 37;
            this.button_InoConnection.Text = "Connections";
            this.button_InoConnection.UseVisualStyleBackColor = true;
            this.button_InoConnection.Click += new System.EventHandler(this.button_InoConnection_Click);
            // 
            // panel5_Help
            // 
            this.panel5_Help.Controls.Add(this.button1);
            this.panel5_Help.Location = new System.Drawing.Point(40, 32);
            this.panel5_Help.Name = "panel5_Help";
            this.panel5_Help.Size = new System.Drawing.Size(200, 100);
            this.panel5_Help.TabIndex = 44;
            this.panel5_Help.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.button_selectInstrument);
            this.panel7.Controls.Add(this.label_chooseinstrument);
            this.panel7.Controls.Add(this.comboBox_InstrumentList);
            this.panel7.Location = new System.Drawing.Point(656, 120);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(368, 112);
            this.panel7.TabIndex = 34;
            // 
            // button_selectInstrument
            // 
            this.button_selectInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_selectInstrument.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_selectInstrument.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_selectInstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_selectInstrument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_selectInstrument.Location = new System.Drawing.Point(128, 80);
            this.button_selectInstrument.Name = "button_selectInstrument";
            this.button_selectInstrument.Size = new System.Drawing.Size(120, 23);
            this.button_selectInstrument.TabIndex = 39;
            this.button_selectInstrument.Text = "Select";
            this.button_selectInstrument.UseVisualStyleBackColor = false;
            this.button_selectInstrument.Click += new System.EventHandler(this.button_selectInstrument_Click);
            // 
            // label_chooseinstrument
            // 
            this.label_chooseinstrument.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_chooseinstrument.AutoSize = true;
            this.label_chooseinstrument.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_chooseinstrument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_chooseinstrument.Location = new System.Drawing.Point(40, 8);
            this.label_chooseinstrument.Name = "label_chooseinstrument";
            this.label_chooseinstrument.Size = new System.Drawing.Size(295, 28);
            this.label_chooseinstrument.TabIndex = 36;
            this.label_chooseinstrument.Text = "Select from saved Instruments:";
            // 
            // comboBox_InstrumentList
            // 
            this.comboBox_InstrumentList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_InstrumentList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_InstrumentList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_InstrumentList.FormattingEnabled = true;
            this.comboBox_InstrumentList.Location = new System.Drawing.Point(47, 47);
            this.comboBox_InstrumentList.Name = "comboBox_InstrumentList";
            this.comboBox_InstrumentList.Size = new System.Drawing.Size(280, 23);
            this.comboBox_InstrumentList.TabIndex = 34;
            // 
            // panel_SensorData
            // 
            this.panel_SensorData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_SensorData.Controls.Add(this.label_instrumentpanel);
            this.panel_SensorData.Controls.Add(this.listBox_Comment);
            this.panel_SensorData.Controls.Add(this.listBox_Options);
            this.panel_SensorData.Controls.Add(this.button_FromRadio);
            this.panel_SensorData.Controls.Add(this.panel2);
            this.panel_SensorData.Controls.Add(this.label_Comment);
            this.panel_SensorData.Controls.Add(this.label_Options);
            this.panel_SensorData.Controls.Add(this.comboBox_MeasureType);
            this.panel_SensorData.Controls.Add(this.label_SignalType);
            this.panel_SensorData.Controls.Add(this.label_MeasureType);
            this.panel_SensorData.Controls.Add(this.comboBox_SignalType);
            this.panel_SensorData.Controls.Add(this.dateTimePicker1);
            this.panel_SensorData.Controls.Add(this.label_RegDate);
            this.panel_SensorData.Controls.Add(this.checkBox_Registered);
            this.panel_SensorData.Controls.Add(this.label_Registered);
            this.panel_SensorData.Controls.Add(this.label_SerialNumber);
            this.panel_SensorData.Controls.Add(this.maskedTextBox_SerialNumber);
            this.panel_SensorData.Controls.Add(this.maskedTextBox_SensorName);
            this.panel_SensorData.Controls.Add(this.label_SensorName);
            this.panel_SensorData.Location = new System.Drawing.Point(16, 120);
            this.panel_SensorData.Margin = new System.Windows.Forms.Padding(0);
            this.panel_SensorData.Name = "panel_SensorData";
            this.panel_SensorData.Size = new System.Drawing.Size(624, 392);
            this.panel_SensorData.TabIndex = 15;
            // 
            // label_instrumentpanel
            // 
            this.label_instrumentpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_instrumentpanel.AutoSize = true;
            this.label_instrumentpanel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_instrumentpanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_instrumentpanel.Location = new System.Drawing.Point(192, 8);
            this.label_instrumentpanel.Name = "label_instrumentpanel";
            this.label_instrumentpanel.Size = new System.Drawing.Size(245, 28);
            this.label_instrumentpanel.TabIndex = 34;
            this.label_instrumentpanel.Text = "Instrument Management:";
            // 
            // listBox_Comment
            // 
            this.listBox_Comment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.listBox_Comment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Comment.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox_Comment.FormattingEnabled = true;
            this.listBox_Comment.ItemHeight = 15;
            this.listBox_Comment.Location = new System.Drawing.Point(120, 312);
            this.listBox_Comment.Name = "listBox_Comment";
            this.listBox_Comment.Size = new System.Drawing.Size(280, 60);
            this.listBox_Comment.TabIndex = 33;
            // 
            // listBox_Options
            // 
            this.listBox_Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.listBox_Options.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Options.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.listBox_Options.FormattingEnabled = true;
            this.listBox_Options.ItemHeight = 15;
            this.listBox_Options.Location = new System.Drawing.Point(120, 240);
            this.listBox_Options.Name = "listBox_Options";
            this.listBox_Options.Size = new System.Drawing.Size(280, 60);
            this.listBox_Options.TabIndex = 32;
            // 
            // button_FromRadio
            // 
            this.button_FromRadio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_FromRadio.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_FromRadio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_FromRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_FromRadio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_FromRadio.Location = new System.Drawing.Point(416, 184);
            this.button_FromRadio.Name = "button_FromRadio";
            this.button_FromRadio.Size = new System.Drawing.Size(195, 32);
            this.button_FromRadio.TabIndex = 31;
            this.button_FromRadio.Text = "Register New";
            this.button_FromRadio.UseVisualStyleBackColor = true;
            this.button_FromRadio.Click += new System.EventHandler(this.button_FromRadio_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioButton_Delete);
            this.panel2.Controls.Add(this.radioButton_SaveChanges);
            this.panel2.Controls.Add(this.radioButton_RegisterNew);
            this.panel2.Location = new System.Drawing.Point(416, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 112);
            this.panel2.TabIndex = 30;
            // 
            // radioButton_Delete
            // 
            this.radioButton_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_Delete.AutoSize = true;
            this.radioButton_Delete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_Delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.radioButton_Delete.Location = new System.Drawing.Point(48, 80);
            this.radioButton_Delete.Name = "radioButton_Delete";
            this.radioButton_Delete.Size = new System.Drawing.Size(66, 23);
            this.radioButton_Delete.TabIndex = 33;
            this.radioButton_Delete.TabStop = true;
            this.radioButton_Delete.Text = "Delete";
            this.radioButton_Delete.UseVisualStyleBackColor = true;
            this.radioButton_Delete.CheckedChanged += new System.EventHandler(this.radioButton_Delete_CheckedChanged);
            // 
            // radioButton_SaveChanges
            // 
            this.radioButton_SaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_SaveChanges.AutoSize = true;
            this.radioButton_SaveChanges.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_SaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.radioButton_SaveChanges.Location = new System.Drawing.Point(48, 48);
            this.radioButton_SaveChanges.Name = "radioButton_SaveChanges";
            this.radioButton_SaveChanges.Size = new System.Drawing.Size(112, 23);
            this.radioButton_SaveChanges.TabIndex = 32;
            this.radioButton_SaveChanges.TabStop = true;
            this.radioButton_SaveChanges.Text = "Save Changes";
            this.radioButton_SaveChanges.UseVisualStyleBackColor = true;
            this.radioButton_SaveChanges.CheckedChanged += new System.EventHandler(this.radioButton_SaveChanges_CheckedChanged);
            // 
            // radioButton_RegisterNew
            // 
            this.radioButton_RegisterNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_RegisterNew.AutoSize = true;
            this.radioButton_RegisterNew.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_RegisterNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.radioButton_RegisterNew.Location = new System.Drawing.Point(48, 16);
            this.radioButton_RegisterNew.Name = "radioButton_RegisterNew";
            this.radioButton_RegisterNew.Size = new System.Drawing.Size(107, 23);
            this.radioButton_RegisterNew.TabIndex = 31;
            this.radioButton_RegisterNew.TabStop = true;
            this.radioButton_RegisterNew.Text = "Register New";
            this.radioButton_RegisterNew.UseVisualStyleBackColor = true;
            this.radioButton_RegisterNew.CheckedChanged += new System.EventHandler(this.radioButton_RegisterNew_CheckedChanged);
            // 
            // label_Comment
            // 
            this.label_Comment.AutoSize = true;
            this.label_Comment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Comment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_Comment.Location = new System.Drawing.Point(16, 304);
            this.label_Comment.Name = "label_Comment";
            this.label_Comment.Size = new System.Drawing.Size(73, 19);
            this.label_Comment.TabIndex = 23;
            this.label_Comment.Text = "Comment:";
            // 
            // label_Options
            // 
            this.label_Options.AutoSize = true;
            this.label_Options.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Options.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_Options.Location = new System.Drawing.Point(16, 240);
            this.label_Options.Name = "label_Options";
            this.label_Options.Size = new System.Drawing.Size(61, 19);
            this.label_Options.TabIndex = 21;
            this.label_Options.Text = "Options:";
            // 
            // comboBox_MeasureType
            // 
            this.comboBox_MeasureType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_MeasureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_MeasureType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_MeasureType.FormattingEnabled = true;
            this.comboBox_MeasureType.Items.AddRange(new object[] {
            "Analog ",
            "Digital ",
            "Fieldbus"});
            this.comboBox_MeasureType.Location = new System.Drawing.Point(120, 200);
            this.comboBox_MeasureType.Name = "comboBox_MeasureType";
            this.comboBox_MeasureType.Size = new System.Drawing.Size(280, 23);
            this.comboBox_MeasureType.TabIndex = 20;
            // 
            // label_SignalType
            // 
            this.label_SignalType.AutoSize = true;
            this.label_SignalType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SignalType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_SignalType.Location = new System.Drawing.Point(16, 176);
            this.label_SignalType.Name = "label_SignalType";
            this.label_SignalType.Size = new System.Drawing.Size(80, 19);
            this.label_SignalType.TabIndex = 19;
            this.label_SignalType.Text = "Signal Type:";
            // 
            // label_MeasureType
            // 
            this.label_MeasureType.AutoSize = true;
            this.label_MeasureType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_MeasureType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_MeasureType.Location = new System.Drawing.Point(16, 208);
            this.label_MeasureType.Name = "label_MeasureType";
            this.label_MeasureType.Size = new System.Drawing.Size(97, 19);
            this.label_MeasureType.TabIndex = 18;
            this.label_MeasureType.Text = "Measure Type:";
            // 
            // comboBox_SignalType
            // 
            this.comboBox_SignalType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_SignalType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SignalType.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_SignalType.FormattingEnabled = true;
            this.comboBox_SignalType.Items.AddRange(new object[] {
            "Analog",
            "Digital",
            "Fieldbus"});
            this.comboBox_SignalType.Location = new System.Drawing.Point(120, 176);
            this.comboBox_SignalType.Name = "comboBox_SignalType";
            this.comboBox_SignalType.Size = new System.Drawing.Size(280, 23);
            this.comboBox_SignalType.TabIndex = 17;
            this.comboBox_SignalType.SelectedIndexChanged += new System.EventHandler(this.comboBox_SignalType_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.WhiteSmoke;
            this.dateTimePicker1.Location = new System.Drawing.Point(120, 144);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // label_RegDate
            // 
            this.label_RegDate.AutoSize = true;
            this.label_RegDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_RegDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_RegDate.Location = new System.Drawing.Point(16, 144);
            this.label_RegDate.Name = "label_RegDate";
            this.label_RegDate.Size = new System.Drawing.Size(71, 19);
            this.label_RegDate.TabIndex = 14;
            this.label_RegDate.Text = "Reg. Date:";
            // 
            // checkBox_Registered
            // 
            this.checkBox_Registered.AutoSize = true;
            this.checkBox_Registered.Location = new System.Drawing.Point(120, 120);
            this.checkBox_Registered.Name = "checkBox_Registered";
            this.checkBox_Registered.Size = new System.Drawing.Size(15, 14);
            this.checkBox_Registered.TabIndex = 13;
            this.checkBox_Registered.UseVisualStyleBackColor = true;
            // 
            // label_Registered
            // 
            this.label_Registered.AutoSize = true;
            this.label_Registered.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Registered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_Registered.Location = new System.Drawing.Point(16, 120);
            this.label_Registered.Name = "label_Registered";
            this.label_Registered.Size = new System.Drawing.Size(76, 19);
            this.label_Registered.TabIndex = 12;
            this.label_Registered.Text = "Registered:";
            // 
            // label_SerialNumber
            // 
            this.label_SerialNumber.AutoSize = true;
            this.label_SerialNumber.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SerialNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_SerialNumber.Location = new System.Drawing.Point(16, 88);
            this.label_SerialNumber.Name = "label_SerialNumber";
            this.label_SerialNumber.Size = new System.Drawing.Size(98, 19);
            this.label_SerialNumber.TabIndex = 11;
            this.label_SerialNumber.Text = "Serial Number:";
            // 
            // maskedTextBox_SerialNumber
            // 
            this.maskedTextBox_SerialNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_SerialNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_SerialNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_SerialNumber.Location = new System.Drawing.Point(120, 88);
            this.maskedTextBox_SerialNumber.Name = "maskedTextBox_SerialNumber";
            this.maskedTextBox_SerialNumber.Size = new System.Drawing.Size(280, 16);
            this.maskedTextBox_SerialNumber.TabIndex = 10;
            // 
            // maskedTextBox_SensorName
            // 
            this.maskedTextBox_SensorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_SensorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox_SensorName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_SensorName.Location = new System.Drawing.Point(120, 56);
            this.maskedTextBox_SensorName.Name = "maskedTextBox_SensorName";
            this.maskedTextBox_SensorName.Size = new System.Drawing.Size(280, 16);
            this.maskedTextBox_SensorName.TabIndex = 9;
            // 
            // label_SensorName
            // 
            this.label_SensorName.AutoSize = true;
            this.label_SensorName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SensorName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_SensorName.Location = new System.Drawing.Point(16, 56);
            this.label_SensorName.Name = "label_SensorName";
            this.label_SensorName.Size = new System.Drawing.Size(93, 19);
            this.label_SensorName.TabIndex = 0;
            this.label_SensorName.Text = "Sensor Name:";
            // 
            // panel_TabsConnections
            // 
            this.panel_TabsConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel_TabsConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_TabsConnections.Controls.Add(this.label1);
            this.panel_TabsConnections.Controls.Add(this.comboBox_COMport);
            this.panel_TabsConnections.Controls.Add(this.buttonConnect_Ino);
            this.panel_TabsConnections.Controls.Add(this.label_InoComPort);
            this.panel_TabsConnections.Controls.Add(this.textBox_InoBitRate);
            this.panel_TabsConnections.Controls.Add(this.textBox_connectionFeedback_Ino);
            this.panel_TabsConnections.Controls.Add(this.buttonDisconnect_Ino);
            this.panel_TabsConnections.Controls.Add(this.label_InoBitRate);
            this.panel_TabsConnections.Location = new System.Drawing.Point(16, 120);
            this.panel_TabsConnections.Name = "panel_TabsConnections";
            this.panel_TabsConnections.Size = new System.Drawing.Size(624, 392);
            this.panel_TabsConnections.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(200, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 28);
            this.label1.TabIndex = 37;
            this.label1.Text = "Connect to instrument:";
            // 
            // comboBox_COMport
            // 
            this.comboBox_COMport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBox_COMport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_COMport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_COMport.FormattingEnabled = true;
            this.comboBox_COMport.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox_COMport.Location = new System.Drawing.Point(232, 44);
            this.comboBox_COMport.Name = "comboBox_COMport";
            this.comboBox_COMport.Size = new System.Drawing.Size(104, 23);
            this.comboBox_COMport.TabIndex = 7;
            this.comboBox_COMport.TextChanged += new System.EventHandler(this.comboBox_COMport_TextChanged);
            // 
            // buttonConnect_Ino
            // 
            this.buttonConnect_Ino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonConnect_Ino.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonConnect_Ino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.buttonConnect_Ino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect_Ino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.buttonConnect_Ino.Location = new System.Drawing.Point(168, 72);
            this.buttonConnect_Ino.Name = "buttonConnect_Ino";
            this.buttonConnect_Ino.Size = new System.Drawing.Size(88, 32);
            this.buttonConnect_Ino.TabIndex = 4;
            this.buttonConnect_Ino.Text = "Connect";
            this.buttonConnect_Ino.UseVisualStyleBackColor = false;
            this.buttonConnect_Ino.Click += new System.EventHandler(this.buttonConnect_Ino_Click);
            // 
            // label_InoComPort
            // 
            this.label_InoComPort.AutoSize = true;
            this.label_InoComPort.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_InoComPort.Location = new System.Drawing.Point(168, 48);
            this.label_InoComPort.Name = "label_InoComPort";
            this.label_InoComPort.Size = new System.Drawing.Size(61, 15);
            this.label_InoComPort.TabIndex = 0;
            this.label_InoComPort.Text = "Com Port:";
            // 
            // textBox_InoBitRate
            // 
            this.textBox_InoBitRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_InoBitRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_InoBitRate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_InoBitRate.Location = new System.Drawing.Point(400, 48);
            this.textBox_InoBitRate.Name = "textBox_InoBitRate";
            this.textBox_InoBitRate.Size = new System.Drawing.Size(50, 16);
            this.textBox_InoBitRate.TabIndex = 2;
            this.textBox_InoBitRate.TextChanged += new System.EventHandler(this.textBox_InoBitRate_TextChanged);
            // 
            // textBox_connectionFeedback_Ino
            // 
            this.textBox_connectionFeedback_Ino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_connectionFeedback_Ino.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_connectionFeedback_Ino.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_connectionFeedback_Ino.Location = new System.Drawing.Point(168, 112);
            this.textBox_connectionFeedback_Ino.Name = "textBox_connectionFeedback_Ino";
            this.textBox_connectionFeedback_Ino.ReadOnly = true;
            this.textBox_connectionFeedback_Ino.Size = new System.Drawing.Size(280, 96);
            this.textBox_connectionFeedback_Ino.TabIndex = 6;
            this.textBox_connectionFeedback_Ino.Text = "";
            // 
            // buttonDisconnect_Ino
            // 
            this.buttonDisconnect_Ino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.buttonDisconnect_Ino.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDisconnect_Ino.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.buttonDisconnect_Ino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect_Ino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.buttonDisconnect_Ino.Location = new System.Drawing.Point(264, 72);
            this.buttonDisconnect_Ino.Name = "buttonDisconnect_Ino";
            this.buttonDisconnect_Ino.Size = new System.Drawing.Size(88, 32);
            this.buttonDisconnect_Ino.TabIndex = 5;
            this.buttonDisconnect_Ino.Text = "Disconnect";
            this.buttonDisconnect_Ino.UseVisualStyleBackColor = false;
            this.buttonDisconnect_Ino.Click += new System.EventHandler(this.buttonDisconnect_Ino_Click);
            // 
            // label_InoBitRate
            // 
            this.label_InoBitRate.AutoSize = true;
            this.label_InoBitRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_InoBitRate.Location = new System.Drawing.Point(352, 48);
            this.label_InoBitRate.Name = "label_InoBitRate";
            this.label_InoBitRate.Size = new System.Drawing.Size(44, 15);
            this.label_InoBitRate.TabIndex = 3;
            this.label_InoBitRate.Text = "Bitrate:";
            this.label_InoBitRate.Click += new System.EventHandler(this.label_InoBitRate_Click);
            // 
            // panel_dataVis
            // 
            this.panel_dataVis.Controls.Add(this.label_currentReading);
            this.panel_dataVis.Controls.Add(this.maskedTextBox_currentReading);
            this.panel_dataVis.Controls.Add(this.maskedTextBox_AverageReading);
            this.panel_dataVis.Controls.Add(this.label_AverageReading);
            this.panel_dataVis.Controls.Add(this.label_LowestReading);
            this.panel_dataVis.Controls.Add(this.maskedTextBox_LowestReading);
            this.panel_dataVis.Controls.Add(this.label_HighestReading);
            this.panel_dataVis.Controls.Add(this.maskedTextBox_HighestReading);
            this.panel_dataVis.Controls.Add(this.button_StopReadscaled);
            this.panel_dataVis.Controls.Add(this.formsPlot1);
            this.panel_dataVis.Controls.Add(this.button_readscaled);
            this.panel_dataVis.Location = new System.Drawing.Point(16, 120);
            this.panel_dataVis.Name = "panel_dataVis";
            this.panel_dataVis.Size = new System.Drawing.Size(624, 392);
            this.panel_dataVis.TabIndex = 38;
            // 
            // label_currentReading
            // 
            this.label_currentReading.AutoSize = true;
            this.label_currentReading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_currentReading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_currentReading.Location = new System.Drawing.Point(272, 320);
            this.label_currentReading.Name = "label_currentReading";
            this.label_currentReading.Size = new System.Drawing.Size(109, 19);
            this.label_currentReading.TabIndex = 44;
            this.label_currentReading.Text = "Highest reading:";
            // 
            // maskedTextBox_currentReading
            // 
            this.maskedTextBox_currentReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_currentReading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_currentReading.Location = new System.Drawing.Point(384, 320);
            this.maskedTextBox_currentReading.Name = "maskedTextBox_currentReading";
            this.maskedTextBox_currentReading.Size = new System.Drawing.Size(96, 23);
            this.maskedTextBox_currentReading.TabIndex = 45;
            // 
            // maskedTextBox_AverageReading
            // 
            this.maskedTextBox_AverageReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_AverageReading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_AverageReading.Location = new System.Drawing.Point(128, 368);
            this.maskedTextBox_AverageReading.Name = "maskedTextBox_AverageReading";
            this.maskedTextBox_AverageReading.Size = new System.Drawing.Size(96, 23);
            this.maskedTextBox_AverageReading.TabIndex = 43;
            // 
            // label_AverageReading
            // 
            this.label_AverageReading.AutoSize = true;
            this.label_AverageReading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_AverageReading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_AverageReading.Location = new System.Drawing.Point(16, 368);
            this.label_AverageReading.Name = "label_AverageReading";
            this.label_AverageReading.Size = new System.Drawing.Size(112, 19);
            this.label_AverageReading.TabIndex = 42;
            this.label_AverageReading.Text = "Average reading:";
            // 
            // label_LowestReading
            // 
            this.label_LowestReading.AutoSize = true;
            this.label_LowestReading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_LowestReading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_LowestReading.Location = new System.Drawing.Point(16, 344);
            this.label_LowestReading.Name = "label_LowestReading";
            this.label_LowestReading.Size = new System.Drawing.Size(105, 19);
            this.label_LowestReading.TabIndex = 40;
            this.label_LowestReading.Text = "Lowest reading:";
            // 
            // maskedTextBox_LowestReading
            // 
            this.maskedTextBox_LowestReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_LowestReading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_LowestReading.Location = new System.Drawing.Point(128, 344);
            this.maskedTextBox_LowestReading.Name = "maskedTextBox_LowestReading";
            this.maskedTextBox_LowestReading.Size = new System.Drawing.Size(96, 23);
            this.maskedTextBox_LowestReading.TabIndex = 41;
            // 
            // label_HighestReading
            // 
            this.label_HighestReading.AutoSize = true;
            this.label_HighestReading.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_HighestReading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_HighestReading.Location = new System.Drawing.Point(16, 320);
            this.label_HighestReading.Name = "label_HighestReading";
            this.label_HighestReading.Size = new System.Drawing.Size(109, 19);
            this.label_HighestReading.TabIndex = 39;
            this.label_HighestReading.Text = "Highest reading:";
            // 
            // maskedTextBox_HighestReading
            // 
            this.maskedTextBox_HighestReading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_HighestReading.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_HighestReading.Location = new System.Drawing.Point(128, 320);
            this.maskedTextBox_HighestReading.Name = "maskedTextBox_HighestReading";
            this.maskedTextBox_HighestReading.Size = new System.Drawing.Size(96, 23);
            this.maskedTextBox_HighestReading.TabIndex = 39;
            // 
            // button_StopReadscaled
            // 
            this.button_StopReadscaled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_StopReadscaled.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_StopReadscaled.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_StopReadscaled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_StopReadscaled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_StopReadscaled.Location = new System.Drawing.Point(488, 56);
            this.button_StopReadscaled.Name = "button_StopReadscaled";
            this.button_StopReadscaled.Size = new System.Drawing.Size(128, 40);
            this.button_StopReadscaled.TabIndex = 8;
            this.button_StopReadscaled.Text = "Stop reading sensor";
            this.button_StopReadscaled.UseVisualStyleBackColor = false;
            this.button_StopReadscaled.Click += new System.EventHandler(this.button_StopReadscaled_Click);
            // 
            // formsPlot1
            // 
            this.formsPlot1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.formsPlot1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formsPlot1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formsPlot1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.formsPlot1.Location = new System.Drawing.Point(13, 15);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(467, 297);
            this.formsPlot1.TabIndex = 0;
            // 
            // button_readscaled
            // 
            this.button_readscaled.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_readscaled.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_readscaled.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_readscaled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_readscaled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_readscaled.Location = new System.Drawing.Point(488, 16);
            this.button_readscaled.Name = "button_readscaled";
            this.button_readscaled.Size = new System.Drawing.Size(128, 40);
            this.button_readscaled.TabIndex = 7;
            this.button_readscaled.Text = "Start reading sensor";
            this.button_readscaled.UseVisualStyleBackColor = false;
            this.button_readscaled.Click += new System.EventHandler(this.button_readscaled_Click);
            // 
            // maskedTextBox_devicename
            // 
            this.maskedTextBox_devicename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_devicename.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_devicename.Location = new System.Drawing.Point(240, 40);
            this.maskedTextBox_devicename.Name = "maskedTextBox_devicename";
            this.maskedTextBox_devicename.Size = new System.Drawing.Size(88, 23);
            this.maskedTextBox_devicename.TabIndex = 28;
            this.maskedTextBox_devicename.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox3_MaskInputRejected);
            // 
            // label_Unit
            // 
            this.label_Unit.AutoSize = true;
            this.label_Unit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Unit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_Unit.Location = new System.Drawing.Point(184, 40);
            this.label_Unit.Name = "label_Unit";
            this.label_Unit.Size = new System.Drawing.Size(48, 19);
            this.label_Unit.TabIndex = 29;
            this.label_Unit.Text = "Name:";
            this.label_Unit.Click += new System.EventHandler(this.label_Unit_Click);
            // 
            // maskedTextBox_URV
            // 
            this.maskedTextBox_URV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_URV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_URV.Location = new System.Drawing.Point(240, 104);
            this.maskedTextBox_URV.Name = "maskedTextBox_URV";
            this.maskedTextBox_URV.Size = new System.Drawing.Size(88, 23);
            this.maskedTextBox_URV.TabIndex = 26;
            this.maskedTextBox_URV.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_URV_MaskInputRejected);
            // 
            // label_URV
            // 
            this.label_URV.AutoSize = true;
            this.label_URV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_URV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_URV.Location = new System.Drawing.Point(184, 104);
            this.label_URV.Name = "label_URV";
            this.label_URV.Size = new System.Drawing.Size(39, 19);
            this.label_URV.TabIndex = 27;
            this.label_URV.Text = "URV:";
            // 
            // maskedTextBox_LRV
            // 
            this.maskedTextBox_LRV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_LRV.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_LRV.HidePromptOnLeave = true;
            this.maskedTextBox_LRV.Location = new System.Drawing.Point(240, 72);
            this.maskedTextBox_LRV.Name = "maskedTextBox_LRV";
            this.maskedTextBox_LRV.Size = new System.Drawing.Size(88, 23);
            this.maskedTextBox_LRV.TabIndex = 25;
            // 
            // label_LRV
            // 
            this.label_LRV.AutoSize = true;
            this.label_LRV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_LRV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_LRV.Location = new System.Drawing.Point(184, 72);
            this.label_LRV.Name = "label_LRV";
            this.label_LRV.Size = new System.Drawing.Size(36, 19);
            this.label_LRV.TabIndex = 25;
            this.label_LRV.Text = "LRV:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.maskedTextBox_readwriteFeedback);
            this.panel1.Controls.Add(this.label_writePassword);
            this.panel1.Controls.Add(this.maskedTextBox_writePassword);
            this.panel1.Controls.Add(this.button_readstatus);
            this.panel1.Controls.Add(this.label_readwrite);
            this.panel1.Controls.Add(this.maskedTextBox_alarmh);
            this.panel1.Controls.Add(this.button_writeconf);
            this.panel1.Controls.Add(this.label_alarmh);
            this.panel1.Controls.Add(this.button_readconf);
            this.panel1.Controls.Add(this.label_LRV);
            this.panel1.Controls.Add(this.maskedTextBox_alarml);
            this.panel1.Controls.Add(this.maskedTextBox_LRV);
            this.panel1.Controls.Add(this.label_alarml);
            this.panel1.Controls.Add(this.label_URV);
            this.panel1.Controls.Add(this.maskedTextBox_devicename);
            this.panel1.Controls.Add(this.maskedTextBox_URV);
            this.panel1.Controls.Add(this.label_Unit);
            this.panel1.Location = new System.Drawing.Point(656, 248);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 264);
            this.panel1.TabIndex = 40;
            // 
            // maskedTextBox_readwriteFeedback
            // 
            this.maskedTextBox_readwriteFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_readwriteFeedback.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_readwriteFeedback.Location = new System.Drawing.Point(8, 232);
            this.maskedTextBox_readwriteFeedback.Name = "maskedTextBox_readwriteFeedback";
            this.maskedTextBox_readwriteFeedback.Size = new System.Drawing.Size(352, 23);
            this.maskedTextBox_readwriteFeedback.TabIndex = 38;
            // 
            // label_writePassword
            // 
            this.label_writePassword.AutoSize = true;
            this.label_writePassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_writePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_writePassword.Location = new System.Drawing.Point(80, 144);
            this.label_writePassword.Name = "label_writePassword";
            this.label_writePassword.Size = new System.Drawing.Size(70, 19);
            this.label_writePassword.TabIndex = 37;
            this.label_writePassword.Text = "Password:";
            // 
            // maskedTextBox_writePassword
            // 
            this.maskedTextBox_writePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_writePassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_writePassword.Location = new System.Drawing.Point(64, 168);
            this.maskedTextBox_writePassword.Name = "maskedTextBox_writePassword";
            this.maskedTextBox_writePassword.PasswordChar = '*';
            this.maskedTextBox_writePassword.Size = new System.Drawing.Size(96, 23);
            this.maskedTextBox_writePassword.TabIndex = 36;
            this.maskedTextBox_writePassword.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            this.maskedTextBox_writePassword.TextChanged += new System.EventHandler(this.maskedTextBox_writePassword_TextChanged);
            // 
            // button_readstatus
            // 
            this.button_readstatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_readstatus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_readstatus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_readstatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_readstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_readstatus.Location = new System.Drawing.Point(56, 104);
            this.button_readstatus.Name = "button_readstatus";
            this.button_readstatus.Size = new System.Drawing.Size(120, 23);
            this.button_readstatus.TabIndex = 8;
            this.button_readstatus.Text = "Get status";
            this.button_readstatus.UseVisualStyleBackColor = false;
            this.button_readstatus.Click += new System.EventHandler(this.button_readstatus_Click);
            // 
            // label_readwrite
            // 
            this.label_readwrite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_readwrite.AutoSize = true;
            this.label_readwrite.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_readwrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_readwrite.Location = new System.Drawing.Point(72, 0);
            this.label_readwrite.Name = "label_readwrite";
            this.label_readwrite.Size = new System.Drawing.Size(244, 28);
            this.label_readwrite.TabIndex = 35;
            this.label_readwrite.Text = "Read/Write to instrument";
            this.label_readwrite.Click += new System.EventHandler(this.label_readwrite_Click);
            // 
            // maskedTextBox_alarmh
            // 
            this.maskedTextBox_alarmh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_alarmh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_alarmh.Location = new System.Drawing.Point(240, 168);
            this.maskedTextBox_alarmh.Name = "maskedTextBox_alarmh";
            this.maskedTextBox_alarmh.Size = new System.Drawing.Size(88, 23);
            this.maskedTextBox_alarmh.TabIndex = 32;
            // 
            // button_writeconf
            // 
            this.button_writeconf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_writeconf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_writeconf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_writeconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_writeconf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_writeconf.Location = new System.Drawing.Point(56, 72);
            this.button_writeconf.Name = "button_writeconf";
            this.button_writeconf.Size = new System.Drawing.Size(120, 23);
            this.button_writeconf.TabIndex = 6;
            this.button_writeconf.Text = "Write config";
            this.button_writeconf.UseVisualStyleBackColor = false;
            this.button_writeconf.Click += new System.EventHandler(this.button_writeconf_Click);
            this.button_writeconf.MouseHover += new System.EventHandler(this.button_writeconf_MouseHover);
            // 
            // label_alarmh
            // 
            this.label_alarmh.AutoSize = true;
            this.label_alarmh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_alarmh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_alarmh.Location = new System.Drawing.Point(184, 168);
            this.label_alarmh.Name = "label_alarmh";
            this.label_alarmh.Size = new System.Drawing.Size(56, 19);
            this.label_alarmh.TabIndex = 33;
            this.label_alarmh.Text = "Alarmh:";
            // 
            // button_readconf
            // 
            this.button_readconf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.button_readconf.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button_readconf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_readconf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_readconf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_readconf.Location = new System.Drawing.Point(56, 40);
            this.button_readconf.Name = "button_readconf";
            this.button_readconf.Size = new System.Drawing.Size(120, 23);
            this.button_readconf.TabIndex = 5;
            this.button_readconf.Text = "Read config";
            this.button_readconf.UseVisualStyleBackColor = false;
            this.button_readconf.Click += new System.EventHandler(this.button_readconf_Click);
            // 
            // maskedTextBox_alarml
            // 
            this.maskedTextBox_alarml.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.maskedTextBox_alarml.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.maskedTextBox_alarml.Location = new System.Drawing.Point(240, 136);
            this.maskedTextBox_alarml.Name = "maskedTextBox_alarml";
            this.maskedTextBox_alarml.Size = new System.Drawing.Size(88, 23);
            this.maskedTextBox_alarml.TabIndex = 30;
            // 
            // label_alarml
            // 
            this.label_alarml.AutoSize = true;
            this.label_alarml.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_alarml.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_alarml.Location = new System.Drawing.Point(184, 136);
            this.label_alarml.Name = "label_alarml";
            this.label_alarml.Size = new System.Drawing.Size(51, 19);
            this.label_alarml.TabIndex = 31;
            this.label_alarml.Text = "Alarml:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel3.Controls.Add(this.panel5_Help);
            this.panel3.Controls.Add(this.button_Help);
            this.panel3.Controls.Add(this.button_File);
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1040, 32);
            this.panel3.TabIndex = 43;
            // 
            // button_Help
            // 
            this.button_Help.FlatAppearance.BorderSize = 0;
            this.button_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Help.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_Help.Location = new System.Drawing.Point(40, 0);
            this.button_Help.Name = "button_Help";
            this.button_Help.Size = new System.Drawing.Size(40, 32);
            this.button_Help.TabIndex = 40;
            this.button_Help.Text = "Help";
            this.button_Help.UseVisualStyleBackColor = true;
            this.button_Help.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_File
            // 
            this.button_File.FlatAppearance.BorderSize = 0;
            this.button_File.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_File.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_File.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_File.Location = new System.Drawing.Point(0, 0);
            this.button_File.Name = "button_File";
            this.button_File.Size = new System.Drawing.Size(40, 32);
            this.button_File.TabIndex = 39;
            this.button_File.Text = "File";
            this.button_File.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel5.Controls.Add(this.textBox_currentbitrate);
            this.panel5.Controls.Add(this.label_currentbitrate);
            this.panel5.Controls.Add(this.textBox1_currentBEcom);
            this.panel5.Controls.Add(this.label_currentCOM);
            this.panel5.Controls.Add(this.textBox_currentCOM);
            this.panel5.Controls.Add(this.label_BE_currentCOM);
            this.panel5.Controls.Add(this.textBox_BE_currentTCP);
            this.panel5.Controls.Add(this.label_BE_currentTCP);
            this.panel5.Location = new System.Drawing.Point(0, 544);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1040, 32);
            this.panel5.TabIndex = 45;
            // 
            // textBox_currentbitrate
            // 
            this.textBox_currentbitrate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_currentbitrate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_currentbitrate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_currentbitrate.Location = new System.Drawing.Point(960, 8);
            this.textBox_currentbitrate.Name = "textBox_currentbitrate";
            this.textBox_currentbitrate.Size = new System.Drawing.Size(50, 16);
            this.textBox_currentbitrate.TabIndex = 50;
            // 
            // label_currentbitrate
            // 
            this.label_currentbitrate.AutoSize = true;
            this.label_currentbitrate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_currentbitrate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_currentbitrate.Location = new System.Drawing.Point(904, 8);
            this.label_currentbitrate.Name = "label_currentbitrate";
            this.label_currentbitrate.Size = new System.Drawing.Size(52, 19);
            this.label_currentbitrate.TabIndex = 49;
            this.label_currentbitrate.Text = "Bitrate:";
            // 
            // textBox1_currentBEcom
            // 
            this.textBox1_currentBEcom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox1_currentBEcom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1_currentBEcom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1_currentBEcom.Location = new System.Drawing.Point(840, 8);
            this.textBox1_currentBEcom.Name = "textBox1_currentBEcom";
            this.textBox1_currentBEcom.Size = new System.Drawing.Size(50, 16);
            this.textBox1_currentBEcom.TabIndex = 48;
            // 
            // label_currentCOM
            // 
            this.label_currentCOM.AutoSize = true;
            this.label_currentCOM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_currentCOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_currentCOM.Location = new System.Drawing.Point(792, 8);
            this.label_currentCOM.Name = "label_currentCOM";
            this.label_currentCOM.Size = new System.Drawing.Size(45, 19);
            this.label_currentCOM.TabIndex = 47;
            this.label_currentCOM.Text = "COM:";
            // 
            // textBox_currentCOM
            // 
            this.textBox_currentCOM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_currentCOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_currentCOM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_currentCOM.Location = new System.Drawing.Point(728, 8);
            this.textBox_currentCOM.Name = "textBox_currentCOM";
            this.textBox_currentCOM.Size = new System.Drawing.Size(50, 16);
            this.textBox_currentCOM.TabIndex = 46;
            // 
            // label_BE_currentCOM
            // 
            this.label_BE_currentCOM.AutoSize = true;
            this.label_BE_currentCOM.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_BE_currentCOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_BE_currentCOM.Location = new System.Drawing.Point(560, 8);
            this.label_BE_currentCOM.Name = "label_BE_currentCOM";
            this.label_BE_currentCOM.Size = new System.Drawing.Size(166, 19);
            this.label_BE_currentCOM.TabIndex = 45;
            this.label_BE_currentCOM.Text = "Connected to instrument:";
            // 
            // textBox_BE_currentTCP
            // 
            this.textBox_BE_currentTCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_BE_currentTCP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_BE_currentTCP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_BE_currentTCP.Location = new System.Drawing.Point(184, 8);
            this.textBox_BE_currentTCP.Name = "textBox_BE_currentTCP";
            this.textBox_BE_currentTCP.Size = new System.Drawing.Size(50, 16);
            this.textBox_BE_currentTCP.TabIndex = 7;
            // 
            // label_BE_currentTCP
            // 
            this.label_BE_currentTCP.AutoSize = true;
            this.label_BE_currentTCP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_BE_currentTCP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label_BE_currentTCP.Location = new System.Drawing.Point(0, 8);
            this.label_BE_currentTCP.Name = "label_BE_currentTCP";
            this.label_BE_currentTCP.Size = new System.Drawing.Size(185, 19);
            this.label_BE_currentTCP.TabIndex = 44;
            this.label_BE_currentTCP.Text = "Connected to TCP (backend):";
            // 
            // timer_readData
            // 
            this.timer_readData.Interval = 5000;
            this.timer_readData.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1040, 579);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_TopBar);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel_SensorData);
            this.Controls.Add(this.panel_dataVis);
            this.Controls.Add(this.panel_TabsConnections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SensorData";
            this.Load += new System.EventHandler(this.app_Load);
            this.panel_TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel5_Help.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel_SensorData.ResumeLayout(false);
            this.panel_SensorData.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_TabsConnections.ResumeLayout(false);
            this.panel_TabsConnections.PerformLayout();
            this.panel_dataVis.ResumeLayout(false);
            this.panel_dataVis.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel_TopBar;
        private PictureBox TopLogo;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel2;
        private Panel panel2;
        private Label label_SensorName;
        private Panel panel4;
        private Panel panel_SensorData;
        private MaskedTextBox maskedTextBox_SerialNumber;
        private Label label_SerialNumber;
        private Label label_Registered;
        private CheckBox checkBox_Registered;
        private Label label_Options;
        private ComboBox comboBox_MeasureType;
        private Label label_SignalType;
        private Label label_MeasureType;
        private ComboBox comboBox_SignalType;
        private DateTimePicker dateTimePicker1;
        private Label label_RegDate;
        private Label label_Comment;
        private MaskedTextBox maskedTextBox_AverageReading;
        private Label label_Unit;
        private MaskedTextBox maskedTextBox_URV;
        private Label label_URV;
        private MaskedTextBox maskedTextBox_LRV;
        private Label label_LRV;
        private RadioButton radioButton_Delete;
        private RadioButton radioButton_SaveChanges;
        private RadioButton radioButton_RegisterNew;
        private Panel panel7;
        private Button button_FromRadio;
        private MaskedTextBox maskedTextBox_SensorName;
        private Button button_Minimize;
        private Button button_Maximize;
        private Button button_ExitProgram;
        private Panel panel1;
        private Button button_InoConnection;
        private Button button_sensorData;
        private ListBox listBox_Options;
        private ListBox listBox_Comment;
        private Button button_Help;
        private Panel panel3;
        private Button button_File;
        private Panel panel_Help;
        private Button button_About;
        private Panel panel5_Help;
        private Button button1;
        private Button buttonConnect_Ino;
        private TextBox textBox_InoBitRate;
        private Button buttonDisconnect_Ino;
        private Label label_InoBitRate;
        private RichTextBox textBox_connectionFeedback_Ino;
        private TextBox textBox_InoComPort;
        private Label label_InoComPort;
        private Label label_selectSensor;
        private ComboBox comboBox_InstrumentList;
        private ComboBox comboBox_COMport;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BindingSource bindingSource1;
        private Button button_readstatus;
        private Button button_readscaled;
        private Button button_writeconf;
        private Button button_readconf;
        private MaskedTextBox maskedTextBox_alarmh;
        private Label label_alarmh;
        private MaskedTextBox maskedTextBox_alarml;
        private Label label_alarml;
        private Label label_instrumentpanel;
        private Label label_readwrite;
        private Label label_chooseinstrument;
        private Panel panel5;
        private TextBox textBox_BE_currentTCP;
        private Label label_BE_currentTCP;
        private Label label1;
        private Panel panel_TabsConnections;
        private TextBox textBox_currentbitrate;
        private Label label_currentbitrate;
        private TextBox textBox1_currentBEcom;
        private Label label_currentCOM;
        private TextBox textBox_currentCOM;
        private Label label_BE_currentCOM;
        private MaskedTextBox maskedTextBox_devicename;
        private MaskedTextBox maskedTextBox_writePassword;
        private Label label_writePassword;
        private MaskedTextBox maskedTextBox_readwriteFeedback;
        private Panel panel_dataVis;
        private ScottPlot.FormsPlot formsPlot1;
        private Button button_dataChart;
        private System.Windows.Forms.Timer timer_readData;
        private Label label_AverageReading;
        private Label label_LowestReading;
        private MaskedTextBox maskedTextBox_LowestReading;
        private Label label_HighestReading;
        private MaskedTextBox maskedTextBox_HighestReading;
        private Button button_StopReadscaled;
        private Label label_currentReading;
        private MaskedTextBox maskedTextBox_currentReading;
        private Button button_selectInstrument;
    }
}