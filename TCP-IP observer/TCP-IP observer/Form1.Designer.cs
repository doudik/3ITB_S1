namespace TCP_IP_observer
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
            label_ip = new Label();
            textBox_ip = new TextBox();
            textBox_port = new TextBox();
            label2 = new Label();
            label_port = new Label();
            button_off = new Button();
            button_start = new Button();
            label_logSystem = new Label();
            listBox_listofconnected = new ListBox();
            button_disconnect = new Button();
            label_log = new Label();
            SuspendLayout();
            // 
            // label_ip
            // 
            label_ip.AutoSize = true;
            label_ip.Location = new Point(79, 64);
            label_ip.Name = "label_ip";
            label_ip.Size = new Size(24, 20);
            label_ip.TabIndex = 0;
            label_ip.Text = "IP:";
            // 
            // textBox_ip
            // 
            textBox_ip.Location = new Point(159, 60);
            textBox_ip.Name = "textBox_ip";
            textBox_ip.Size = new Size(271, 27);
            textBox_ip.TabIndex = 1;
            // 
            // textBox_port
            // 
            textBox_port.Location = new Point(159, 93);
            textBox_port.Name = "textBox_port";
            textBox_port.Size = new Size(271, 27);
            textBox_port.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 4;
            // 
            // label_port
            // 
            label_port.AutoSize = true;
            label_port.Location = new Point(79, 96);
            label_port.Name = "label_port";
            label_port.Size = new Size(38, 20);
            label_port.TabIndex = 5;
            label_port.Text = "Port:";
            // 
            // button_off
            // 
            button_off.Location = new Point(79, 376);
            button_off.Name = "button_off";
            button_off.Size = new Size(94, 29);
            button_off.TabIndex = 6;
            button_off.Text = "Stop";
            button_off.UseVisualStyleBackColor = true;
            button_off.Click += button_off_Click;
            // 
            // button_start
            // 
            button_start.Location = new Point(179, 376);
            button_start.Name = "button_start";
            button_start.Size = new Size(110, 29);
            button_start.TabIndex = 7;
            button_start.Text = "Start";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // label_logSystem
            // 
            label_logSystem.AutoSize = true;
            label_logSystem.BackColor = SystemColors.ButtonHighlight;
            label_logSystem.Location = new Point(459, 165);
            label_logSystem.MinimumSize = new Size(300, 250);
            label_logSystem.Name = "label_logSystem";
            label_logSystem.Size = new Size(300, 250);
            label_logSystem.TabIndex = 8;
            // 
            // listBox_listofconnected
            // 
            listBox_listofconnected.FormattingEnabled = true;
            listBox_listofconnected.ItemHeight = 20;
            listBox_listofconnected.Location = new Point(79, 135);
            listBox_listofconnected.Name = "listBox_listofconnected";
            listBox_listofconnected.Size = new Size(351, 224);
            listBox_listofconnected.TabIndex = 9;
            // 
            // button_disconnect
            // 
            button_disconnect.Location = new Point(295, 376);
            button_disconnect.Name = "button_disconnect";
            button_disconnect.Size = new Size(135, 29);
            button_disconnect.TabIndex = 10;
            button_disconnect.Text = "Odpojit uživatele";
            button_disconnect.UseVisualStyleBackColor = true;
            button_disconnect.Click += button_disconnect_Click;
            // 
            // label_log
            // 
            label_log.AutoSize = true;
            label_log.Location = new Point(459, 135);
            label_log.Name = "label_log";
            label_log.Size = new Size(118, 20);
            label_log.TabIndex = 11;
            label_log.Text = "Logovací systém";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_log);
            Controls.Add(button_disconnect);
            Controls.Add(listBox_listofconnected);
            Controls.Add(label_logSystem);
            Controls.Add(button_start);
            Controls.Add(button_off);
            Controls.Add(label_port);
            Controls.Add(textBox_port);
            Controls.Add(label2);
            Controls.Add(textBox_ip);
            Controls.Add(label_ip);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_ip;
        private TextBox textBox_ip;
        private TextBox textBox_port;
        private Label label2;
        private Label label_port;
        private Button button_off;
        private Button button_start;
        private Label label_logSystem;
        private ListBox listBox_listofconnected;
        private Button button_disconnect;
        private Label label_log;
    }
}