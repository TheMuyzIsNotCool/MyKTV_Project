namespace MyKTV_Client
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lbPlaying = new System.Windows.Forms.Label();
            this.lbNextPlay = new System.Windows.Forms.Label();
            this.lbPlay = new System.Windows.Forms.Label();
            this.lbNext = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbExit = new System.Windows.Forms.PictureBox();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbService = new System.Windows.Forms.PictureBox();
            this.pbSelected = new System.Windows.Forms.PictureBox();
            this.pbReSay = new System.Windows.Forms.PictureBox();
            this.pbTop = new System.Windows.Forms.PictureBox();
            this.pbMany = new System.Windows.Forms.PictureBox();
            this.pbSinger = new System.Windows.Forms.PictureBox();
            this.pbType = new System.Windows.Forms.PictureBox();
            this.pbAB = new System.Windows.Forms.PictureBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReSay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPlaying
            // 
            this.lbPlaying.AutoSize = true;
            this.lbPlaying.Font = new System.Drawing.Font("幼圆", 30F);
            this.lbPlaying.Location = new System.Drawing.Point(12, 29);
            this.lbPlaying.Name = "lbPlaying";
            this.lbPlaying.Size = new System.Drawing.Size(137, 40);
            this.lbPlaying.TabIndex = 6;
            this.lbPlaying.Text = "正播放";
            // 
            // lbNextPlay
            // 
            this.lbNextPlay.AutoSize = true;
            this.lbNextPlay.Font = new System.Drawing.Font("幼圆", 30F);
            this.lbNextPlay.Location = new System.Drawing.Point(12, 108);
            this.lbNextPlay.Name = "lbNextPlay";
            this.lbNextPlay.Size = new System.Drawing.Size(137, 40);
            this.lbNextPlay.TabIndex = 7;
            this.lbNextPlay.Text = "下一首";
            // 
            // lbPlay
            // 
            this.lbPlay.AutoSize = true;
            this.lbPlay.Font = new System.Drawing.Font("幼圆", 20F);
            this.lbPlay.Location = new System.Drawing.Point(155, 40);
            this.lbPlay.Name = "lbPlay";
            this.lbPlay.Size = new System.Drawing.Size(0, 27);
            this.lbPlay.TabIndex = 8;
            // 
            // lbNext
            // 
            this.lbNext.AutoSize = true;
            this.lbNext.Font = new System.Drawing.Font("幼圆", 20F);
            this.lbNext.Location = new System.Drawing.Point(155, 121);
            this.lbNext.Name = "lbNext";
            this.lbNext.Size = new System.Drawing.Size(0, 27);
            this.lbNext.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbExit
            // 
            this.pbExit.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn10;
            this.pbExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbExit.Location = new System.Drawing.Point(783, 534);
            this.pbExit.Name = "pbExit";
            this.pbExit.Size = new System.Drawing.Size(73, 73);
            this.pbExit.TabIndex = 12;
            this.pbExit.TabStop = false;
            this.pbExit.Click += new System.EventHandler(this.pbExit_Click);
            // 
            // pbNext
            // 
            this.pbNext.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn7;
            this.pbNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbNext.Location = new System.Drawing.Point(483, 534);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(73, 73);
            this.pbNext.TabIndex = 12;
            this.pbNext.TabStop = false;
            this.pbNext.Click += new System.EventHandler(this.pbNext_Click);
            // 
            // pbService
            // 
            this.pbService.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn9;
            this.pbService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbService.Location = new System.Drawing.Point(679, 533);
            this.pbService.Name = "pbService";
            this.pbService.Size = new System.Drawing.Size(73, 73);
            this.pbService.TabIndex = 12;
            this.pbService.TabStop = false;
            // 
            // pbSelected
            // 
            this.pbSelected.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn8;
            this.pbSelected.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSelected.Location = new System.Drawing.Point(581, 533);
            this.pbSelected.Name = "pbSelected";
            this.pbSelected.Size = new System.Drawing.Size(73, 73);
            this.pbSelected.TabIndex = 11;
            this.pbSelected.TabStop = false;
            this.pbSelected.Click += new System.EventHandler(this.pbSelected_Click);
            // 
            // pbReSay
            // 
            this.pbReSay.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn6;
            this.pbReSay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbReSay.Location = new System.Drawing.Point(382, 534);
            this.pbReSay.Name = "pbReSay";
            this.pbReSay.Size = new System.Drawing.Size(73, 73);
            this.pbReSay.TabIndex = 10;
            this.pbReSay.TabStop = false;
            this.pbReSay.Click += new System.EventHandler(this.pbReSay_Click);
            // 
            // pbTop
            // 
            this.pbTop.BackColor = System.Drawing.Color.Transparent;
            this.pbTop.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn4;
            this.pbTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbTop.Location = new System.Drawing.Point(374, 324);
            this.pbTop.Name = "pbTop";
            this.pbTop.Size = new System.Drawing.Size(116, 110);
            this.pbTop.TabIndex = 5;
            this.pbTop.TabStop = false;
            this.pbTop.Click += new System.EventHandler(this.pbTop_Click);
            // 
            // pbMany
            // 
            this.pbMany.BackColor = System.Drawing.Color.Transparent;
            this.pbMany.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn5;
            this.pbMany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMany.Location = new System.Drawing.Point(535, 324);
            this.pbMany.Name = "pbMany";
            this.pbMany.Size = new System.Drawing.Size(116, 110);
            this.pbMany.TabIndex = 4;
            this.pbMany.TabStop = false;
            this.pbMany.Click += new System.EventHandler(this.pbMany_Click);
            // 
            // pbSinger
            // 
            this.pbSinger.BackColor = System.Drawing.Color.Transparent;
            this.pbSinger.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn1;
            this.pbSinger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSinger.Location = new System.Drawing.Point(374, 172);
            this.pbSinger.Name = "pbSinger";
            this.pbSinger.Size = new System.Drawing.Size(116, 110);
            this.pbSinger.TabIndex = 3;
            this.pbSinger.TabStop = false;
            this.pbSinger.Click += new System.EventHandler(this.pbSinger_Click);
            // 
            // pbType
            // 
            this.pbType.BackColor = System.Drawing.Color.Transparent;
            this.pbType.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn3;
            this.pbType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbType.Location = new System.Drawing.Point(696, 172);
            this.pbType.Name = "pbType";
            this.pbType.Size = new System.Drawing.Size(116, 110);
            this.pbType.TabIndex = 2;
            this.pbType.TabStop = false;
            this.pbType.Click += new System.EventHandler(this.pbType_Click);
            // 
            // pbAB
            // 
            this.pbAB.BackColor = System.Drawing.Color.Transparent;
            this.pbAB.BackgroundImage = global::MyKTV_Client.Properties.Resources.btn2;
            this.pbAB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAB.Location = new System.Drawing.Point(535, 172);
            this.pbAB.Name = "pbAB";
            this.pbAB.Size = new System.Drawing.Size(116, 110);
            this.pbAB.TabIndex = 1;
            this.pbAB.TabStop = false;
            this.pbAB.Click += new System.EventHandler(this.pbAB_Click);
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImage = global::MyKTV_Client.Properties.Resources.undraw_just_saying_552u__1_;
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbImage.Location = new System.Drawing.Point(-26, 394);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(292, 240);
            this.pbImage.TabIndex = 0;
            this.pbImage.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 619);
            this.Controls.Add(this.pbExit);
            this.Controls.Add(this.pbNext);
            this.Controls.Add(this.pbService);
            this.Controls.Add(this.pbSelected);
            this.Controls.Add(this.pbReSay);
            this.Controls.Add(this.lbNext);
            this.Controls.Add(this.lbPlay);
            this.Controls.Add(this.lbNextPlay);
            this.Controls.Add(this.lbPlaying);
            this.Controls.Add(this.pbTop);
            this.Controls.Add(this.pbMany);
            this.Controls.Add(this.pbSinger);
            this.Controls.Add(this.pbType);
            this.Controls.Add(this.pbAB);
            this.Controls.Add(this.pbImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTV主界面";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReSay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSinger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbAB;
        private System.Windows.Forms.PictureBox pbType;
        private System.Windows.Forms.PictureBox pbSinger;
        private System.Windows.Forms.PictureBox pbMany;
        private System.Windows.Forms.PictureBox pbTop;
        private System.Windows.Forms.Label lbPlaying;
        private System.Windows.Forms.Label lbNextPlay;
        private System.Windows.Forms.Label lbPlay;
        private System.Windows.Forms.Label lbNext;
        private System.Windows.Forms.PictureBox pbReSay;
        private System.Windows.Forms.PictureBox pbSelected;
        private System.Windows.Forms.PictureBox pbService;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbExit;
        private System.Windows.Forms.Timer timer1;
    }
}

