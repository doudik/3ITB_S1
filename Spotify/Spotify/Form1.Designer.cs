namespace Spotify
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
            dataGridView_Queue = new DataGridView();
            dataGridView_AllSongs = new DataGridView();
            label_SongName = new Label();
            label_bandName = new Label();
            pictureBox1 = new PictureBox();
            btn_play = new Button();
            btn_previous = new Button();
            btn_next = new Button();
            progressBar_song = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Queue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AllSongs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView_Queue
            // 
            dataGridView_Queue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Queue.Location = new Point(12, 12);
            dataGridView_Queue.Name = "dataGridView_Queue";
            dataGridView_Queue.RowHeadersWidth = 51;
            dataGridView_Queue.RowTemplate.Height = 29;
            dataGridView_Queue.Size = new Size(242, 336);
            dataGridView_Queue.TabIndex = 0;
            // 
            // dataGridView_AllSongs
            // 
            dataGridView_AllSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_AllSongs.Location = new Point(280, 12);
            dataGridView_AllSongs.Name = "dataGridView_AllSongs";
            dataGridView_AllSongs.RowHeadersWidth = 51;
            dataGridView_AllSongs.RowTemplate.Height = 29;
            dataGridView_AllSongs.Size = new Size(508, 214);
            dataGridView_AllSongs.TabIndex = 1;
            // 
            // label_SongName
            // 
            label_SongName.AutoSize = true;
            label_SongName.Location = new Point(127, 381);
            label_SongName.Name = "label_SongName";
            label_SongName.Size = new Size(50, 20);
            label_SongName.TabIndex = 2;
            label_SongName.Text = "label1";
            // 
            // label_bandName
            // 
            label_bandName.AutoSize = true;
            label_bandName.Location = new Point(127, 401);
            label_bandName.Name = "label_bandName";
            label_bandName.Size = new Size(50, 20);
            label_bandName.TabIndex = 3;
            label_bandName.Text = "label2";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 371);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(82, 67);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btn_play
            // 
            btn_play.Location = new Point(466, 372);
            btn_play.Name = "btn_play";
            btn_play.Size = new Size(94, 29);
            btn_play.TabIndex = 5;
            btn_play.Text = "Play";
            btn_play.UseVisualStyleBackColor = true;
            // 
            // btn_previous
            // 
            btn_previous.Location = new Point(350, 372);
            btn_previous.Name = "btn_previous";
            btn_previous.Size = new Size(94, 29);
            btn_previous.TabIndex = 6;
            btn_previous.Text = "Previous";
            btn_previous.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            btn_next.Location = new Point(586, 372);
            btn_next.Name = "btn_next";
            btn_next.Size = new Size(94, 29);
            btn_next.TabIndex = 7;
            btn_next.Text = "Next";
            btn_next.UseVisualStyleBackColor = true;
            // 
            // progressBar_song
            // 
            progressBar_song.Location = new Point(287, 406);
            progressBar_song.Name = "progressBar_song";
            progressBar_song.Size = new Size(458, 29);
            progressBar_song.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar_song);
            Controls.Add(btn_next);
            Controls.Add(btn_previous);
            Controls.Add(btn_play);
            Controls.Add(pictureBox1);
            Controls.Add(label_bandName);
            Controls.Add(label_SongName);
            Controls.Add(dataGridView_AllSongs);
            Controls.Add(dataGridView_Queue);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Queue).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_AllSongs).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_Queue;
        private DataGridView dataGridView_AllSongs;
        private Label label_SongName;
        private Label label_bandName;
        private PictureBox pictureBox1;
        private Button btn_play;
        private Button btn_previous;
        private Button btn_next;
        private ProgressBar progressBar_song;
    }
}