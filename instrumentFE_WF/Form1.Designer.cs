namespace instrumentFE_WF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)){
                components.Dispose();
      }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_DBIPaddress = new System.Windows.Forms.TextBox();
            this.textBox2_TCPport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.textBox_connectionFeedback = new System.Windows.Forms.RichTextBox();
            this.TopLogo = new System.Windows.Forms.PictureBox();
            this.button_MinimizedCon = new System.Windows.Forms.Button();
            this.button_ExitProgramCon = new System.Windows.Forms.Button();
            this.button_MaximizeCon = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TopPanel_cnct = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TopPanel_cnct.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB IP address:";
            // 
            // textBox_DBIPaddress
            // 
            this.textBox_DBIPaddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_DBIPaddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_DBIPaddress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_DBIPaddress.Location = new System.Drawing.Point(96, 8);
            this.textBox_DBIPaddress.Name = "textBox_DBIPaddress";
            this.textBox_DBIPaddress.Size = new System.Drawing.Size(100, 16);
            this.textBox_DBIPaddress.TabIndex = 1;
            this.textBox_DBIPaddress.TextChanged += new System.EventHandler(this.textBox_DBIPaddress_TextChanged);
            // 
            // textBox2_TCPport
            // 
            this.textBox2_TCPport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox2_TCPport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2_TCPport.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox2_TCPport.Location = new System.Drawing.Point(264, 8);
            this.textBox2_TCPport.Name = "textBox2_TCPport";
            this.textBox2_TCPport.Size = new System.Drawing.Size(50, 16);
            this.textBox2_TCPport.TabIndex = 2;
            this.textBox2_TCPport.TextChanged += new System.EventHandler(this.textBox2_TCPport_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(208, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "TCP Port:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonConnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonConnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.buttonConnect.Location = new System.Drawing.Point(16, 8);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(80, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonDisconnect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonDisconnect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.buttonDisconnect.Location = new System.Drawing.Point(104, 8);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(80, 23);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBox_connectionFeedback
            // 
            this.textBox_connectionFeedback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBox_connectionFeedback.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_connectionFeedback.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_connectionFeedback.Location = new System.Drawing.Point(16, 40);
            this.textBox_connectionFeedback.Name = "textBox_connectionFeedback";
            this.textBox_connectionFeedback.ReadOnly = true;
            this.textBox_connectionFeedback.Size = new System.Drawing.Size(288, 96);
            this.textBox_connectionFeedback.TabIndex = 6;
            this.textBox_connectionFeedback.Text = "";
            this.textBox_connectionFeedback.TextChanged += new System.EventHandler(this.textBox_connectionFeedback_TextChanged);
            // 
            // TopLogo
            // 
            this.TopLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TopLogo.Image = global::instrumentFE_WF.Properties.Resources.app_icon;
            this.TopLogo.Location = new System.Drawing.Point(2, 0);
            this.TopLogo.Name = "TopLogo";
            this.TopLogo.Size = new System.Drawing.Size(32, 32);
            this.TopLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TopLogo.TabIndex = 42;
            this.TopLogo.TabStop = false;
            // 
            // button_MinimizedCon
            // 
            this.button_MinimizedCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MinimizedCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_MinimizedCon.FlatAppearance.BorderSize = 0;
            this.button_MinimizedCon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_MinimizedCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MinimizedCon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_MinimizedCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_MinimizedCon.Location = new System.Drawing.Point(240, 0);
            this.button_MinimizedCon.Margin = new System.Windows.Forms.Padding(0);
            this.button_MinimizedCon.Name = "button_MinimizedCon";
            this.button_MinimizedCon.Size = new System.Drawing.Size(32, 32);
            this.button_MinimizedCon.TabIndex = 45;
            this.button_MinimizedCon.Text = "—";
            this.button_MinimizedCon.UseVisualStyleBackColor = true;
            this.button_MinimizedCon.Click += new System.EventHandler(this.button_MinimizedCon_Click);
            // 
            // button_ExitProgramCon
            // 
            this.button_ExitProgramCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ExitProgramCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_ExitProgramCon.FlatAppearance.BorderSize = 0;
            this.button_ExitProgramCon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_ExitProgramCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ExitProgramCon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_ExitProgramCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_ExitProgramCon.Location = new System.Drawing.Point(304, 0);
            this.button_ExitProgramCon.Margin = new System.Windows.Forms.Padding(0);
            this.button_ExitProgramCon.Name = "button_ExitProgramCon";
            this.button_ExitProgramCon.Size = new System.Drawing.Size(32, 32);
            this.button_ExitProgramCon.TabIndex = 43;
            this.button_ExitProgramCon.Text = "X";
            this.button_ExitProgramCon.UseVisualStyleBackColor = true;
            this.button_ExitProgramCon.Click += new System.EventHandler(this.button_ExitProgramCon_Click);
            // 
            // button_MaximizeCon
            // 
            this.button_MaximizeCon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_MaximizeCon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_MaximizeCon.FlatAppearance.BorderSize = 0;
            this.button_MaximizeCon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.button_MaximizeCon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MaximizeCon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_MaximizeCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.button_MaximizeCon.Location = new System.Drawing.Point(272, 0);
            this.button_MaximizeCon.Margin = new System.Windows.Forms.Padding(0);
            this.button_MaximizeCon.Name = "button_MaximizeCon";
            this.button_MaximizeCon.Size = new System.Drawing.Size(32, 32);
            this.button_MaximizeCon.TabIndex = 44;
            this.button_MaximizeCon.Text = "◻";
            this.button_MaximizeCon.UseVisualStyleBackColor = true;
            this.button_MaximizeCon.Click += new System.EventHandler(this.button_MaximizeCon_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel2.Controls.Add(this.textBox_connectionFeedback);
            this.panel2.Controls.Add(this.buttonDisconnect);
            this.panel2.Controls.Add(this.buttonConnect);
            this.panel2.Location = new System.Drawing.Point(8, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(320, 152);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox_DBIPaddress);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.textBox2_TCPport);
            this.panel3.Location = new System.Drawing.Point(8, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(320, 32);
            this.panel3.TabIndex = 9;
            // 
            // TopPanel_cnct
            // 
            this.TopPanel_cnct.Controls.Add(this.TopLogo);
            this.TopPanel_cnct.Controls.Add(this.button_ExitProgramCon);
            this.TopPanel_cnct.Controls.Add(this.button_MaximizeCon);
            this.TopPanel_cnct.Controls.Add(this.button_MinimizedCon);
            this.TopPanel_cnct.Location = new System.Drawing.Point(0, 0);
            this.TopPanel_cnct.Name = "TopPanel_cnct";
            this.TopPanel_cnct.Size = new System.Drawing.Size(336, 32);
            this.TopPanel_cnct.TabIndex = 10;
            this.TopPanel_cnct.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Topcnct_MouseDown);
            this.TopPanel_cnct.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_Topcnct_MouseMove);
            // 
            // Establish_connection_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(338, 243);
            this.Controls.Add(this.TopPanel_cnct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Establish_connection_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.TopPanel_cnct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox textBox_DBIPaddress;
        private TextBox textBox2_TCPport;
        private Label label2;
        private Button buttonConnect;
        private Button buttonDisconnect;
        private RichTextBox textBox_connectionFeedback;
        private PictureBox TopLogo;
        private Button button_MinimizedCon;
        private Button button_ExitProgramCon;
        private Button button_MaximizeCon;
        private Panel panel2;
        private Panel panel3;
        private Panel TopPanel_cnct;
    }
}