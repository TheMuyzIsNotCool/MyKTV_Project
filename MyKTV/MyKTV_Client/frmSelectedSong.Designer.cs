namespace MyKTV_Client
{
    partial class frmSelectedSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSelectedSong));
            this.lbSelected = new System.Windows.Forms.Label();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbService = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            this.pbReSay = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReSay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbSelected
            // 
            this.lbSelected.AutoSize = true;
            this.lbSelected.Font = new System.Drawing.Font("幼圆", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSelected.Location = new System.Drawing.Point(23, 19);
            this.lbSelected.Name = "lbSelected";
            this.lbSelected.Size = new System.Drawing.Size(98, 21);
            this.lbSelected.TabIndex = 2;
            this.lbSelected.Text = "已点歌曲";
            // 
            // pbNext
            // 
            this.pbNext.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn7;
            this.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNext.Location = new System.Drawing.Point(283, 48);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(73, 73);
            this.pbNext.TabIndex = 16;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbService
            // 
            this.pbService.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn9;
            this.pbService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbService.Location = new System.Drawing.Point(479, 47);
            this.pbService.Name = "pbService";
            this.pbService.Size = new System.Drawing.Size(73, 73);
            this.pbService.TabIndex = 17;
            this.pbService.TabStop = false;
            // 
            // pbMain
            // 
            this.pbMain.BackgroundImage = global::MyKTV_Client.Properties.Resources.h_1;
            this.pbMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMain.Location = new System.Drawing.Point(381, 47);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(73, 73);
            this.pbMain.TabIndex = 14;
            this.pbMain.TabStop = false;
            this.pbMain.Click += new System.EventHandler(this.pbMain_Click);
            // 
            // pbReSay
            // 
            this.pbReSay.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn6;
            this.pbReSay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReSay.Location = new System.Drawing.Point(182, 48);
            this.pbReSay.Name = "pbReSay";
            this.pbReSay.Size = new System.Drawing.Size(73, 73);
            this.pbReSay.TabIndex = 13;
            this.pbReSay.TabStop = false;
            this.pbReSay.Click += new System.EventHandler(this.pbReSay_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::MyKTV_Client.Properties.Resources.undraw_just_saying_552u__1_;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(-26, 394);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(292, 240);
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbService);
            this.panel1.Controls.Add(this.pbNext);
            this.panel1.Controls.Add(this.pbReSay);
            this.panel1.Controls.Add(this.pbMain);
            this.panel1.Location = new System.Drawing.Point(296, 483);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 136);
            this.panel1.TabIndex = 19;
            // 
            // lvShow
            // 
            this.lvShow.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvShow.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lvShow.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvShow.Font = new System.Drawing.Font("幼圆", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvShow.FullRowSelect = true;
            this.lvShow.HideSelection = false;
            this.lvShow.HotTracking = true;
            this.lvShow.HoverSelection = true;
            this.lvShow.LabelEdit = true;
            this.lvShow.Location = new System.Drawing.Point(184, 12);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(708, 447);
            this.lvShow.TabIndex = 20;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "歌曲名称";
            this.columnHeader1.Width = 370;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌手";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 300;
            // 
            // frmSelectedSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 619);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.lbSelected);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSelectedSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSelectedSong";
            this.Load += new System.EventHandler(this.frmSelectedSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReSay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label lbSelected;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbService;
        private System.Windows.Forms.PictureBox pbMain;
        private System.Windows.Forms.PictureBox pbReSay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}