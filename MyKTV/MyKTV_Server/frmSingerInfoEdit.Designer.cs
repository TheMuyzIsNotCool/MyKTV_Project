namespace MyKTV_Server
{
    partial class frmSingerInfoEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSingerInfoEdit));
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.dgvsingerinfo = new System.Windows.Forms.DataGridView();
            this.SingerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.btnAddSingerType = new System.Windows.Forms.Button();
            this.btnLook = new System.Windows.Forms.Button();
            this.txtFile = new System.Windows.Forms.MaskedTextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbSex = new System.Windows.Forms.Label();
            this.lbLike = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbSingerID = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdPic = new System.Windows.Forms.OpenFileDialog();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsingerinfo)).BeginInit();
            this.gbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dgvsingerinfo);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(757, 200);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "歌手信息";
            // 
            // dgvsingerinfo
            // 
            this.dgvsingerinfo.AllowUserToAddRows = false;
            this.dgvsingerinfo.AllowUserToDeleteRows = false;
            this.dgvsingerinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsingerinfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvsingerinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsingerinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SingerID,
            this.SingerName,
            this.SingerTypeName,
            this.SingerTypeID,
            this.Gender,
            this.Photo});
            this.dgvsingerinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsingerinfo.Location = new System.Drawing.Point(3, 17);
            this.dgvsingerinfo.Name = "dgvsingerinfo";
            this.dgvsingerinfo.ReadOnly = true;
            this.dgvsingerinfo.RowTemplate.Height = 23;
            this.dgvsingerinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsingerinfo.Size = new System.Drawing.Size(751, 180);
            this.dgvsingerinfo.TabIndex = 0;
            this.dgvsingerinfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvsingerinfo.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsingerinfo_CellContentDoubleClick);
            this.dgvsingerinfo.SelectionChanged += new System.EventHandler(this.dgvsingerinfo_SelectionChanged);
            // 
            // SingerID
            // 
            this.SingerID.DataPropertyName = "SingerID";
            this.SingerID.HeaderText = "歌手ID";
            this.SingerID.Name = "SingerID";
            this.SingerID.ReadOnly = true;
            this.SingerID.Visible = false;
            // 
            // SingerName
            // 
            this.SingerName.DataPropertyName = "SingerName";
            this.SingerName.HeaderText = "歌手信息";
            this.SingerName.Name = "SingerName";
            this.SingerName.ReadOnly = true;
            // 
            // SingerTypeName
            // 
            this.SingerTypeName.DataPropertyName = "SingerTypeName";
            this.SingerTypeName.HeaderText = "歌手类型";
            this.SingerTypeName.Name = "SingerTypeName";
            this.SingerTypeName.ReadOnly = true;
            // 
            // SingerTypeID
            // 
            this.SingerTypeID.DataPropertyName = "SingerTypeID";
            this.SingerTypeID.HeaderText = "歌手类型ID";
            this.SingerTypeID.Name = "SingerTypeID";
            this.SingerTypeID.ReadOnly = true;
            this.SingerTypeID.Visible = false;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "性别";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Photo
            // 
            this.Photo.DataPropertyName = "Photo";
            this.Photo.HeaderText = "照片文件名";
            this.Photo.Name = "Photo";
            this.Photo.ReadOnly = true;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.btnAddSingerType);
            this.gbEdit.Controls.Add(this.btnLook);
            this.gbEdit.Controls.Add(this.txtFile);
            this.gbEdit.Controls.Add(this.pbImage);
            this.gbEdit.Controls.Add(this.btnReset);
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnEdit);
            this.gbEdit.Controls.Add(this.btnAdd);
            this.gbEdit.Controls.Add(this.cbSex);
            this.gbEdit.Controls.Add(this.cbType);
            this.gbEdit.Controls.Add(this.txtName);
            this.gbEdit.Controls.Add(this.txtID);
            this.gbEdit.Controls.Add(this.lbSex);
            this.gbEdit.Controls.Add(this.lbLike);
            this.gbEdit.Controls.Add(this.lbName);
            this.gbEdit.Controls.Add(this.lbSingerID);
            this.gbEdit.Location = new System.Drawing.Point(12, 228);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(757, 296);
            this.gbEdit.TabIndex = 1;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "歌手管理";
            // 
            // btnAddSingerType
            // 
            this.btnAddSingerType.Location = new System.Drawing.Point(43, 177);
            this.btnAddSingerType.Name = "btnAddSingerType";
            this.btnAddSingerType.Size = new System.Drawing.Size(417, 40);
            this.btnAddSingerType.TabIndex = 16;
            this.btnAddSingerType.Text = "添加歌手类型";
            this.btnAddSingerType.UseVisualStyleBackColor = true;
            this.btnAddSingerType.Click += new System.EventHandler(this.btnAddSingerType_Click);
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(538, 251);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(200, 23);
            this.btnLook.TabIndex = 15;
            this.btnLook.Text = "浏览...";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(537, 223);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(200, 21);
            this.txtFile.TabIndex = 14;
            // 
            // pbImage
            // 
            this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbImage.Location = new System.Drawing.Point(538, 17);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(200, 200);
            this.pbImage.TabIndex = 13;
            this.pbImage.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(385, 234);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "刷新";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 234);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(138, 234);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(24, 234);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女",
            "组合"});
            this.cbSex.Location = new System.Drawing.Point(326, 139);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(137, 20);
            this.cbSex.TabIndex = 8;
            // 
            // cbType
            // 
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(326, 59);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(137, 20);
            this.cbType.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 139);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 21);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(81, 59);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(137, 21);
            this.txtID.TabIndex = 4;
            // 
            // lbSex
            // 
            this.lbSex.AutoSize = true;
            this.lbSex.Location = new System.Drawing.Point(255, 142);
            this.lbSex.Name = "lbSex";
            this.lbSex.Size = new System.Drawing.Size(53, 12);
            this.lbSex.TabIndex = 3;
            this.lbSex.Text = "歌手性别";
            // 
            // lbLike
            // 
            this.lbLike.AutoSize = true;
            this.lbLike.Location = new System.Drawing.Point(255, 65);
            this.lbLike.Name = "lbLike";
            this.lbLike.Size = new System.Drawing.Size(53, 12);
            this.lbLike.TabIndex = 2;
            this.lbLike.Text = "歌手类型";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(22, 142);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(53, 12);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "歌手名称";
            // 
            // lbSingerID
            // 
            this.lbSingerID.AutoSize = true;
            this.lbSingerID.Location = new System.Drawing.Point(22, 65);
            this.lbSingerID.Name = "lbSingerID";
            this.lbSingerID.Size = new System.Drawing.Size(53, 12);
            this.lbSingerID.TabIndex = 0;
            this.lbSingerID.Text = "歌手编号";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // ofdPic
            // 
            this.ofdPic.FileName = "选择文件";
            this.ofdPic.Filter = "JPG文件|*.jpg|所有文件|*.*|PNG文件|*.png";
            // 
            // frmSingerInfoEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(781, 536);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmSingerInfoEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "歌手管理 - MyKTV";
            this.Load += new System.EventHandler(this.frmSingerInfoEdit_Load);
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsingerinfo)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DataGridView dgvsingerinfo;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbSex;
        private System.Windows.Forms.Label lbLike;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSingerID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Photo;
        private System.Windows.Forms.MaskedTextBox txtFile;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.OpenFileDialog ofdPic;
        private System.Windows.Forms.Button btnAddSingerType;
    }
}