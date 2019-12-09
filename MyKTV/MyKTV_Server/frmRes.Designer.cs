namespace MyKTV_Server
{
    partial class frmRes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.lbsong = new System.Windows.Forms.Label();
            this.txtSongpic = new System.Windows.Forms.TextBox();
            this.lbSongpic = new System.Windows.Forms.Label();
            this.txtSingerpic = new System.Windows.Forms.TextBox();
            this.lbSingerPic = new System.Windows.Forms.Label();
            this.btnsongmore = new System.Windows.Forms.Button();
            this.btnSongpicmore = new System.Windows.Forms.Button();
            this.btnSingerpicmore = new System.Windows.Forms.Button();
            this.fbdSingerPic = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdSongPic = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdSong = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtSong);
            this.panel1.Controls.Add(this.lbsong);
            this.panel1.Controls.Add(this.txtSongpic);
            this.panel1.Controls.Add(this.lbSongpic);
            this.panel1.Controls.Add(this.txtSingerpic);
            this.panel1.Controls.Add(this.lbSingerPic);
            this.panel1.Controls.Add(this.btnsongmore);
            this.panel1.Controls.Add(this.btnSongpicmore);
            this.panel1.Controls.Add(this.btnSingerpicmore);
            this.panel1.Location = new System.Drawing.Point(35, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(504, 279);
            this.panel1.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(290, 220);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(146, 220);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSong
            // 
            this.txtSong.Location = new System.Drawing.Point(146, 164);
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(219, 21);
            this.txtSong.TabIndex = 8;
            // 
            // lbsong
            // 
            this.lbsong.AutoSize = true;
            this.lbsong.Location = new System.Drawing.Point(22, 167);
            this.lbsong.Name = "lbsong";
            this.lbsong.Size = new System.Drawing.Size(89, 12);
            this.lbsong.TabIndex = 7;
            this.lbsong.Text = "歌曲资源文件夹";
            // 
            // txtSongpic
            // 
            this.txtSongpic.Location = new System.Drawing.Point(146, 105);
            this.txtSongpic.Name = "txtSongpic";
            this.txtSongpic.Size = new System.Drawing.Size(219, 21);
            this.txtSongpic.TabIndex = 6;
            // 
            // lbSongpic
            // 
            this.lbSongpic.AutoSize = true;
            this.lbSongpic.Location = new System.Drawing.Point(22, 108);
            this.lbSongpic.Name = "lbSongpic";
            this.lbSongpic.Size = new System.Drawing.Size(113, 12);
            this.lbSongpic.TabIndex = 5;
            this.lbSongpic.Text = "歌曲图片资源文件夹";
            // 
            // txtSingerpic
            // 
            this.txtSingerpic.Location = new System.Drawing.Point(146, 51);
            this.txtSingerpic.Name = "txtSingerpic";
            this.txtSingerpic.Size = new System.Drawing.Size(219, 21);
            this.txtSingerpic.TabIndex = 4;
            // 
            // lbSingerPic
            // 
            this.lbSingerPic.AutoSize = true;
            this.lbSingerPic.Location = new System.Drawing.Point(22, 54);
            this.lbSingerPic.Name = "lbSingerPic";
            this.lbSingerPic.Size = new System.Drawing.Size(113, 12);
            this.lbSingerPic.TabIndex = 3;
            this.lbSingerPic.Text = "歌手图片资源文件夹";
            this.lbSingerPic.Click += new System.EventHandler(this.lbSingerPic_Click);
            // 
            // btnsongmore
            // 
            this.btnsongmore.Location = new System.Drawing.Point(388, 162);
            this.btnsongmore.Name = "btnsongmore";
            this.btnsongmore.Size = new System.Drawing.Size(75, 23);
            this.btnsongmore.TabIndex = 2;
            this.btnsongmore.Text = "......";
            this.btnsongmore.UseVisualStyleBackColor = true;
            this.btnsongmore.Click += new System.EventHandler(this.btnsongmore_Click);
            // 
            // btnSongpicmore
            // 
            this.btnSongpicmore.Location = new System.Drawing.Point(388, 103);
            this.btnSongpicmore.Name = "btnSongpicmore";
            this.btnSongpicmore.Size = new System.Drawing.Size(75, 23);
            this.btnSongpicmore.TabIndex = 1;
            this.btnSongpicmore.Text = "......";
            this.btnSongpicmore.UseVisualStyleBackColor = true;
            this.btnSongpicmore.Click += new System.EventHandler(this.btnSongpicmore_Click);
            // 
            // btnSingerpicmore
            // 
            this.btnSingerpicmore.Location = new System.Drawing.Point(388, 49);
            this.btnSingerpicmore.Name = "btnSingerpicmore";
            this.btnSingerpicmore.Size = new System.Drawing.Size(75, 23);
            this.btnSingerpicmore.TabIndex = 0;
            this.btnSingerpicmore.Text = "......";
            this.btnSingerpicmore.UseVisualStyleBackColor = true;
            this.btnSingerpicmore.Click += new System.EventHandler(this.btnSingerpicmore_Click);
            // 
            // frmRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 381);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "资源管理 - KTV管理系统";
            this.Load += new System.EventHandler(this.frmResAdd_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtSingerpic;
        private System.Windows.Forms.Label lbSingerPic;
        private System.Windows.Forms.Button btnsongmore;
        private System.Windows.Forms.Button btnSongpicmore;
        private System.Windows.Forms.Button btnSingerpicmore;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Label lbsong;
        private System.Windows.Forms.TextBox txtSongpic;
        private System.Windows.Forms.Label lbSongpic;
        private System.Windows.Forms.FolderBrowserDialog fbdSingerPic;
        private System.Windows.Forms.FolderBrowserDialog fbdSongPic;
        private System.Windows.Forms.FolderBrowserDialog fbdSong;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
    }
}