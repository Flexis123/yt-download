namespace download
{
    partial class MainWindow
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
            this.text = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.down_btn_video = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.progress_label = new System.Windows.Forms.Label();
            this.down_btn_audio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(38, 26);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(339, 20);
            this.text.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "URL:";
            // 
            // down_btn_video
            // 
            this.down_btn_video.Location = new System.Drawing.Point(38, 52);
            this.down_btn_video.Name = "down_btn_video";
            this.down_btn_video.Size = new System.Drawing.Size(141, 35);
            this.down_btn_video.TabIndex = 3;
            this.down_btn_video.Text = "download video";
            this.down_btn_video.UseVisualStyleBackColor = true;
            this.down_btn_video.Click += new System.EventHandler(this.down_btn_video_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(116, 93);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(141, 35);
            this.delete_btn.TabIndex = 4;
            this.delete_btn.Text = "delete url";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(3, 225);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(374, 23);
            this.progressBar.TabIndex = 5;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // progress_label
            // 
            this.progress_label.Font = new System.Drawing.Font("Meiryo UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_label.Location = new System.Drawing.Point(374, 225);
            this.progress_label.Name = "progress_label";
            this.progress_label.Size = new System.Drawing.Size(37, 35);
            this.progress_label.TabIndex = 6;
            this.progress_label.Text = "0%";
            this.progress_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.progress_label.Click += new System.EventHandler(this.progress_label_Click);
            // 
            // down_btn_audio
            // 
            this.down_btn_audio.Location = new System.Drawing.Point(223, 52);
            this.down_btn_audio.Name = "down_btn_audio";
            this.down_btn_audio.Size = new System.Drawing.Size(141, 35);
            this.down_btn_audio.TabIndex = 7;
            this.down_btn_audio.Text = "download audio";
            this.down_btn_audio.UseVisualStyleBackColor = true;
            this.down_btn_audio.Click += new System.EventHandler(this.down_btn_audio_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 289);
            this.Controls.Add(this.down_btn_audio);
            this.Controls.Add(this.progress_label);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.down_btn_video);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text);
            this.Name = "MainWindow";
            this.Text = "VideoDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button down_btn_video;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label progress_label;
        private System.Windows.Forms.Button down_btn_audio;
    }
}

