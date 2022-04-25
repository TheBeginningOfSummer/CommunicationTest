namespace CommunicationsToolkit
{
    partial class SerialPortSet
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
            this.LB_BaudRate = new System.Windows.Forms.Label();
            this.LB_SerialPort = new System.Windows.Forms.Label();
            this.CB_SerialPort = new System.Windows.Forms.ComboBox();
            this.CB_BaudRate = new System.Windows.Forms.ComboBox();
            this.BTN_Set = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_BaudRate
            // 
            this.LB_BaudRate.AutoSize = true;
            this.LB_BaudRate.Location = new System.Drawing.Point(39, 30);
            this.LB_BaudRate.Name = "LB_BaudRate";
            this.LB_BaudRate.Size = new System.Drawing.Size(56, 17);
            this.LB_BaudRate.TabIndex = 0;
            this.LB_BaudRate.Text = "波特率：";
            // 
            // LB_SerialPort
            // 
            this.LB_SerialPort.AutoSize = true;
            this.LB_SerialPort.Location = new System.Drawing.Point(39, 68);
            this.LB_SerialPort.Name = "LB_SerialPort";
            this.LB_SerialPort.Size = new System.Drawing.Size(56, 17);
            this.LB_SerialPort.TabIndex = 1;
            this.LB_SerialPort.Text = "串口号：";
            // 
            // CB_SerialPort
            // 
            this.CB_SerialPort.FormattingEnabled = true;
            this.CB_SerialPort.Location = new System.Drawing.Point(101, 65);
            this.CB_SerialPort.Name = "CB_SerialPort";
            this.CB_SerialPort.Size = new System.Drawing.Size(121, 25);
            this.CB_SerialPort.TabIndex = 2;
            // 
            // CB_BaudRate
            // 
            this.CB_BaudRate.FormattingEnabled = true;
            this.CB_BaudRate.Location = new System.Drawing.Point(101, 27);
            this.CB_BaudRate.Name = "CB_BaudRate";
            this.CB_BaudRate.Size = new System.Drawing.Size(121, 25);
            this.CB_BaudRate.TabIndex = 3;
            // 
            // BTN_Set
            // 
            this.BTN_Set.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BTN_Set.Location = new System.Drawing.Point(101, 113);
            this.BTN_Set.Name = "BTN_Set";
            this.BTN_Set.Size = new System.Drawing.Size(75, 23);
            this.BTN_Set.TabIndex = 4;
            this.BTN_Set.Text = "确定";
            this.BTN_Set.UseVisualStyleBackColor = true;
            this.BTN_Set.Click += new System.EventHandler(this.BTN_Set_Click);
            // 
            // SerialPortSet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.BTN_Set);
            this.Controls.Add(this.CB_BaudRate);
            this.Controls.Add(this.CB_SerialPort);
            this.Controls.Add(this.LB_SerialPort);
            this.Controls.Add(this.LB_BaudRate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SerialPortSet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "串口参数设置";
            this.Load += new System.EventHandler(this.SerialPortSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LB_BaudRate;
        private Label LB_SerialPort;
        private ComboBox CB_SerialPort;
        private ComboBox CB_BaudRate;
        private Button BTN_Set;
    }
}