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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSendSliderValue = new System.Windows.Forms.Button();
            this.tbSliderValue = new System.Windows.Forms.TextBox();
            this.slSlider1 = new System.Windows.Forms.TrackBar();
            this.tbDataContinuoslyReceived = new System.Windows.Forms.TextBox();
            this.btnOpenClosePort = new System.Windows.Forms.Button();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReceive = new System.Windows.Forms.Button();
            this.tbDataReceived = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbSendingData = new System.Windows.Forms.TextBox();
            this.cbChosenSerial = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbStatusPortu = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slSlider1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenClosePort);
            this.groupBox1.Controls.Add(this.cbBaudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbChosenSerial);
            this.groupBox1.Controls.Add(this.label1);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // btnSendSliderValue
            // 
            resources.ApplyResources(this.btnSendSliderValue, "btnSendSliderValue");
            this.btnSendSliderValue.Name = "btnSendSliderValue";
            this.btnSendSliderValue.UseVisualStyleBackColor = true;
            this.btnSendSliderValue.Click += new System.EventHandler(this.btnSendSliderValue_Click);
            // 
            // tbSliderValue
            // 
            resources.ApplyResources(this.tbSliderValue, "tbSliderValue");
            this.tbSliderValue.Name = "tbSliderValue";
            this.tbSliderValue.TextChanged += new System.EventHandler(this.tbSliderValue_TextChanged);
            // 
            // slSlider1
            // 
            this.slSlider1.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.slSlider1, "slSlider1");
            this.slSlider1.Maximum = 1023;
            this.slSlider1.Name = "slSlider1";
            this.slSlider1.TickFrequency = 64;
            this.slSlider1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.slSlider1.Value = 512;
            this.slSlider1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tbDataContinuoslyReceived
            // 
            resources.ApplyResources(this.tbDataContinuoslyReceived, "tbDataContinuoslyReceived");
            this.tbDataContinuoslyReceived.Name = "tbDataContinuoslyReceived";
            this.tbDataContinuoslyReceived.ReadOnly = true;
            // 
            // btnOpenClosePort
            // 
            resources.ApplyResources(this.btnOpenClosePort, "btnOpenClosePort");
            this.btnOpenClosePort.Name = "btnOpenClosePort";
            this.btnOpenClosePort.UseVisualStyleBackColor = true;
            this.btnOpenClosePort.Click += new System.EventHandler(this.btnOpenClosePort_Click);
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Items.AddRange(new object[] {
            resources.GetString("cbBaudrate.Items"),
            resources.GetString("cbBaudrate.Items1"),
            resources.GetString("cbBaudrate.Items2"),
            resources.GetString("cbBaudrate.Items3"),
            resources.GetString("cbBaudrate.Items4"),
            resources.GetString("cbBaudrate.Items5"),
            resources.GetString("cbBaudrate.Items6"),
            resources.GetString("cbBaudrate.Items7"),
            resources.GetString("cbBaudrate.Items8"),
            resources.GetString("cbBaudrate.Items9"),
            resources.GetString("cbBaudrate.Items10"),
            resources.GetString("cbBaudrate.Items11"),
            resources.GetString("cbBaudrate.Items12"),
            resources.GetString("cbBaudrate.Items13"),
            resources.GetString("cbBaudrate.Items14"),
            resources.GetString("cbBaudrate.Items15"),
            resources.GetString("cbBaudrate.Items16")});
            resources.ApplyResources(this.cbBaudrate, "cbBaudrate");
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.SelectedIndexChanged += new System.EventHandler(this.cbBaudrate_SelectedIndexChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnReceive
            // 
            resources.ApplyResources(this.btnReceive, "btnReceive");
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // tbDataReceived
            // 
            resources.ApplyResources(this.tbDataReceived, "tbDataReceived");
            this.tbDataReceived.Name = "tbDataReceived";
            this.tbDataReceived.ReadOnly = true;
            this.tbDataReceived.TextChanged += new System.EventHandler(this.tbDataReceived_TextChanged);
            // 
            // btnSend
            // 
            resources.ApplyResources(this.btnSend, "btnSend");
            this.btnSend.Name = "btnSend";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbSendingData
            // 
            resources.ApplyResources(this.tbSendingData, "tbSendingData");
            this.tbSendingData.Name = "tbSendingData";
            // 
            // cbChosenSerial
            // 
            this.cbChosenSerial.FormattingEnabled = true;
            resources.ApplyResources(this.cbChosenSerial, "cbChosenSerial");
            this.cbChosenSerial.Name = "cbChosenSerial";
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
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            // 
            // lbStatusPortu
            // 
            this.lbStatusPortu.Name = "lbStatusPortu";
            resources.ApplyResources(this.lbStatusPortu, "lbStatusPortu");
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            resources.ApplyResources(this.toolStripStatusLabel2, "toolStripStatusLabel2");
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            resources.ApplyResources(this.toolStripStatusLabel3, "toolStripStatusLabel3");
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSendSliderValue);
            this.groupBox2.Controls.Add(this.slSlider1);
            this.groupBox2.Controls.Add(this.tbSliderValue);
            this.groupBox2.Controls.Add(this.tbSendingData);
            this.groupBox2.Controls.Add(this.btnSend);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbDataReceived);
            this.groupBox3.Controls.Add(this.tbDataContinuoslyReceived);
            this.groupBox3.Controls.Add(this.btnReceive);
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slSlider1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.TextBox tbDataReceived;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbSendingData;
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

