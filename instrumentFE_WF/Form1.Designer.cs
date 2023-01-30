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
            if (disposing && (components != null))
            {
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "DB IP address:";
            // 
            // textBox_DBIPaddress
            // 
            this.textBox_DBIPaddress.Location = new System.Drawing.Point(99, 6);
            this.textBox_DBIPaddress.Name = "textBox_DBIPaddress";
            this.textBox_DBIPaddress.Size = new System.Drawing.Size(100, 23);
            this.textBox_DBIPaddress.TabIndex = 1;
            // 
            // textBox2_TCPport
            // 
            this.textBox2_TCPport.Location = new System.Drawing.Point(266, 6);
            this.textBox2_TCPport.Name = "textBox2_TCPport";
            this.textBox2_TCPport.Size = new System.Drawing.Size(50, 23);
            this.textBox2_TCPport.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(205, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "TCP Port:";
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 36);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(75, 23);
            this.buttonConnect.TabIndex = 4;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Location = new System.Drawing.Point(93, 36);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 23);
            this.buttonDisconnect.TabIndex = 5;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // textBox_connectionFeedback
            // 
            this.textBox_connectionFeedback.Location = new System.Drawing.Point(12, 65);
            this.textBox_connectionFeedback.Name = "textBox_connectionFeedback";
            this.textBox_connectionFeedback.Size = new System.Drawing.Size(349, 96);
            this.textBox_connectionFeedback.TabIndex = 6;
            this.textBox_connectionFeedback.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(385, 185);
            this.Controls.Add(this.textBox_connectionFeedback);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_TCPport);
            this.Controls.Add(this.textBox_DBIPaddress);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textBox_DBIPaddress;
        private TextBox textBox2_TCPport;
        private Label label2;
        private Button buttonConnect;
        private Button buttonDisconnect;
        private RichTextBox textBox_connectionFeedback;
    }
}