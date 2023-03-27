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
            components = new System.ComponentModel.Container();
            panel_TopBar = new Panel();
            button_Minimize = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            button_Maximize = new Button();
            button_ExitProgram = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            TopLogo = new PictureBox();
            panel4 = new Panel();
            button_dataChart = new Button();
            button_sensorData = new Button();
            button_InoConnection = new Button();
            panel5_Help = new Panel();
            button1 = new Button();
            panel7 = new Panel();
            button_selectInstrument = new Button();
            label_chooseinstrument = new Label();
            comboBox_InstrumentList = new ComboBox();
            panel_SensorData = new Panel();
            richTextBox_options = new RichTextBox();
            richTextBox_comments = new RichTextBox();
            label_instrumentpanel = new Label();
            button_FromRadio = new Button();
            panel2 = new Panel();
            radioButton_Delete = new RadioButton();
            radioButton_SaveChanges = new RadioButton();
            radioButton_RegisterNew = new RadioButton();
            label_Comment = new Label();
            label_Options = new Label();
            comboBox_MeasureType = new ComboBox();
            label_SignalType = new Label();
            label_LRV = new Label();
            label_MeasureType = new Label();
            comboBox_SignalType = new ComboBox();
            maskedTextBox_LRV = new MaskedTextBox();
            dateTimePicker1 = new DateTimePicker();
            label_RegDate = new Label();
            label_URV = new Label();
            checkBox_Registered = new CheckBox();
            maskedTextBox_URV = new MaskedTextBox();
            label_Registered = new Label();
            label_SerialNumber = new Label();
            maskedTextBox_SerialNumber = new MaskedTextBox();
            maskedTextBox_SensorName = new MaskedTextBox();
            label_SensorName = new Label();
            panel_TabsConnections = new Panel();
            label1 = new Label();
            comboBox_COMport = new ComboBox();
            buttonConnect_Ino = new Button();
            label_InoComPort = new Label();
            textBox_InoBitRate = new TextBox();
            textBox_connectionFeedback_Ino = new RichTextBox();
            buttonDisconnect_Ino = new Button();
            label_InoBitRate = new Label();
            panel_dataVis = new Panel();
            label_currentReading = new Label();
            maskedTextBox_currentReading = new MaskedTextBox();
            maskedTextBox_AverageReading = new MaskedTextBox();
            label_AverageReading = new Label();
            label_LowestReading = new Label();
            maskedTextBox_LowestReading = new MaskedTextBox();
            label_HighestReading = new Label();
            maskedTextBox_HighestReading = new MaskedTextBox();
            button_StopReadscaled = new Button();
            formsPlot1 = new ScottPlot.FormsPlot();
            button_readscaled = new Button();
            maskedTextBox_devicename = new MaskedTextBox();
            label_Unit = new Label();
            panel1 = new Panel();
            maskedTextBox_readwriteFeedback = new MaskedTextBox();
            label_writePassword = new Label();
            maskedTextBox_writePassword = new MaskedTextBox();
            button_readstatus = new Button();
            label_readwrite = new Label();
            maskedTextBox_alarmh = new MaskedTextBox();
            button_writeconf = new Button();
            label_alarmh = new Label();
            button_readconf = new Button();
            maskedTextBox_alarml = new MaskedTextBox();
            label_alarml = new Label();
            panel3 = new Panel();
            button_Help = new Button();
            button_File = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            bindingSource1 = new BindingSource(components);
            panel5 = new Panel();
            textBox_currentbitrate = new TextBox();
            label_currentbitrate = new Label();
            textBox1_currentBEcom = new TextBox();
            label_currentCOM = new Label();
            textBox_currentCOM = new TextBox();
            label_BE_currentCOM = new Label();
            textBox_BE_currentTCP = new TextBox();
            label_BE_currentTCP = new Label();
            timer_readData = new System.Windows.Forms.Timer(components);
            panel_TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TopLogo).BeginInit();
            panel4.SuspendLayout();
            panel5_Help.SuspendLayout();
            panel7.SuspendLayout();
            panel_SensorData.SuspendLayout();
            panel2.SuspendLayout();
            panel_TabsConnections.SuspendLayout();
            panel_dataVis.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel_TopBar
            // 
            panel_TopBar.BackColor = Color.FromArgb(38, 38, 38);
            panel_TopBar.Controls.Add(button_Minimize);
            panel_TopBar.Controls.Add(flowLayoutPanel3);
            panel_TopBar.Controls.Add(button_Maximize);
            panel_TopBar.Controls.Add(button_ExitProgram);
            panel_TopBar.Controls.Add(flowLayoutPanel2);
            panel_TopBar.Controls.Add(tableLayoutPanel1);
            panel_TopBar.Controls.Add(flowLayoutPanel1);
            panel_TopBar.Controls.Add(TopLogo);
            panel_TopBar.Location = new Point(0, 0);
            panel_TopBar.Margin = new Padding(0);
            panel_TopBar.Name = "panel_TopBar";
            panel_TopBar.Size = new Size(1040, 32);
            panel_TopBar.TabIndex = 13;
            panel_TopBar.MouseDown += appWindow_MouseDown;
            panel_TopBar.MouseMove += appWindow_MouseMove;
            // 
            // button_Minimize
            // 
            button_Minimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Minimize.BackgroundImageLayout = ImageLayout.None;
            button_Minimize.FlatAppearance.BorderSize = 0;
            button_Minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_Minimize.FlatStyle = FlatStyle.Flat;
            button_Minimize.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Minimize.ForeColor = Color.FromArgb(214, 214, 214);
            button_Minimize.Location = new Point(944, 0);
            button_Minimize.Margin = new Padding(0);
            button_Minimize.Name = "button_Minimize";
            button_Minimize.Size = new Size(32, 32);
            button_Minimize.TabIndex = 41;
            button_Minimize.Text = "—";
            button_Minimize.UseVisualStyleBackColor = true;
            button_Minimize.Click += button_Minimize_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel3.Location = new Point(150, 32);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(1047, 27);
            flowLayoutPanel3.TabIndex = 15;
            // 
            // button_Maximize
            // 
            button_Maximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button_Maximize.BackgroundImageLayout = ImageLayout.None;
            button_Maximize.FlatAppearance.BorderSize = 0;
            button_Maximize.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_Maximize.FlatStyle = FlatStyle.Flat;
            button_Maximize.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_Maximize.ForeColor = Color.FromArgb(214, 214, 214);
            button_Maximize.Location = new Point(976, 0);
            button_Maximize.Margin = new Padding(0);
            button_Maximize.Name = "button_Maximize";
            button_Maximize.Size = new Size(32, 32);
            button_Maximize.TabIndex = 40;
            button_Maximize.Text = "◻";
            button_Maximize.UseVisualStyleBackColor = true;
            button_Maximize.Click += button_Maximize_Click;
            // 
            // button_ExitProgram
            // 
            button_ExitProgram.Anchor = AnchorStyles.None;
            button_ExitProgram.BackgroundImageLayout = ImageLayout.None;
            button_ExitProgram.FlatAppearance.BorderSize = 0;
            button_ExitProgram.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_ExitProgram.FlatStyle = FlatStyle.Flat;
            button_ExitProgram.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_ExitProgram.ForeColor = Color.FromArgb(214, 214, 214);
            button_ExitProgram.Location = new Point(1008, 0);
            button_ExitProgram.Margin = new Padding(0);
            button_ExitProgram.Name = "button_ExitProgram";
            button_ExitProgram.Size = new Size(32, 32);
            button_ExitProgram.TabIndex = 39;
            button_ExitProgram.Text = "X";
            button_ExitProgram.UseVisualStyleBackColor = true;
            button_ExitProgram.Click += button_ExitProgram_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Location = new Point(144, 32);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(739, 613);
            flowLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(21, 35);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(128, 40);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // TopLogo
            // 
            TopLogo.BackgroundImageLayout = ImageLayout.None;
            TopLogo.Image = Properties.Resources.app_icon;
            TopLogo.Location = new Point(472, 0);
            TopLogo.Name = "TopLogo";
            TopLogo.Size = new Size(32, 32);
            TopLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            TopLogo.TabIndex = 17;
            TopLogo.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(38, 38, 38);
            panel4.Controls.Add(button_dataChart);
            panel4.Controls.Add(button_sensorData);
            panel4.Controls.Add(button_InoConnection);
            panel4.Location = new Point(0, 64);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1040, 40);
            panel4.TabIndex = 14;
            // 
            // button_dataChart
            // 
            button_dataChart.FlatAppearance.BorderSize = 0;
            button_dataChart.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button_dataChart.FlatStyle = FlatStyle.Flat;
            button_dataChart.ForeColor = Color.FromArgb(214, 214, 214);
            button_dataChart.Location = new Point(176, 0);
            button_dataChart.Name = "button_dataChart";
            button_dataChart.Size = new Size(89, 40);
            button_dataChart.TabIndex = 39;
            button_dataChart.Text = "Data chart";
            button_dataChart.UseVisualStyleBackColor = true;
            button_dataChart.Click += button_dataChart_Click;
            // 
            // button_sensorData
            // 
            button_sensorData.FlatAppearance.BorderSize = 0;
            button_sensorData.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button_sensorData.FlatStyle = FlatStyle.Flat;
            button_sensorData.ForeColor = Color.FromArgb(214, 214, 214);
            button_sensorData.Location = new Point(0, 0);
            button_sensorData.Name = "button_sensorData";
            button_sensorData.Size = new Size(89, 40);
            button_sensorData.TabIndex = 38;
            button_sensorData.Text = "Config";
            button_sensorData.UseVisualStyleBackColor = true;
            button_sensorData.Click += button_sensorData_Click;
            // 
            // button_InoConnection
            // 
            button_InoConnection.FlatAppearance.BorderSize = 0;
            button_InoConnection.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button_InoConnection.FlatStyle = FlatStyle.Flat;
            button_InoConnection.ForeColor = Color.FromArgb(214, 214, 214);
            button_InoConnection.Location = new Point(88, 0);
            button_InoConnection.Name = "button_InoConnection";
            button_InoConnection.Size = new Size(89, 40);
            button_InoConnection.TabIndex = 37;
            button_InoConnection.Text = "Connections";
            button_InoConnection.UseVisualStyleBackColor = true;
            button_InoConnection.Click += button_InoConnection_Click;
            // 
            // panel5_Help
            // 
            panel5_Help.Controls.Add(button1);
            panel5_Help.Location = new Point(40, 32);
            panel5_Help.Name = "panel5_Help";
            panel5_Help.Size = new Size(200, 100);
            panel5_Help.TabIndex = 44;
            panel5_Help.Visible = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(33, 33, 33);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(38, 38, 38);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(button_selectInstrument);
            panel7.Controls.Add(label_chooseinstrument);
            panel7.Controls.Add(comboBox_InstrumentList);
            panel7.Location = new Point(656, 120);
            panel7.Margin = new Padding(0);
            panel7.Name = "panel7";
            panel7.Size = new Size(368, 120);
            panel7.TabIndex = 34;
            // 
            // button_selectInstrument
            // 
            button_selectInstrument.BackColor = Color.FromArgb(38, 38, 38);
            button_selectInstrument.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button_selectInstrument.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_selectInstrument.FlatStyle = FlatStyle.Flat;
            button_selectInstrument.ForeColor = Color.FromArgb(214, 214, 214);
            button_selectInstrument.Location = new Point(128, 88);
            button_selectInstrument.Name = "button_selectInstrument";
            button_selectInstrument.Size = new Size(120, 23);
            button_selectInstrument.TabIndex = 39;
            button_selectInstrument.Text = "Select";
            button_selectInstrument.UseVisualStyleBackColor = false;
            button_selectInstrument.Click += button_selectInstrument_Click;
            // 
            // label_chooseinstrument
            // 
            label_chooseinstrument.Anchor = AnchorStyles.None;
            label_chooseinstrument.AutoSize = true;
            label_chooseinstrument.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_chooseinstrument.ForeColor = Color.FromArgb(214, 214, 214);
            label_chooseinstrument.Location = new Point(40, 12);
            label_chooseinstrument.Name = "label_chooseinstrument";
            label_chooseinstrument.Size = new Size(295, 28);
            label_chooseinstrument.TabIndex = 36;
            label_chooseinstrument.Text = "Select from saved Instruments:";
            // 
            // comboBox_InstrumentList
            // 
            comboBox_InstrumentList.BackColor = Color.FromArgb(56, 56, 56);
            comboBox_InstrumentList.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_InstrumentList.ForeColor = Color.WhiteSmoke;
            comboBox_InstrumentList.FormattingEnabled = true;
            comboBox_InstrumentList.Location = new Point(47, 47);
            comboBox_InstrumentList.Name = "comboBox_InstrumentList";
            comboBox_InstrumentList.Size = new Size(280, 23);
            comboBox_InstrumentList.TabIndex = 34;
            comboBox_InstrumentList.SelectedIndexChanged += comboBox_InstrumentList_SelectedIndexChanged;
            // 
            // panel_SensorData
            // 
            panel_SensorData.BackColor = Color.FromArgb(38, 38, 38);
            panel_SensorData.Controls.Add(richTextBox_options);
            panel_SensorData.Controls.Add(richTextBox_comments);
            panel_SensorData.Controls.Add(label_instrumentpanel);
            panel_SensorData.Controls.Add(button_FromRadio);
            panel_SensorData.Controls.Add(panel2);
            panel_SensorData.Controls.Add(label_Comment);
            panel_SensorData.Controls.Add(label_Options);
            panel_SensorData.Controls.Add(comboBox_MeasureType);
            panel_SensorData.Controls.Add(label_SignalType);
            panel_SensorData.Controls.Add(label_LRV);
            panel_SensorData.Controls.Add(label_MeasureType);
            panel_SensorData.Controls.Add(comboBox_SignalType);
            panel_SensorData.Controls.Add(maskedTextBox_LRV);
            panel_SensorData.Controls.Add(dateTimePicker1);
            panel_SensorData.Controls.Add(label_RegDate);
            panel_SensorData.Controls.Add(label_URV);
            panel_SensorData.Controls.Add(checkBox_Registered);
            panel_SensorData.Controls.Add(maskedTextBox_URV);
            panel_SensorData.Controls.Add(label_Registered);
            panel_SensorData.Controls.Add(label_SerialNumber);
            panel_SensorData.Controls.Add(maskedTextBox_SerialNumber);
            panel_SensorData.Controls.Add(maskedTextBox_SensorName);
            panel_SensorData.Controls.Add(label_SensorName);
            panel_SensorData.Location = new Point(16, 120);
            panel_SensorData.Margin = new Padding(0);
            panel_SensorData.Name = "panel_SensorData";
            panel_SensorData.Size = new Size(624, 392);
            panel_SensorData.TabIndex = 15;
            // 
            // richTextBox_options
            // 
            richTextBox_options.BackColor = Color.FromArgb(56, 56, 56);
            richTextBox_options.BorderStyle = BorderStyle.FixedSingle;
            richTextBox_options.ForeColor = Color.WhiteSmoke;
            richTextBox_options.Location = new Point(120, 240);
            richTextBox_options.Name = "richTextBox_options";
            richTextBox_options.Size = new Size(280, 56);
            richTextBox_options.TabIndex = 37;
            richTextBox_options.Text = "";
            // 
            // richTextBox_comments
            // 
            richTextBox_comments.BackColor = Color.FromArgb(56, 56, 56);
            richTextBox_comments.BorderStyle = BorderStyle.FixedSingle;
            richTextBox_comments.ForeColor = Color.WhiteSmoke;
            richTextBox_comments.Location = new Point(120, 304);
            richTextBox_comments.Name = "richTextBox_comments";
            richTextBox_comments.Size = new Size(280, 56);
            richTextBox_comments.TabIndex = 36;
            richTextBox_comments.Text = "";
            // 
            // label_instrumentpanel
            // 
            label_instrumentpanel.Anchor = AnchorStyles.None;
            label_instrumentpanel.AutoSize = true;
            label_instrumentpanel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_instrumentpanel.ForeColor = Color.FromArgb(214, 214, 214);
            label_instrumentpanel.Location = new Point(192, 8);
            label_instrumentpanel.Name = "label_instrumentpanel";
            label_instrumentpanel.Size = new Size(245, 28);
            label_instrumentpanel.TabIndex = 34;
            label_instrumentpanel.Text = "Instrument Management:";
            // 
            // button_FromRadio
            // 
            button_FromRadio.BackgroundImageLayout = ImageLayout.None;
            button_FromRadio.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button_FromRadio.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_FromRadio.FlatStyle = FlatStyle.Flat;
            button_FromRadio.ForeColor = Color.FromArgb(214, 214, 214);
            button_FromRadio.Location = new Point(416, 328);
            button_FromRadio.Name = "button_FromRadio";
            button_FromRadio.Size = new Size(195, 32);
            button_FromRadio.TabIndex = 31;
            button_FromRadio.Text = "Register New";
            button_FromRadio.UseVisualStyleBackColor = true;
            button_FromRadio.Click += button_FromRadio_Click;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(radioButton_Delete);
            panel2.Controls.Add(radioButton_SaveChanges);
            panel2.Controls.Add(radioButton_RegisterNew);
            panel2.Location = new Point(416, 200);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 112);
            panel2.TabIndex = 30;
            // 
            // radioButton_Delete
            // 
            radioButton_Delete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_Delete.AutoSize = true;
            radioButton_Delete.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_Delete.ForeColor = Color.FromArgb(214, 214, 214);
            radioButton_Delete.Location = new Point(48, 80);
            radioButton_Delete.Name = "radioButton_Delete";
            radioButton_Delete.Size = new Size(66, 23);
            radioButton_Delete.TabIndex = 33;
            radioButton_Delete.TabStop = true;
            radioButton_Delete.Text = "Delete";
            radioButton_Delete.UseVisualStyleBackColor = true;
            radioButton_Delete.CheckedChanged += radioButton_Delete_CheckedChanged;
            // 
            // radioButton_SaveChanges
            // 
            radioButton_SaveChanges.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_SaveChanges.AutoSize = true;
            radioButton_SaveChanges.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_SaveChanges.ForeColor = Color.FromArgb(214, 214, 214);
            radioButton_SaveChanges.Location = new Point(48, 48);
            radioButton_SaveChanges.Name = "radioButton_SaveChanges";
            radioButton_SaveChanges.Size = new Size(112, 23);
            radioButton_SaveChanges.TabIndex = 32;
            radioButton_SaveChanges.TabStop = true;
            radioButton_SaveChanges.Text = "Save Changes";
            radioButton_SaveChanges.UseVisualStyleBackColor = true;
            radioButton_SaveChanges.CheckedChanged += radioButton_SaveChanges_CheckedChanged;
            // 
            // radioButton_RegisterNew
            // 
            radioButton_RegisterNew.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            radioButton_RegisterNew.AutoSize = true;
            radioButton_RegisterNew.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            radioButton_RegisterNew.ForeColor = Color.FromArgb(214, 214, 214);
            radioButton_RegisterNew.Location = new Point(48, 16);
            radioButton_RegisterNew.Name = "radioButton_RegisterNew";
            radioButton_RegisterNew.Size = new Size(107, 23);
            radioButton_RegisterNew.TabIndex = 31;
            radioButton_RegisterNew.TabStop = true;
            radioButton_RegisterNew.Text = "Register New";
            radioButton_RegisterNew.UseVisualStyleBackColor = true;
            radioButton_RegisterNew.CheckedChanged += radioButton_RegisterNew_CheckedChanged;
            // 
            // label_Comment
            // 
            label_Comment.AutoSize = true;
            label_Comment.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_Comment.ForeColor = Color.FromArgb(214, 214, 214);
            label_Comment.Location = new Point(16, 304);
            label_Comment.Name = "label_Comment";
            label_Comment.Size = new Size(73, 19);
            label_Comment.TabIndex = 23;
            label_Comment.Text = "Comment:";
            // 
            // label_Options
            // 
            label_Options.AutoSize = true;
            label_Options.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_Options.ForeColor = Color.FromArgb(214, 214, 214);
            label_Options.Location = new Point(16, 240);
            label_Options.Name = "label_Options";
            label_Options.Size = new Size(61, 19);
            label_Options.TabIndex = 21;
            label_Options.Text = "Options:";
            // 
            // comboBox_MeasureType
            // 
            comboBox_MeasureType.BackColor = Color.FromArgb(56, 56, 56);
            comboBox_MeasureType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_MeasureType.ForeColor = Color.WhiteSmoke;
            comboBox_MeasureType.FormattingEnabled = true;
            comboBox_MeasureType.Items.AddRange(new object[] { "Analog ", "Digital ", "Fieldbus" });
            comboBox_MeasureType.Location = new Point(120, 200);
            comboBox_MeasureType.Name = "comboBox_MeasureType";
            comboBox_MeasureType.Size = new Size(280, 23);
            comboBox_MeasureType.TabIndex = 20;
            // 
            // label_SignalType
            // 
            label_SignalType.AutoSize = true;
            label_SignalType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_SignalType.ForeColor = Color.FromArgb(214, 214, 214);
            label_SignalType.Location = new Point(16, 176);
            label_SignalType.Name = "label_SignalType";
            label_SignalType.Size = new Size(80, 19);
            label_SignalType.TabIndex = 19;
            label_SignalType.Text = "Signal Type:";
            // 
            // label_LRV
            // 
            label_LRV.AutoSize = true;
            label_LRV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_LRV.ForeColor = Color.FromArgb(214, 214, 214);
            label_LRV.Location = new Point(417, 57);
            label_LRV.Name = "label_LRV";
            label_LRV.Size = new Size(36, 19);
            label_LRV.TabIndex = 25;
            label_LRV.Text = "LRV:";
            // 
            // label_MeasureType
            // 
            label_MeasureType.AutoSize = true;
            label_MeasureType.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_MeasureType.ForeColor = Color.FromArgb(214, 214, 214);
            label_MeasureType.Location = new Point(16, 208);
            label_MeasureType.Name = "label_MeasureType";
            label_MeasureType.Size = new Size(97, 19);
            label_MeasureType.TabIndex = 18;
            label_MeasureType.Text = "Measure Type:";
            // 
            // comboBox_SignalType
            // 
            comboBox_SignalType.BackColor = Color.FromArgb(56, 56, 56);
            comboBox_SignalType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_SignalType.ForeColor = Color.WhiteSmoke;
            comboBox_SignalType.FormattingEnabled = true;
            comboBox_SignalType.Items.AddRange(new object[] { "Analog", "Digital", "Fieldbus" });
            comboBox_SignalType.Location = new Point(120, 176);
            comboBox_SignalType.Name = "comboBox_SignalType";
            comboBox_SignalType.Size = new Size(280, 23);
            comboBox_SignalType.TabIndex = 17;
            comboBox_SignalType.SelectedIndexChanged += comboBox_SignalType_SelectedIndexChanged;
            // 
            // maskedTextBox_LRV
            // 
            maskedTextBox_LRV.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_LRV.ForeColor = Color.WhiteSmoke;
            maskedTextBox_LRV.HidePromptOnLeave = true;
            maskedTextBox_LRV.Location = new Point(456, 56);
            maskedTextBox_LRV.Name = "maskedTextBox_LRV";
            maskedTextBox_LRV.Size = new Size(88, 23);
            maskedTextBox_LRV.TabIndex = 25;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.WhiteSmoke;
            dateTimePicker1.CalendarMonthBackground = Color.FromArgb(56, 56, 56);
            dateTimePicker1.CalendarTitleBackColor = Color.FromArgb(56, 56, 56);
            dateTimePicker1.CalendarTitleForeColor = Color.WhiteSmoke;
            dateTimePicker1.CalendarTrailingForeColor = Color.WhiteSmoke;
            dateTimePicker1.Location = new Point(120, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 16;
            // 
            // label_RegDate
            // 
            label_RegDate.AutoSize = true;
            label_RegDate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_RegDate.ForeColor = Color.FromArgb(214, 214, 214);
            label_RegDate.Location = new Point(16, 144);
            label_RegDate.Name = "label_RegDate";
            label_RegDate.Size = new Size(71, 19);
            label_RegDate.TabIndex = 14;
            label_RegDate.Text = "Reg. Date:";
            // 
            // label_URV
            // 
            label_URV.AutoSize = true;
            label_URV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_URV.ForeColor = Color.FromArgb(214, 214, 214);
            label_URV.Location = new Point(417, 89);
            label_URV.Name = "label_URV";
            label_URV.Size = new Size(39, 19);
            label_URV.TabIndex = 27;
            label_URV.Text = "URV:";
            // 
            // checkBox_Registered
            // 
            checkBox_Registered.AutoSize = true;
            checkBox_Registered.Location = new Point(120, 120);
            checkBox_Registered.Name = "checkBox_Registered";
            checkBox_Registered.Size = new Size(15, 14);
            checkBox_Registered.TabIndex = 13;
            checkBox_Registered.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox_URV
            // 
            maskedTextBox_URV.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_URV.ForeColor = Color.WhiteSmoke;
            maskedTextBox_URV.Location = new Point(456, 88);
            maskedTextBox_URV.Name = "maskedTextBox_URV";
            maskedTextBox_URV.Size = new Size(88, 23);
            maskedTextBox_URV.TabIndex = 26;
            maskedTextBox_URV.MaskInputRejected += maskedTextBox_URV_MaskInputRejected;
            // 
            // label_Registered
            // 
            label_Registered.AutoSize = true;
            label_Registered.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_Registered.ForeColor = Color.FromArgb(214, 214, 214);
            label_Registered.Location = new Point(16, 120);
            label_Registered.Name = "label_Registered";
            label_Registered.Size = new Size(76, 19);
            label_Registered.TabIndex = 12;
            label_Registered.Text = "Registered:";
            // 
            // label_SerialNumber
            // 
            label_SerialNumber.AutoSize = true;
            label_SerialNumber.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_SerialNumber.ForeColor = Color.FromArgb(214, 214, 214);
            label_SerialNumber.Location = new Point(16, 88);
            label_SerialNumber.Name = "label_SerialNumber";
            label_SerialNumber.Size = new Size(98, 19);
            label_SerialNumber.TabIndex = 11;
            label_SerialNumber.Text = "Serial Number:";
            // 
            // maskedTextBox_SerialNumber
            // 
            maskedTextBox_SerialNumber.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_SerialNumber.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox_SerialNumber.ForeColor = Color.WhiteSmoke;
            maskedTextBox_SerialNumber.Location = new Point(120, 88);
            maskedTextBox_SerialNumber.Name = "maskedTextBox_SerialNumber";
            maskedTextBox_SerialNumber.Size = new Size(280, 23);
            maskedTextBox_SerialNumber.TabIndex = 10;
            // 
            // maskedTextBox_SensorName
            // 
            maskedTextBox_SensorName.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_SensorName.BorderStyle = BorderStyle.FixedSingle;
            maskedTextBox_SensorName.ForeColor = Color.WhiteSmoke;
            maskedTextBox_SensorName.Location = new Point(120, 56);
            maskedTextBox_SensorName.Name = "maskedTextBox_SensorName";
            maskedTextBox_SensorName.Size = new Size(280, 23);
            maskedTextBox_SensorName.TabIndex = 9;
            // 
            // label_SensorName
            // 
            label_SensorName.AutoSize = true;
            label_SensorName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_SensorName.ForeColor = Color.FromArgb(214, 214, 214);
            label_SensorName.Location = new Point(16, 56);
            label_SensorName.Name = "label_SensorName";
            label_SensorName.Size = new Size(93, 19);
            label_SensorName.TabIndex = 0;
            label_SensorName.Text = "Sensor Name:";
            // 
            // panel_TabsConnections
            // 
            panel_TabsConnections.BackColor = Color.FromArgb(38, 38, 38);
            panel_TabsConnections.BorderStyle = BorderStyle.FixedSingle;
            panel_TabsConnections.Controls.Add(label1);
            panel_TabsConnections.Controls.Add(comboBox_COMport);
            panel_TabsConnections.Controls.Add(buttonConnect_Ino);
            panel_TabsConnections.Controls.Add(label_InoComPort);
            panel_TabsConnections.Controls.Add(textBox_InoBitRate);
            panel_TabsConnections.Controls.Add(textBox_connectionFeedback_Ino);
            panel_TabsConnections.Controls.Add(buttonDisconnect_Ino);
            panel_TabsConnections.Controls.Add(label_InoBitRate);
            panel_TabsConnections.Location = new Point(16, 120);
            panel_TabsConnections.Name = "panel_TabsConnections";
            panel_TabsConnections.Size = new Size(624, 392);
            panel_TabsConnections.TabIndex = 42;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(214, 214, 214);
            label1.Location = new Point(200, 8);
            label1.Name = "label1";
            label1.Size = new Size(223, 28);
            label1.TabIndex = 37;
            label1.Text = "Connect to instrument:";
            // 
            // comboBox_COMport
            // 
            comboBox_COMport.BackColor = Color.FromArgb(56, 56, 56);
            comboBox_COMport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_COMport.ForeColor = Color.WhiteSmoke;
            comboBox_COMport.FormattingEnabled = true;
            comboBox_COMport.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            comboBox_COMport.Location = new Point(232, 44);
            comboBox_COMport.Name = "comboBox_COMport";
            comboBox_COMport.Size = new Size(104, 23);
            comboBox_COMport.TabIndex = 7;
            comboBox_COMport.TextChanged += comboBox_COMport_TextChanged;
            // 
            // buttonConnect_Ino
            // 
            buttonConnect_Ino.BackColor = Color.FromArgb(31, 31, 31);
            buttonConnect_Ino.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            buttonConnect_Ino.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            buttonConnect_Ino.FlatStyle = FlatStyle.Flat;
            buttonConnect_Ino.ForeColor = Color.FromArgb(214, 214, 214);
            buttonConnect_Ino.Location = new Point(168, 72);
            buttonConnect_Ino.Name = "buttonConnect_Ino";
            buttonConnect_Ino.Size = new Size(88, 32);
            buttonConnect_Ino.TabIndex = 4;
            buttonConnect_Ino.Text = "Connect";
            buttonConnect_Ino.UseVisualStyleBackColor = false;
            buttonConnect_Ino.Click += buttonConnect_Ino_Click;
            // 
            // label_InoComPort
            // 
            label_InoComPort.AutoSize = true;
            label_InoComPort.ForeColor = Color.FromArgb(214, 214, 214);
            label_InoComPort.Location = new Point(168, 48);
            label_InoComPort.Name = "label_InoComPort";
            label_InoComPort.Size = new Size(61, 15);
            label_InoComPort.TabIndex = 0;
            label_InoComPort.Text = "Com Port:";
            // 
            // textBox_InoBitRate
            // 
            textBox_InoBitRate.BackColor = Color.FromArgb(56, 56, 56);
            textBox_InoBitRate.BorderStyle = BorderStyle.None;
            textBox_InoBitRate.ForeColor = Color.WhiteSmoke;
            textBox_InoBitRate.Location = new Point(400, 48);
            textBox_InoBitRate.Name = "textBox_InoBitRate";
            textBox_InoBitRate.Size = new Size(50, 16);
            textBox_InoBitRate.TabIndex = 2;
            textBox_InoBitRate.TextChanged += textBox_InoBitRate_TextChanged;
            // 
            // textBox_connectionFeedback_Ino
            // 
            textBox_connectionFeedback_Ino.BackColor = Color.FromArgb(56, 56, 56);
            textBox_connectionFeedback_Ino.BorderStyle = BorderStyle.None;
            textBox_connectionFeedback_Ino.ForeColor = Color.WhiteSmoke;
            textBox_connectionFeedback_Ino.Location = new Point(168, 112);
            textBox_connectionFeedback_Ino.Name = "textBox_connectionFeedback_Ino";
            textBox_connectionFeedback_Ino.ReadOnly = true;
            textBox_connectionFeedback_Ino.Size = new Size(280, 96);
            textBox_connectionFeedback_Ino.TabIndex = 6;
            textBox_connectionFeedback_Ino.Text = "";
            // 
            // buttonDisconnect_Ino
            // 
            buttonDisconnect_Ino.BackColor = Color.FromArgb(31, 31, 31);
            buttonDisconnect_Ino.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            buttonDisconnect_Ino.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            buttonDisconnect_Ino.FlatStyle = FlatStyle.Flat;
            buttonDisconnect_Ino.ForeColor = Color.FromArgb(214, 214, 214);
            buttonDisconnect_Ino.Location = new Point(264, 72);
            buttonDisconnect_Ino.Name = "buttonDisconnect_Ino";
            buttonDisconnect_Ino.Size = new Size(88, 32);
            buttonDisconnect_Ino.TabIndex = 5;
            buttonDisconnect_Ino.Text = "Disconnect";
            buttonDisconnect_Ino.UseVisualStyleBackColor = false;
            buttonDisconnect_Ino.Click += buttonDisconnect_Ino_Click;
            // 
            // label_InoBitRate
            // 
            label_InoBitRate.AutoSize = true;
            label_InoBitRate.ForeColor = Color.FromArgb(214, 214, 214);
            label_InoBitRate.Location = new Point(352, 48);
            label_InoBitRate.Name = "label_InoBitRate";
            label_InoBitRate.Size = new Size(44, 15);
            label_InoBitRate.TabIndex = 3;
            label_InoBitRate.Text = "Bitrate:";
            label_InoBitRate.Click += label_InoBitRate_Click;
            // 
            // panel_dataVis
            // 
            panel_dataVis.Controls.Add(label_currentReading);
            panel_dataVis.Controls.Add(maskedTextBox_currentReading);
            panel_dataVis.Controls.Add(maskedTextBox_AverageReading);
            panel_dataVis.Controls.Add(label_AverageReading);
            panel_dataVis.Controls.Add(label_LowestReading);
            panel_dataVis.Controls.Add(maskedTextBox_LowestReading);
            panel_dataVis.Controls.Add(label_HighestReading);
            panel_dataVis.Controls.Add(maskedTextBox_HighestReading);
            panel_dataVis.Controls.Add(button_StopReadscaled);
            panel_dataVis.Controls.Add(formsPlot1);
            panel_dataVis.Controls.Add(button_readscaled);
            panel_dataVis.Location = new Point(16, 120);
            panel_dataVis.Name = "panel_dataVis";
            panel_dataVis.Size = new Size(624, 392);
            panel_dataVis.TabIndex = 38;
            // 
            // label_currentReading
            // 
            label_currentReading.AutoSize = true;
            label_currentReading.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_currentReading.ForeColor = Color.FromArgb(214, 214, 214);
            label_currentReading.Location = new Point(272, 320);
            label_currentReading.Name = "label_currentReading";
            label_currentReading.Size = new Size(109, 19);
            label_currentReading.TabIndex = 44;
            label_currentReading.Text = "Current reading:";
            // 
            // maskedTextBox_currentReading
            // 
            maskedTextBox_currentReading.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_currentReading.ForeColor = Color.WhiteSmoke;
            maskedTextBox_currentReading.Location = new Point(384, 320);
            maskedTextBox_currentReading.Name = "maskedTextBox_currentReading";
            maskedTextBox_currentReading.Size = new Size(96, 23);
            maskedTextBox_currentReading.TabIndex = 45;
            // 
            // maskedTextBox_AverageReading
            // 
            maskedTextBox_AverageReading.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_AverageReading.ForeColor = Color.WhiteSmoke;
            maskedTextBox_AverageReading.Location = new Point(128, 368);
            maskedTextBox_AverageReading.Name = "maskedTextBox_AverageReading";
            maskedTextBox_AverageReading.Size = new Size(96, 23);
            maskedTextBox_AverageReading.TabIndex = 43;
            // 
            // label_AverageReading
            // 
            label_AverageReading.AutoSize = true;
            label_AverageReading.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_AverageReading.ForeColor = Color.FromArgb(214, 214, 214);
            label_AverageReading.Location = new Point(16, 368);
            label_AverageReading.Name = "label_AverageReading";
            label_AverageReading.Size = new Size(112, 19);
            label_AverageReading.TabIndex = 42;
            label_AverageReading.Text = "Average reading:";
            // 
            // label_LowestReading
            // 
            label_LowestReading.AutoSize = true;
            label_LowestReading.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_LowestReading.ForeColor = Color.FromArgb(214, 214, 214);
            label_LowestReading.Location = new Point(16, 344);
            label_LowestReading.Name = "label_LowestReading";
            label_LowestReading.Size = new Size(105, 19);
            label_LowestReading.TabIndex = 40;
            label_LowestReading.Text = "Lowest reading:";
            // 
            // maskedTextBox_LowestReading
            // 
            maskedTextBox_LowestReading.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_LowestReading.ForeColor = Color.WhiteSmoke;
            maskedTextBox_LowestReading.Location = new Point(128, 344);
            maskedTextBox_LowestReading.Name = "maskedTextBox_LowestReading";
            maskedTextBox_LowestReading.Size = new Size(96, 23);
            maskedTextBox_LowestReading.TabIndex = 41;
            // 
            // label_HighestReading
            // 
            label_HighestReading.AutoSize = true;
            label_HighestReading.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_HighestReading.ForeColor = Color.FromArgb(214, 214, 214);
            label_HighestReading.Location = new Point(16, 320);
            label_HighestReading.Name = "label_HighestReading";
            label_HighestReading.Size = new Size(109, 19);
            label_HighestReading.TabIndex = 39;
            label_HighestReading.Text = "Highest reading:";
            // 
            // maskedTextBox_HighestReading
            // 
            maskedTextBox_HighestReading.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_HighestReading.ForeColor = Color.WhiteSmoke;
            maskedTextBox_HighestReading.Location = new Point(128, 320);
            maskedTextBox_HighestReading.Name = "maskedTextBox_HighestReading";
            maskedTextBox_HighestReading.Size = new Size(96, 23);
            maskedTextBox_HighestReading.TabIndex = 39;
            // 
            // button_StopReadscaled
            // 
            button_StopReadscaled.BackColor = Color.FromArgb(38, 38, 38);
            button_StopReadscaled.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button_StopReadscaled.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_StopReadscaled.FlatStyle = FlatStyle.Flat;
            button_StopReadscaled.ForeColor = Color.FromArgb(214, 214, 214);
            button_StopReadscaled.Location = new Point(488, 56);
            button_StopReadscaled.Name = "button_StopReadscaled";
            button_StopReadscaled.Size = new Size(128, 40);
            button_StopReadscaled.TabIndex = 8;
            button_StopReadscaled.Text = "Stop reading sensor";
            button_StopReadscaled.UseVisualStyleBackColor = false;
            button_StopReadscaled.Click += button_StopReadscaled_Click;
            // 
            // formsPlot1
            // 
            formsPlot1.BackColor = Color.FromArgb(64, 64, 64);
            formsPlot1.BorderStyle = BorderStyle.FixedSingle;
            formsPlot1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            formsPlot1.ForeColor = SystemColors.ControlText;
            formsPlot1.Location = new Point(13, 15);
            formsPlot1.Margin = new Padding(6, 6, 6, 6);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(467, 297);
            formsPlot1.TabIndex = 0;
            // 
            // button_readscaled
            // 
            button_readscaled.BackColor = Color.FromArgb(38, 38, 38);
            button_readscaled.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button_readscaled.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_readscaled.FlatStyle = FlatStyle.Flat;
            button_readscaled.ForeColor = Color.FromArgb(214, 214, 214);
            button_readscaled.Location = new Point(488, 16);
            button_readscaled.Name = "button_readscaled";
            button_readscaled.Size = new Size(128, 40);
            button_readscaled.TabIndex = 7;
            button_readscaled.Text = "Start reading sensor";
            button_readscaled.UseVisualStyleBackColor = false;
            button_readscaled.Click += button_readscaled_Click;
            // 
            // maskedTextBox_devicename
            // 
            maskedTextBox_devicename.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_devicename.ForeColor = Color.WhiteSmoke;
            maskedTextBox_devicename.Location = new Point(240, 56);
            maskedTextBox_devicename.Name = "maskedTextBox_devicename";
            maskedTextBox_devicename.Size = new Size(88, 23);
            maskedTextBox_devicename.TabIndex = 28;
            maskedTextBox_devicename.MaskInputRejected += maskedTextBox3_MaskInputRejected;
            // 
            // label_Unit
            // 
            label_Unit.AutoSize = true;
            label_Unit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_Unit.ForeColor = Color.FromArgb(214, 214, 214);
            label_Unit.Location = new Point(184, 56);
            label_Unit.Name = "label_Unit";
            label_Unit.Size = new Size(48, 19);
            label_Unit.TabIndex = 29;
            label_Unit.Text = "Name:";
            label_Unit.Click += label_Unit_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(38, 38, 38);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(maskedTextBox_readwriteFeedback);
            panel1.Controls.Add(label_writePassword);
            panel1.Controls.Add(maskedTextBox_writePassword);
            panel1.Controls.Add(button_readstatus);
            panel1.Controls.Add(label_readwrite);
            panel1.Controls.Add(maskedTextBox_alarmh);
            panel1.Controls.Add(button_writeconf);
            panel1.Controls.Add(label_alarmh);
            panel1.Controls.Add(button_readconf);
            panel1.Controls.Add(maskedTextBox_alarml);
            panel1.Controls.Add(label_alarml);
            panel1.Controls.Add(maskedTextBox_devicename);
            panel1.Controls.Add(label_Unit);
            panel1.Location = new Point(656, 256);
            panel1.Name = "panel1";
            panel1.Size = new Size(368, 256);
            panel1.TabIndex = 40;
            // 
            // maskedTextBox_readwriteFeedback
            // 
            maskedTextBox_readwriteFeedback.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_readwriteFeedback.ForeColor = Color.WhiteSmoke;
            maskedTextBox_readwriteFeedback.Location = new Point(8, 224);
            maskedTextBox_readwriteFeedback.Name = "maskedTextBox_readwriteFeedback";
            maskedTextBox_readwriteFeedback.Size = new Size(352, 23);
            maskedTextBox_readwriteFeedback.TabIndex = 38;
            // 
            // label_writePassword
            // 
            label_writePassword.AutoSize = true;
            label_writePassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_writePassword.ForeColor = Color.FromArgb(214, 214, 214);
            label_writePassword.Location = new Point(144, 160);
            label_writePassword.Name = "label_writePassword";
            label_writePassword.Size = new Size(70, 19);
            label_writePassword.TabIndex = 37;
            label_writePassword.Text = "Password:";
            // 
            // maskedTextBox_writePassword
            // 
            maskedTextBox_writePassword.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_writePassword.ForeColor = Color.WhiteSmoke;
            maskedTextBox_writePassword.Location = new Point(128, 184);
            maskedTextBox_writePassword.Name = "maskedTextBox_writePassword";
            maskedTextBox_writePassword.PasswordChar = '*';
            maskedTextBox_writePassword.Size = new Size(96, 23);
            maskedTextBox_writePassword.TabIndex = 36;
            maskedTextBox_writePassword.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            maskedTextBox_writePassword.TextChanged += maskedTextBox_writePassword_TextChanged;
            // 
            // button_readstatus
            // 
            button_readstatus.BackColor = Color.FromArgb(38, 38, 38);
            button_readstatus.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button_readstatus.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_readstatus.FlatStyle = FlatStyle.Flat;
            button_readstatus.ForeColor = Color.FromArgb(214, 214, 214);
            button_readstatus.Location = new Point(56, 120);
            button_readstatus.Name = "button_readstatus";
            button_readstatus.Size = new Size(120, 23);
            button_readstatus.TabIndex = 8;
            button_readstatus.Text = "Get status";
            button_readstatus.UseVisualStyleBackColor = false;
            button_readstatus.Click += button_readstatus_Click;
            // 
            // label_readwrite
            // 
            label_readwrite.Anchor = AnchorStyles.None;
            label_readwrite.AutoSize = true;
            label_readwrite.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label_readwrite.ForeColor = Color.FromArgb(214, 214, 214);
            label_readwrite.Location = new Point(72, 12);
            label_readwrite.Name = "label_readwrite";
            label_readwrite.Size = new Size(244, 28);
            label_readwrite.TabIndex = 35;
            label_readwrite.Text = "Read/Write to instrument";
            label_readwrite.Click += label_readwrite_Click;
            // 
            // maskedTextBox_alarmh
            // 
            maskedTextBox_alarmh.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_alarmh.ForeColor = Color.WhiteSmoke;
            maskedTextBox_alarmh.Location = new Point(240, 120);
            maskedTextBox_alarmh.Name = "maskedTextBox_alarmh";
            maskedTextBox_alarmh.Size = new Size(88, 23);
            maskedTextBox_alarmh.TabIndex = 32;
            // 
            // button_writeconf
            // 
            button_writeconf.BackColor = Color.FromArgb(38, 38, 38);
            button_writeconf.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button_writeconf.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_writeconf.FlatStyle = FlatStyle.Flat;
            button_writeconf.ForeColor = Color.FromArgb(214, 214, 214);
            button_writeconf.Location = new Point(56, 88);
            button_writeconf.Name = "button_writeconf";
            button_writeconf.Size = new Size(120, 23);
            button_writeconf.TabIndex = 6;
            button_writeconf.Text = "Write config";
            button_writeconf.UseVisualStyleBackColor = false;
            button_writeconf.Click += button_writeconf_Click;
            button_writeconf.MouseHover += button_writeconf_MouseHover;
            // 
            // label_alarmh
            // 
            label_alarmh.AutoSize = true;
            label_alarmh.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_alarmh.ForeColor = Color.FromArgb(214, 214, 214);
            label_alarmh.Location = new Point(184, 120);
            label_alarmh.Name = "label_alarmh";
            label_alarmh.Size = new Size(56, 19);
            label_alarmh.TabIndex = 33;
            label_alarmh.Text = "Alarmh:";
            // 
            // button_readconf
            // 
            button_readconf.BackColor = Color.FromArgb(38, 38, 38);
            button_readconf.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button_readconf.FlatAppearance.MouseOverBackColor = Color.FromArgb(56, 56, 56);
            button_readconf.FlatStyle = FlatStyle.Flat;
            button_readconf.ForeColor = Color.FromArgb(214, 214, 214);
            button_readconf.Location = new Point(56, 56);
            button_readconf.Name = "button_readconf";
            button_readconf.Size = new Size(120, 23);
            button_readconf.TabIndex = 5;
            button_readconf.Text = "Read config";
            button_readconf.UseVisualStyleBackColor = false;
            button_readconf.Click += button_readconf_Click;
            // 
            // maskedTextBox_alarml
            // 
            maskedTextBox_alarml.BackColor = Color.FromArgb(56, 56, 56);
            maskedTextBox_alarml.ForeColor = Color.WhiteSmoke;
            maskedTextBox_alarml.Location = new Point(240, 88);
            maskedTextBox_alarml.Name = "maskedTextBox_alarml";
            maskedTextBox_alarml.Size = new Size(88, 23);
            maskedTextBox_alarml.TabIndex = 30;
            // 
            // label_alarml
            // 
            label_alarml.AutoSize = true;
            label_alarml.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_alarml.ForeColor = Color.FromArgb(214, 214, 214);
            label_alarml.Location = new Point(184, 88);
            label_alarml.Name = "label_alarml";
            label_alarml.Size = new Size(51, 19);
            label_alarml.TabIndex = 31;
            label_alarml.Text = "Alarml:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(33, 33, 33);
            panel3.Controls.Add(panel5_Help);
            panel3.Controls.Add(button_Help);
            panel3.Controls.Add(button_File);
            panel3.Location = new Point(0, 32);
            panel3.Name = "panel3";
            panel3.Size = new Size(1040, 32);
            panel3.TabIndex = 43;
            // 
            // button_Help
            // 
            button_Help.FlatAppearance.BorderSize = 0;
            button_Help.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button_Help.FlatStyle = FlatStyle.Flat;
            button_Help.ForeColor = Color.FromArgb(214, 214, 214);
            button_Help.Location = new Point(40, 0);
            button_Help.Name = "button_Help";
            button_Help.Size = new Size(40, 32);
            button_Help.TabIndex = 40;
            button_Help.Text = "Help";
            button_Help.UseVisualStyleBackColor = true;
            button_Help.Click += button1_Click;
            // 
            // button_File
            // 
            button_File.FlatAppearance.BorderSize = 0;
            button_File.FlatAppearance.MouseDownBackColor = Color.FromArgb(56, 56, 56);
            button_File.FlatStyle = FlatStyle.Flat;
            button_File.ForeColor = Color.FromArgb(214, 214, 214);
            button_File.Location = new Point(0, 0);
            button_File.Name = "button_File";
            button_File.Size = new Size(40, 32);
            button_File.TabIndex = 39;
            button_File.Text = "File";
            button_File.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(33, 33, 33);
            panel5.Controls.Add(textBox_currentbitrate);
            panel5.Controls.Add(label_currentbitrate);
            panel5.Controls.Add(textBox1_currentBEcom);
            panel5.Controls.Add(label_currentCOM);
            panel5.Controls.Add(textBox_currentCOM);
            panel5.Controls.Add(label_BE_currentCOM);
            panel5.Controls.Add(textBox_BE_currentTCP);
            panel5.Controls.Add(label_BE_currentTCP);
            panel5.Location = new Point(0, 544);
            panel5.Name = "panel5";
            panel5.Size = new Size(1040, 32);
            panel5.TabIndex = 45;
            // 
            // textBox_currentbitrate
            // 
            textBox_currentbitrate.BackColor = Color.FromArgb(56, 56, 56);
            textBox_currentbitrate.BorderStyle = BorderStyle.None;
            textBox_currentbitrate.ForeColor = Color.WhiteSmoke;
            textBox_currentbitrate.Location = new Point(960, 8);
            textBox_currentbitrate.Name = "textBox_currentbitrate";
            textBox_currentbitrate.Size = new Size(50, 16);
            textBox_currentbitrate.TabIndex = 50;
            // 
            // label_currentbitrate
            // 
            label_currentbitrate.AutoSize = true;
            label_currentbitrate.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_currentbitrate.ForeColor = Color.FromArgb(214, 214, 214);
            label_currentbitrate.Location = new Point(904, 8);
            label_currentbitrate.Name = "label_currentbitrate";
            label_currentbitrate.Size = new Size(52, 19);
            label_currentbitrate.TabIndex = 49;
            label_currentbitrate.Text = "Bitrate:";
            // 
            // textBox1_currentBEcom
            // 
            textBox1_currentBEcom.BackColor = Color.FromArgb(56, 56, 56);
            textBox1_currentBEcom.BorderStyle = BorderStyle.None;
            textBox1_currentBEcom.ForeColor = Color.WhiteSmoke;
            textBox1_currentBEcom.Location = new Point(840, 8);
            textBox1_currentBEcom.Name = "textBox1_currentBEcom";
            textBox1_currentBEcom.Size = new Size(50, 16);
            textBox1_currentBEcom.TabIndex = 48;
            // 
            // label_currentCOM
            // 
            label_currentCOM.AutoSize = true;
            label_currentCOM.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_currentCOM.ForeColor = Color.FromArgb(214, 214, 214);
            label_currentCOM.Location = new Point(792, 8);
            label_currentCOM.Name = "label_currentCOM";
            label_currentCOM.Size = new Size(45, 19);
            label_currentCOM.TabIndex = 47;
            label_currentCOM.Text = "COM:";
            // 
            // textBox_currentCOM
            // 
            textBox_currentCOM.BackColor = Color.FromArgb(56, 56, 56);
            textBox_currentCOM.BorderStyle = BorderStyle.None;
            textBox_currentCOM.ForeColor = Color.WhiteSmoke;
            textBox_currentCOM.Location = new Point(728, 8);
            textBox_currentCOM.Name = "textBox_currentCOM";
            textBox_currentCOM.Size = new Size(50, 16);
            textBox_currentCOM.TabIndex = 46;
            // 
            // label_BE_currentCOM
            // 
            label_BE_currentCOM.AutoSize = true;
            label_BE_currentCOM.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_BE_currentCOM.ForeColor = Color.FromArgb(214, 214, 214);
            label_BE_currentCOM.Location = new Point(560, 8);
            label_BE_currentCOM.Name = "label_BE_currentCOM";
            label_BE_currentCOM.Size = new Size(166, 19);
            label_BE_currentCOM.TabIndex = 45;
            label_BE_currentCOM.Text = "Connected to instrument:";
            // 
            // textBox_BE_currentTCP
            // 
            textBox_BE_currentTCP.BackColor = Color.FromArgb(56, 56, 56);
            textBox_BE_currentTCP.BorderStyle = BorderStyle.None;
            textBox_BE_currentTCP.ForeColor = Color.WhiteSmoke;
            textBox_BE_currentTCP.Location = new Point(184, 8);
            textBox_BE_currentTCP.Name = "textBox_BE_currentTCP";
            textBox_BE_currentTCP.Size = new Size(50, 16);
            textBox_BE_currentTCP.TabIndex = 7;
            // 
            // label_BE_currentTCP
            // 
            label_BE_currentTCP.AutoSize = true;
            label_BE_currentTCP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_BE_currentTCP.ForeColor = Color.FromArgb(214, 214, 214);
            label_BE_currentTCP.Location = new Point(0, 8);
            label_BE_currentTCP.Name = "label_BE_currentTCP";
            label_BE_currentTCP.Size = new Size(185, 19);
            label_BE_currentTCP.TabIndex = 44;
            label_BE_currentTCP.Text = "Connected to TCP (backend):";
            // 
            // timer_readData
            // 
            timer_readData.Interval = 5000;
            timer_readData.Tick += timer1_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 31, 31);
            ClientSize = new Size(1040, 579);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel_TopBar);
            Controls.Add(panel7);
            Controls.Add(panel_SensorData);
            Controls.Add(panel_dataVis);
            Controls.Add(panel_TabsConnections);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SensorData";
            Load += app_Load;
            panel_TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TopLogo).EndInit();
            panel4.ResumeLayout(false);
            panel5_Help.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel_SensorData.ResumeLayout(false);
            panel_SensorData.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel_TabsConnections.ResumeLayout(false);
            panel_TabsConnections.PerformLayout();
            panel_dataVis.ResumeLayout(false);
            panel_dataVis.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
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
        private RichTextBox richTextBox_options;
        private RichTextBox richTextBox_comments;
    }
}