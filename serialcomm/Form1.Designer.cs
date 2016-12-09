namespace serialcomm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDataContinuoslyReceived = new System.Windows.Forms.TextBox();
            this.btnOpenClosePort = new System.Windows.Forms.Button();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.tbDataReceived = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbChosenSerial = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatusPortu = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slSlider1 = new System.Windows.Forms.TrackBar();
            this.btnSendSliderValue = new System.Windows.Forms.Button();
            this.tbSliderValue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slSlider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "wybrany port:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSendSliderValue);
            this.groupBox1.Controls.Add(this.tbSliderValue);
            this.groupBox1.Controls.Add(this.slSlider1);
            this.groupBox1.Controls.Add(this.tbDataContinuoslyReceived);
            this.groupBox1.Controls.Add(this.btnOpenClosePort);
            this.groupBox1.Controls.Add(this.cbBaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReceive);
            this.groupBox1.Controls.Add(this.tbDataReceived);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cbChosenSerial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 265);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tbDataContinuoslyReceived
            // 
            this.tbDataContinuoslyReceived.Location = new System.Drawing.Point(6, 78);
            this.tbDataContinuoslyReceived.Name = "tbDataContinuoslyReceived";
            this.tbDataContinuoslyReceived.Size = new System.Drawing.Size(259, 20);
            this.tbDataContinuoslyReceived.TabIndex = 8;
            // 
            // btnOpenClosePort
            // 
            this.btnOpenClosePort.Location = new System.Drawing.Point(182, 11);
            this.btnOpenClosePort.Name = "btnOpenClosePort";
            this.btnOpenClosePort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenClosePort.TabIndex = 7;
            this.btnOpenClosePort.Text = "Open port";
            this.btnOpenClosePort.UseVisualStyleBackColor = true;
            this.btnOpenClosePort.Click += new System.EventHandler(this.btnOpenClosePort_Click);
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "128000",
            "153600",
            "230400",
            "256000",
            "460800",
            "921600"});
            this.cbBaudrate.Location = new System.Drawing.Point(82, 40);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(94, 21);
            this.cbBaudrate.TabIndex = 6;
            this.cbBaudrate.Text = "9600";
            this.cbBaudrate.SelectedIndexChanged += new System.EventHandler(this.cbBaudrate_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Baud rate:";
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(271, 103);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(75, 23);
            this.btnReceive.TabIndex = 3;
            this.btnReceive.Text = "Receive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // tbDataReceived
            // 
            this.tbDataReceived.Location = new System.Drawing.Point(6, 105);
            this.tbDataReceived.Name = "tbDataReceived";
            this.tbDataReceived.Size = new System.Drawing.Size(259, 20);
            this.tbDataReceived.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(271, 132);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 2;
            // 
            // cbChosenSerial
            // 
            this.cbChosenSerial.FormattingEnabled = true;
            this.cbChosenSerial.Location = new System.Drawing.Point(82, 13);
            this.cbChosenSerial.Name = "cbChosenSerial";
            this.cbChosenSerial.Size = new System.Drawing.Size(94, 21);
            this.cbChosenSerial.TabIndex = 1;
            this.cbChosenSerial.SelectedIndexChanged += new System.EventHandler(this.cbChosenSerial_SelectedIndexChanged);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbStatusPortu,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 280);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(376, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusLabel1.Text = "Stan portu:";
            // 
            // lbStatusPortu
            // 
            this.lbStatusPortu.Name = "lbStatusPortu";
            this.lbStatusPortu.Size = new System.Drawing.Size(41, 17);
            this.lbStatusPortu.Text = "closed";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 17);
            // 
            // slSlider1
            // 
            this.slSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.slSlider1.Location = new System.Drawing.Point(6, 186);
            this.slSlider1.Maximum = 1023;
            this.slSlider1.Name = "slSlider1";
            this.slSlider1.Size = new System.Drawing.Size(340, 45);
            this.slSlider1.TabIndex = 9;
            this.slSlider1.TickFrequency = 64;
            this.slSlider1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.slSlider1.Value = 512;
            this.slSlider1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnSendSliderValue
            // 
            this.btnSendSliderValue.Location = new System.Drawing.Point(271, 236);
            this.btnSendSliderValue.Name = "btnSendSliderValue";
            this.btnSendSliderValue.Size = new System.Drawing.Size(75, 23);
            this.btnSendSliderValue.TabIndex = 10;
            this.btnSendSliderValue.Text = "Send";
            this.btnSendSliderValue.UseVisualStyleBackColor = true;
            this.btnSendSliderValue.Click += new System.EventHandler(this.btnSendSliderValue_Click);
            // 
            // tbSliderValue
            // 
            this.tbSliderValue.Location = new System.Drawing.Point(6, 237);
            this.tbSliderValue.Name = "tbSliderValue";
            this.tbSliderValue.Size = new System.Drawing.Size(259, 20);
            this.tbSliderValue.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 302);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SerialComm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slSlider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox tbDataReceived;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cbChosenSerial;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenClosePort;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatusPortu;
        private System.Windows.Forms.TextBox tbDataContinuoslyReceived;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button btnSendSliderValue;
        private System.Windows.Forms.TextBox tbSliderValue;
        private System.Windows.Forms.TrackBar slSlider1;
    }
}

