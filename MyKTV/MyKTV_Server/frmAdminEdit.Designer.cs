namespace MyKTV_Server
{
    partial class frmAdminEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminEdit));
            this.gbEdit = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbAdminName = new System.Windows.Forms.Label();
            this.lbAdminID = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.dgvsingerinfo = new System.Windows.Forms.DataGridView();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lbNewPwd = new System.Windows.Forms.Label();
            this.txtPwd2 = new System.Windows.Forms.TextBox();
            this.lbNewPwd2 = new System.Windows.Forms.Label();
            this.AID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEdit.SuspendLayout();
            this.gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsingerinfo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEdit
            // 
            this.gbEdit.Controls.Add(this.txtPwd2);
            this.gbEdit.Controls.Add(this.lbNewPwd2);
            this.gbEdit.Controls.Add(this.txtPwd);
            this.gbEdit.Controls.Add(this.lbNewPwd);
            this.gbEdit.Controls.Add(this.btnReset);
            this.gbEdit.Controls.Add(this.btnDelete);
            this.gbEdit.Controls.Add(this.btnEdit);
            this.gbEdit.Controls.Add(this.btnAdd);
            this.gbEdit.Controls.Add(this.txtName);
            this.gbEdit.Controls.Add(this.txtID);
            this.gbEdit.Controls.Add(this.lbAdminName);
            this.gbEdit.Controls.Add(this.lbAdminID);
            this.gbEdit.Location = new System.Drawing.Point(24, 228);
            this.gbEdit.Name = "gbEdit";
            this.gbEdit.Size = new System.Drawing.Size(401, 262);
            this.gbEdit.TabIndex = 3;
            this.gbEdit.TabStop = false;
            this.gbEdit.Text = "管理员管理";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(307, 165);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "刷新";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(307, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(307, 82);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(307, 44);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 21);
            this.txtName.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(81, 28);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(183, 21);
            this.txtID.TabIndex = 4;
            // 
            // lbAdminName
            // 
            this.lbAdminName.AutoSize = true;
            this.lbAdminName.Location = new System.Drawing.Point(10, 80);
            this.lbAdminName.Name = "lbAdminName";
            this.lbAdminName.Size = new System.Drawing.Size(65, 12);
            this.lbAdminName.TabIndex = 1;
            this.lbAdminName.Text = "管理员姓名";
            // 
            // lbAdminID
            // 
            this.lbAdminID.AutoSize = true;
            this.lbAdminID.Location = new System.Drawing.Point(22, 34);
            this.lbAdminID.Name = "lbAdminID";
            this.lbAdminID.Size = new System.Drawing.Size(53, 12);
            this.lbAdminID.TabIndex = 0;
            this.lbAdminID.Text = "管理员ID";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.dgvsingerinfo);
            this.gbInfo.Location = new System.Drawing.Point(24, 12);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(401, 200);
            this.gbInfo.TabIndex = 2;
            this.gbInfo.TabStop = false;
            this.gbInfo.Text = "管理员信息";
            // 
            // dgvsingerinfo
            // 
            this.dgvsingerinfo.AllowUserToAddRows = false;
            this.dgvsingerinfo.AllowUserToDeleteRows = false;
            this.dgvsingerinfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsingerinfo.BackgroundColor = System.Drawing.Color.White;
            this.dgvsingerinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsingerinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AID,
            this.AName,
            this.APwd});
            this.dgvsingerinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvsingerinfo.Location = new System.Drawing.Point(3, 17);
            this.dgvsingerinfo.Name = "dgvsingerinfo";
            this.dgvsingerinfo.ReadOnly = true;
            this.dgvsingerinfo.RowTemplate.Height = 23;
            this.dgvsingerinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsingerinfo.Size = new System.Drawing.Size(395, 180);
            this.dgvsingerinfo.TabIndex = 0;
            this.dgvsingerinfo.SelectionChanged += new System.EventHandler(this.dgvsingerinfo_SelectionChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(81, 124);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(183, 21);
            this.txtPwd.TabIndex = 14;
            // 
            // lbNewPwd
            // 
            this.lbNewPwd.AutoSize = true;
            this.lbNewPwd.Location = new System.Drawing.Point(34, 127);
            this.lbNewPwd.Name = "lbNewPwd";
            this.lbNewPwd.Size = new System.Drawing.Size(41, 12);
            this.lbNewPwd.TabIndex = 13;
            this.lbNewPwd.Text = "新密码";
            // 
            // txtPwd2
            // 
            this.txtPwd2.Location = new System.Drawing.Point(81, 177);
            this.txtPwd2.Name = "txtPwd2";
            this.txtPwd2.Size = new System.Drawing.Size(183, 21);
            this.txtPwd2.TabIndex = 16;
            // 
            // lbNewPwd2
            // 
            this.lbNewPwd2.AutoSize = true;
            this.lbNewPwd2.Location = new System.Drawing.Point(10, 180);
            this.lbNewPwd2.Name = "lbNewPwd2";
            this.lbNewPwd2.Size = new System.Drawing.Size(65, 12);
            this.lbNewPwd2.TabIndex = 15;
            this.lbNewPwd2.Text = "确认新密码";
            // 
            // AID
            // 
            this.AID.DataPropertyName = "AID";
            this.AID.HeaderText = "管理员ID";
            this.AID.Name = "AID";
            this.AID.ReadOnly = true;
            // 
            // AName
            // 
            this.AName.DataPropertyName = "AName";
            this.AName.HeaderText = "管理员姓名";
            this.AName.Name = "AName";
            this.AName.ReadOnly = true;
            // 
            // APwd
            // 
            this.APwd.DataPropertyName = "APwd";
            this.APwd.HeaderText = "PassWord";
            this.APwd.Name = "APwd";
            this.APwd.ReadOnly = true;
            this.APwd.Visible = false;
            // 
            // frmAdminEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(441, 500);
            this.Controls.Add(this.gbEdit);
            this.Controls.Add(this.gbInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAdminEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyKTV - 管理员管理";
            this.gbEdit.ResumeLayout(false);
            this.gbEdit.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsingerinfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdit;
        private System.Windows.Forms.TextBox txtPwd2;
        private System.Windows.Forms.Label lbNewPwd2;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lbNewPwd;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbAdminName;
        private System.Windows.Forms.Label lbAdminID;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.DataGridView dgvsingerinfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AName;
        private System.Windows.Forms.DataGridViewTextBoxColumn APwd;
    }
}