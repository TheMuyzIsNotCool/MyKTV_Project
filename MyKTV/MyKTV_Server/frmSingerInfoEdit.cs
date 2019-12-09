using MyKTV_Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyKTV_Server
{
    public partial class frmSingerInfoEdit : Form
    {
        public frmSingerInfoEdit()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            showdgv();
            this.txtID.Text = "";
            this.txtName.Text = "";
            this.cbSex.Text = "";
            this.cbType.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string sqlStr = "delete from singer where SingerID = "+this.txtID.Text;
            editors(sqlStr);
            showdgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlStr = "update singer set SingerName = '" + this.txtName.Text + "' , singerTypeID=" + this.cbType.SelectedValue + ",Gender='" + this.cbSex.Text + "',Photo='" + this.txtFile.Text + "' where SingerID =" + this.txtID.Text; ;
            editors(sqlStr);
            showdgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlStr = "insert into singer values('" + this.txtName.Text + "'," + this.cbType.SelectedValue + ",'" + this.cbSex.Text + "','" + this.txtFile.Text + "')";
            editors(sqlStr);
            showdgv();
        }

        private void frmSingerInfoEdit_Load(object sender, EventArgs e)
        {
            showdgv();
            showsingtype();
        }

        public void showsingtype()
        {
            this.cbType.Items.Clear();
            string sqlStr = "select SingerTypeID,SingerTypeName from SingerType";
            this.cbType.DataSource = DBHelper.getTable(sqlStr);
            this.cbType.DisplayMember = "SingerTypeName";
            this.cbType.ValueMember = "SingerTypeID";
        }

        public void showdgv()
        {
            string sqlStr = "select SingerID,SingerName,b.SingerTypeID,SingerTypeName,Gender,Photo from singer a,singerType b where a.SingerTypeID=b.SingerTypeID";
            dgvsingerinfo.DataSource = DBHelper.getTable(sqlStr);
        }

        private void btnLook_Click(object sender, EventArgs e)
        {
            this.ofdPic.ShowDialog();
            this.txtFile.Text = this.ofdPic.SafeFileName;
            this.pbImage.Image = Image.FromFile(this.ofdPic.FileName);
        }

        //增删改
        public void editors(string sqlStr)
        {
            int result = DBHelper.getNonQuery(sqlStr);
            if (result > 0)
            {
                MessageBox.Show("操作成功","提示");
            }
            else
            {
                MessageBox.Show("操作失败","提示");
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.dgvsingerinfo.SelectedRows.Count > 0)
            {
                
            }
        }

        private void dgvsingerinfo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvsingerinfo_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvsingerinfo.SelectedRows.Count > 0)
            {
                this.txtID.Text = this.dgvsingerinfo.SelectedRows[0].Cells["SingerID"].Value.ToString();
                this.txtName.Text = this.dgvsingerinfo.SelectedRows[0].Cells["SingerName"].Value.ToString();
                
                string singertypename = this.dgvsingerinfo.SelectedRows[0].Cells["SingerTypeName"].Value.ToString();
                //选择项下拉框
                for (int i = 0; i < this.cbType.Items.Count; i++)
                {
                    DataRowView item = (DataRowView)this.cbType.Items[i];
                    if (item.Row[1].ToString() == singertypename)
                    {
                        this.cbType.SelectedIndex = i;
                        break;
                    }
                }
                //绑定照片
                string sqlStr = "Select RPath from ResourceUrl where RName='SingerPic'";
                string path = DBHelper.getScalar(sqlStr).ToString();
                this.txtFile.Text = path;
                path += "\\"+this.dgvsingerinfo.SelectedRows[0].Cells["Photo"].Value.ToString();
                this.pbImage.Image = Image.FromFile(path);
            }
        }

        private void btnAddSingerType_Click(object sender, EventArgs e)
        {
            frmSingerType fst = new frmSingerType();
            fst.Show();
        }
    }
}
