namespace MyKTV_Server
{
    partial class frmSongType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSongType));
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.dgvtype = new System.Windows.Forms.DataGridView();
            this.SongTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SongTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtype)).BeginInit();
            this.gbEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dgvtype);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(780, 247);
            this.gbInfo.TabIndex = 0;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "歌曲类型信息";
            // 
            // dgvtype
            // 
            this.dgvtype.AllowUserToAddRows = false;
            this.dgvtype.AllowUserToDeleteRows = false;
            this.dgvtype.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtype.BackgroundColor = System.Drawing.Color.White;
            this.dgvtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SongTypeID,
            this.SongTypeName});
            this.dgvtype.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvtype.Location = new System.Drawing.Point(3, 17);
            this.dgvtype.Name = "dgvtype";
            this.dgvtype.ReadOnly = true;
            this.dgvtype.RowTemplate.Height = 23;
            this.dgvtype.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvtype.Size = new System.Drawing.Size(774, 227);
            this.dgvtype.TabIndex = 0;
            this.dgvtype.SelectionChanged += new System.EventHandler(this.dgvtype_SelectionChanged);
            // 
            // SongTypeID
            // 
            this.SongTypeID.DataPropertyName = "SongTypeID";
            this.SongTypeID.HeaderText = "歌曲类型ID";
            this.SongTypeID.Name = "SongTypeID";
            this.SongTypeID.ReadOnly = true;
            // 
            // SongTypeName
            // 
            this.SongTypeName.DataPropertyName = "SongTypeName";
            this.SongTypeName.HeaderText = "歌曲类型名称";
            this.SongTypeName.Name = "SongTypeName";
            this.SongTypeName.ReadOnly = true;
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.txtName);
            this.gbEdit.Controls.Add(this.lbName);
            this.gbEdit.Controls.Add(this.txtID);
            this.gbEdit.Controls.Add(this.lbID);
            this.gbEdit.Controls.Add(this.btnReset);
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnEdit);
            this.gbEdit.Controls.Add(this.btnAdd);
            this.gbEdit.Location = new System.Drawing.Point(12, 265);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(780, 216);
            this.gbEdit.TabIndex = 1;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "歌曲类型管理";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(357, 21);
            this.txtName.TabIndex = 20;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(37, 131);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(77, 12);
            this.lbName.TabIndex = 19;
            this.lbName.Text = "歌曲类型名称";
            this.lbName.Click += new System.EventHandler(this.lbName_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(130, 63);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(357, 21);
            this.txtID.TabIndex = 18;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(37, 66);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(65, 12);
            this.lbID.TabIndex = 17;
            this.lbID.Text = "歌曲类型ID";
            this.lbID.Click += new System.EventHandler(this.lbID_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(668, 63);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 29);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "刷新";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(668, 124);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(544, 63);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 29);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(544, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 29);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmSongType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 493);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSongType";
            this.Text = "MyKTV - 歌手类型管理";
            this.Load += new System.EventHandler(this.frmSongType_Load);
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtype)).EndInit();
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.DataGridView dgvtype;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SongTypeName;
    }
}