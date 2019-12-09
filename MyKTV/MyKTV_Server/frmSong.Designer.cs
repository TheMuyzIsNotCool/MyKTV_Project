namespace MyKTV_Server
{
    partial class frmSong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSong));
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.cboSinger = new System.Windows.Forms.ComboBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.txtClick = new System.Windows.Forms.TextBox();
            this.lbClick = new System.Windows.Forms.Label();
            this.lbSinger = new System.Windows.Forms.Label();
            this.lbType = new System.Windows.Forms.Label();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.lbMath = new System.Windows.Forms.Label();
            this.txtAB = new System.Windows.Forms.TextBox();
            this.lbAB = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.axwmfLook = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnSongType = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.dgvSong = new System.Windows.Forms.DataGridView();
            this.SongID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Songab = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongWordCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofdMusic = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axwmfLook)).BeginInit();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEdit
            // 
            this.gbEdit.BackColor = System.Drawing.Color.Transparent;
            this.gbEdit.Controls.Add(this.txtFile);
            this.gbEdit.Controls.Add(this.cboSinger);
            this.gbEdit.Controls.Add(this.cboType);
            this.gbEdit.Controls.Add(this.txtClick);
            this.gbEdit.Controls.Add(this.lbClick);
            this.gbEdit.Controls.Add(this.lbSinger);
            this.gbEdit.Controls.Add(this.lbType);
            this.gbEdit.Controls.Add(this.txtMath);
            this.gbEdit.Controls.Add(this.lbMath);
            this.gbEdit.Controls.Add(this.txtAB);
            this.gbEdit.Controls.Add(this.lbAB);
            this.gbEdit.Controls.Add(this.txtName);
            this.gbEdit.Controls.Add(this.lbName);
            this.gbEdit.Controls.Add(this.txtID);
            this.gbEdit.Controls.Add(this.lbID);
            this.gbEdit.Controls.Add(this.axwmfLook);
            this.gbEdit.Controls.Add(this.btnSongType);
            this.gbEdit.Controls.Add(this.btnLook);
            this.gbEdit.Controls.Add(this.btnReset);
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnEdit);
            this.gbEdit.Controls.Add(this.btnAdd);
            this.gbEdit.Location = new System.Drawing.Point(9, 289);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(750, 334);
            this.gbEdit.TabIndex = 3;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "歌曲管理";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(531, 209);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(200, 21);
            this.txtFile.TabIndex = 34;
            // 
            // cboSinger
            // 
            this.cboSinger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSinger.FormattingEnabled = true;
            this.cboSinger.Location = new System.Drawing.Point(89, 240);
            this.cboSinger.Name = "cboSinger";
            this.cboSinger.Size = new System.Drawing.Size(414, 20);
            this.cboSinger.TabIndex = 33;
            // 
            // cboType
            // 
            this.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(89, 199);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(414, 20);
            this.cboType.TabIndex = 32;
            // 
            // txtClick
            // 
            this.txtClick.Location = new System.Drawing.Point(89, 280);
            this.txtClick.Name = "txtClick";
            this.txtClick.Size = new System.Drawing.Size(414, 21);
            this.txtClick.TabIndex = 31;
            // 
            // lbClick
            // 
            this.lbClick.AutoSize = true;
            this.lbClick.Location = new System.Drawing.Point(26, 283);
            this.lbClick.Name = "lbClick";
            this.lbClick.Size = new System.Drawing.Size(41, 12);
            this.lbClick.TabIndex = 30;
            this.lbClick.Text = "点击量";
            // 
            // lbSinger
            // 
            this.lbSinger.AutoSize = true;
            this.lbSinger.Location = new System.Drawing.Point(26, 243);
            this.lbSinger.Name = "lbSinger";
            this.lbSinger.Size = new System.Drawing.Size(53, 12);
            this.lbSinger.TabIndex = 28;
            this.lbSinger.Text = "歌手名称";
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Location = new System.Drawing.Point(26, 202);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(53, 12);
            this.lbType.TabIndex = 26;
            this.lbType.Text = "歌曲类型";
            // 
            // txtMath
            // 
            this.txtMath.Location = new System.Drawing.Point(89, 160);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(414, 21);
            this.txtMath.TabIndex = 25;
            // 
            // lbMath
            // 
            this.lbMath.AutoSize = true;
            this.lbMath.Location = new System.Drawing.Point(26, 163);
            this.lbMath.Name = "lbMath";
            this.lbMath.Size = new System.Drawing.Size(53, 12);
            this.lbMath.TabIndex = 24;
            this.lbMath.Text = "名称字数";
            // 
            // txtAB
            // 
            this.txtAB.Location = new System.Drawing.Point(89, 119);
            this.txtAB.Name = "txtAB";
            this.txtAB.Size = new System.Drawing.Size(414, 21);
            this.txtAB.TabIndex = 23;
            // 
            // lbAB
            // 
            this.lbAB.AutoSize = true;
            this.lbAB.Location = new System.Drawing.Point(26, 122);
            this.lbAB.Name = "lbAB";
            this.lbAB.Size = new System.Drawing.Size(53, 12);
            this.lbAB.TabIndex = 22;
            this.lbAB.Text = "拼音缩写";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(414, 21);
            this.txtName.TabIndex = 21;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(26, 80);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 12);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "歌曲名称";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 32);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(414, 21);
            this.txtID.TabIndex = 19;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(26, 35);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(41, 12);
            this.lbID.TabIndex = 18;
            this.lbID.Text = "歌曲ID";
            // 
            // axwmfLook
            // 
            this.axwmfLook.Enabled = true;
            this.axwmfLook.Location = new System.Drawing.Point(532, 154);
            this.axwmfLook.Name = "axwmfLook";
            this.axwmfLook.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axwmfLook.OcxState")));
            this.axwmfLook.Size = new System.Drawing.Size(200, 45);
            this.axwmfLook.TabIndex = 17;
            // 
            // btnSongType
            // 
            this.btnSongType.Location = new System.Drawing.Point(532, 278);
            this.btnSongType.Name = "btnSongType";
            this.btnSongType.Size = new System.Drawing.Size(200, 42);
            this.btnSongType.TabIndex = 16;
            this.btnSongType.Text = "歌曲类型管理";
            this.btnSongType.UseVisualStyleBackColor = true;
            this.btnSongType.Click += new System.EventHandler(this.btnSongType_Click);
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(532, 236);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(200, 23);
            this.btnLook.TabIndex = 15;
            this.btnLook.Text = "浏览...";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(656, 27);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "刷新";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(656, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(532, 27);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(532, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dgvSong);
            this.gbInfo.Location = new System.Drawing.Point(12, 16);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(842, 267);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "歌曲信息";
            // 
            // dgvSong
            // 
            this.dgvSong.AllowUserToAddRows = false;
            this.dgvSong.AllowUserToDeleteRows = false;
            this.dgvSong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSong.BackgroundColor = System.Drawing.Color.White;
            this.dgvSong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongID,
            this.SingerID,
            this.SongTypeID,
            this.SongName,
            this.Songab,
            this.SongWordCount,
            this.SongTypeName,
            this.SingerName,
            this.Url,
            this.ClientCount});
            this.dgvSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSong.Location = new System.Drawing.Point(3, 17);
            this.dgvSong.Name = "dgvSong";
            this.dgvSong.ReadOnly = true;
            this.dgvSong.RowTemplate.Height = 23;
            this.dgvSong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSong.Size = new System.Drawing.Size(836, 247);
            this.dgvSong.TabIndex = 0;
            this.dgvSong.SelectionChanged += new System.EventHandler(this.dgvSong_SelectionChanged);
            // 
            // SongID
            // 
            this.SongID.DataPropertyName = "SongID";
            this.SongID.HeaderText = "歌曲ID";
            this.SongID.Name = "SongID";
            this.SongID.ReadOnly = true;
            // 
            // SingerID
            // 
            this.SingerID.DataPropertyName = "SingerID";
            this.SingerID.HeaderText = "歌手ID";
            this.SingerID.Name = "SingerID";
            this.SingerID.ReadOnly = true;
            this.SingerID.Visible = false;
            // 
            // SongTypeID
            // 
            this.SongTypeID.DataPropertyName = "SongTypeID";
            this.SongTypeID.HeaderText = "歌曲类型ID";
            this.SongTypeID.Name = "SongTypeID";
            this.SongTypeID.ReadOnly = true;
            this.SongTypeID.Visible = false;
            // 
            // SongName
            // 
            this.SongName.DataPropertyName = "SongName";
            this.SongName.HeaderText = "歌曲名称";
            this.SongName.Name = "SongName";
            this.SongName.ReadOnly = true;
            // 
            // Songab
            // 
            this.Songab.DataPropertyName = "Songab";
            this.Songab.HeaderText = "拼音缩写";
            this.Songab.Name = "Songab";
            this.Songab.ReadOnly = true;
            // 
            // SongWordCount
            // 
            this.SongWordCount.DataPropertyName = "SongWordCount";
            this.SongWordCount.HeaderText = "名称字数";
            this.SongWordCount.Name = "SongWordCount";
            this.SongWordCount.ReadOnly = true;
            // 
            // SongTypeName
            // 
            this.SongTypeName.DataPropertyName = "SongTypeName";
            this.SongTypeName.HeaderText = "歌曲类型";
            this.SongTypeName.Name = "SongTypeName";
            this.SongTypeName.ReadOnly = true;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SingerName";
            this.SingerName.HeaderText = "歌手名称";
            this.SingerName.Name = "SingerName";
            this.SingerName.ReadOnly = true;
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.HeaderText = "歌曲地址";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            // 
            // ClientCount
            // 
            this.ClientCount.DataPropertyName = "ClientCount";
            this.ClientCount.HeaderText = "歌曲点击量";
            this.ClientCount.Name = "ClientCount";
            this.ClientCount.ReadOnly = true;
            // 
            // ofdMusic
            // 
            this.ofdMusic.Filter = "音乐文件|*.mp3;*.ogg;*.flac;*.wmv|视频文件|*.mp4;*.mkv;*.mov;*.avi;*.3gp|所有文件|*.*";
            this.ofdMusic.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdMusic_FileOk);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MyKTV_Server.Properties.Resources.undraw_online_media_62jb;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(747, 544);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 91);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // frmSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(866, 635);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSong";
            this.Text = "MyKTV - 歌曲管理";
            this.Load += new System.EventHandler(this.frmSong_Load);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axwmfLook)).EndInit();
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnSongType;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox gbInfo;
        private AxWMPLib.AxWindowsMediaPlayer axwmfLook;
        private System.Windows.Forms.OpenFileDialog ofdMusic;
        private System.Windows.Forms.DataGridView dgvSong;
        private System.Windows.Forms.TextBox txtClick;
        private System.Windows.Forms.Label lbClick;
        private System.Windows.Forms.Label lbSinger;
        private System.Windows.Forms.Label lbType;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.Label lbMath;
        private System.Windows.Forms.TextBox txtAB;
        private System.Windows.Forms.Label lbAB;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cboSinger;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Songab;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongWordCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientCount;
        private System.Windows.Forms.TextBox txtFile;
    }
}