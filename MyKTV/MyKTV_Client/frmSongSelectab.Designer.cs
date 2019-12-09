namespace MyKTV_Client
{
    partial class frmSongSelectab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSongSelectab));
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnMore = new System.Windows.Forms.Button();
            this.lvShow = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbService = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbReSay = new System.Windows.Forms.PictureBox();
            this.pbMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReSay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.SuspendLayout();
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
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(32, 44);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(115, 48);
            this.btnOne.TabIndex = 4;
            this.btnOne.Text = "1字数";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(165, 44);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(115, 48);
            this.btnTwo.TabIndex = 5;
            this.btnTwo.Text = "2字数";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnSix
            // 
            this.btnSix.Location = new System.Drawing.Point(165, 185);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(115, 48);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6字数";
            this.btnSix.UseVisualStyleBackColor = true;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(32, 114);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(115, 48);
            this.btnThree.TabIndex = 7;
            this.btnThree.Text = "3字数";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnFour
            // 
            this.btnFour.Location = new System.Drawing.Point(165, 114);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(115, 48);
            this.btnFour.TabIndex = 8;
            this.btnFour.Text = "4字数";
            this.btnFour.UseVisualStyleBackColor = true;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnFive
            // 
            this.btnFive.Location = new System.Drawing.Point(32, 185);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(115, 48);
            this.btnFive.TabIndex = 9;
            this.btnFive.Text = "5字数";
            this.btnFive.UseVisualStyleBackColor = true;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(32, 255);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(248, 48);
            this.btnMore.TabIndex = 10;
            this.btnMore.Text = "更多";
            this.btnMore.UseVisualStyleBackColor = true;
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
            this.lvShow.HoverSelection = true;
            this.lvShow.Location = new System.Drawing.Point(303, 25);
            this.lvShow.Name = "lvShow";
            this.lvShow.Size = new System.Drawing.Size(596, 447);
            this.lvShow.TabIndex = 21;
            this.lvShow.UseCompatibleStateImageBehavior = false;
            this.lvShow.View = System.Windows.Forms.View.Details;
            this.lvShow.SelectedIndexChanged += new System.EventHandler(this.lvShow_SelectedIndexChanged);
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
            this.columnHeader2.Width = 200;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pbService);
            this.panel1.Controls.Add(this.pbNext);
            this.panel1.Controls.Add(this.pbReSay);
            this.panel1.Controls.Add(this.pbMain);
            this.panel1.Location = new System.Drawing.Point(296, 478);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 136);
            this.panel1.TabIndex = 22;
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
            // frmSongSelectab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvShow);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSongSelectab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSongSelectab";
            this.Load += new System.EventHandler(this.frmSongSelectab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReSay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.ListView lvShow;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbService;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbReSay;
        private System.Windows.Forms.PictureBox pbMain;
    }
}