namespace Client
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
            label_server = new Label();
            textBox1 = new TextBox();
            button_connect = new Button();
            button_disconnect = new Button();
            label_msgs = new Label();
            richTextBox_msg = new RichTextBox();
            textBox_nickname = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label_server
            // 
            label_server.AutoSize = true;
            label_server.Location = new Point(23, 374);
            label_server.Name = "label_server";
            label_server.Size = new Size(50, 20);
            label_server.TabIndex = 0;
            label_server.Text = "IP:Port";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 367);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 27);
            textBox1.TabIndex = 1;
            // 
            // button_connect
            // 
            button_connect.Location = new Point(63, 400);
            button_connect.Name = "button_connect";
            button_connect.Size = new Size(128, 29);
            button_connect.TabIndex = 2;
            button_connect.Text = "Připojit";
            button_connect.UseVisualStyleBackColor = true;
            button_connect.Click += button_connect_Click;
            // 
            // button_disconnect
            // 
            button_disconnect.Location = new Point(197, 400);
            button_disconnect.Name = "button_disconnect";
            button_disconnect.Size = new Size(128, 29);
            button_disconnect.TabIndex = 3;
            button_disconnect.Text = "Odpojit";
            button_disconnect.UseVisualStyleBackColor = true;
            button_disconnect.Click += button_disconnect_Click;
            // 
            // label_msgs
            // 
            label_msgs.AutoSize = true;
            label_msgs.BackColor = SystemColors.ButtonHighlight;
            label_msgs.BorderStyle = BorderStyle.Fixed3D;
            label_msgs.Location = new Point(335, 9);
            label_msgs.MaximumSize = new Size(350, 350);
            label_msgs.MinimumSize = new Size(350, 350);
            label_msgs.Name = "label_msgs";
            label_msgs.Size = new Size(350, 350);
            label_msgs.TabIndex = 4;
            // 
            // richTextBox_msg
            // 
            richTextBox_msg.Location = new Point(335, 372);
            richTextBox_msg.Name = "richTextBox_msg";
            richTextBox_msg.Size = new Size(350, 66);
            richTextBox_msg.TabIndex = 5;
            richTextBox_msg.Text = "";
            // 
            // textBox_nickname
            // 
            textBox_nickname.Location = new Point(109, 334);
            textBox_nickname.Name = "textBox_nickname";
            textBox_nickname.Size = new Size(216, 27);
            textBox_nickname.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 339);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 6;
            label1.Text = "Nickname:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 450);
            Controls.Add(textBox_nickname);
            Controls.Add(label1);
            Controls.Add(richTextBox_msg);
            Controls.Add(label_msgs);
            Controls.Add(button_disconnect);
            Controls.Add(button_connect);
            Controls.Add(textBox1);
            Controls.Add(label_server);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_server;
        private TextBox textBox1;
        private Button button_connect;
        private Button button_disconnect;
        private Label label_msgs;
        private RichTextBox richTextBox_msg;
        private TextBox textBox_nickname;
        private Label label1;
    }
}