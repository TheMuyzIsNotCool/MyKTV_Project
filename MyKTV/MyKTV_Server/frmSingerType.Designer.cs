namespace MyKTV_Server
{
    partial class frmSingerType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSingerType));
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbLike = new System.Windows.Forms.Label();
            this.lbSingerID = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.dgvsingerinfo = new System.Windows.Forms.DataGridView();
            this.SingerTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SingerTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEdit.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsingerinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.txtName);
            this.gbEdit.Controls.Add(this.btnReset);
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnEdit);
            this.gbEdit.Controls.Add(this.btnAdd);
            this.gbEdit.Controls.Add(this.txtID);
            this.gbEdit.Controls.Add(this.lbLike);
            this.gbEdit.Controls.Add(this.lbSingerID);
            this.gbEdit.Location = new System.Drawing.Point(12, 228);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(757, 159);
            this.gbEdit.TabIndex = 3;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "歌手管理";
            this.gbEdit.Enter += new System.EventHandler(this.gbEdit_Enter);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(462, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(253, 21);
            this.txtName.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(506, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "刷新";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(380, 95);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(259, 95);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(145, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(74, 45);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(253, 21);
            this.txtID.TabIndex = 6;
            // 
            // lbLike
            // 
            this.lbLike.AutoSize = true;
            this.lbLike.Location = new System.Drawing.Point(403, 48);
            this.lbLike.Name = "lbLike";
            this.lbLike.Size = new System.Drawing.Size(53, 12);
            this.lbLike.TabIndex = 2;
            this.lbLike.Text = "歌手类型";
            // 
            // lbSingerID
            // 
            this.lbSingerID.AutoSize = true;
            this.lbSingerID.Location = new System.Drawing.Point(15, 48);
            this.lbSingerID.Name = "lbSingerID";
            this.lbSingerID.Size = new System.Drawing.Size(53, 12);
            this.lbSingerID.TabIndex = 0;
            this.lbSingerID.Text = "歌手编号";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dgvsingerinfo);
            this.gbInfo.Location = new System.Drawing.Point(12, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(757, 200);
            this.gbInfo.TabIndex = 2;
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
            this.SingerTypeID,
            this.SingerTypeName});
            this.dgvsingerinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsingerinfo.Location = new System.Drawing.Point(3, 17);
            this.dgvsingerinfo.Name = "dgvsingerinfo";
            this.dgvsingerinfo.ReadOnly = true;
            this.dgvsingerinfo.RowTemplate.Height = 23;
            this.dgvsingerinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsingerinfo.Size = new System.Drawing.Size(751, 180);
            this.dgvsingerinfo.TabIndex = 0;
            this.dgvsingerinfo.SelectionChanged += new System.EventHandler(this.dgvsingerinfo_SelectionChanged);
            // 
            // SingerTypeID
            // 
            this.SingerTypeID.DataPropertyName = "SingerTypeID";
            this.SingerTypeID.HeaderText = "歌手类型ID";
            this.SingerTypeID.Name = "SingerTypeID";
            this.SingerTypeID.ReadOnly = true;
            // 
            // SingerTypeName
            // 
            this.SingerTypeName.DataPropertyName = "SingerTypeName";
            this.SingerTypeName.HeaderText = "歌手类型姓名";
            this.SingerTypeName.Name = "SingerTypeName";
            this.SingerTypeName.ReadOnly = true;
            // 
            // frmSingerType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(791, 408);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSingerType";
            this.Text = "MyKTV - 添加歌手类型";
            this.Load += new System.EventHandler(this.frmSingerType_Load);
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsingerinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbLike;
        private System.Windows.Forms.Label lbSingerID;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DataGridView dgvsingerinfo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SingerTypeName;
    }
}