using MyKTV_Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyKTV_Server
{
    public partial class frmSongType : Form
    {
        public frmSongType()
        {
            InitializeComponent();
        }

        public void showdgv()
        {
            string sqlStr = "select * from SongType";
            this.dgvtype.DataSource = DBHelper.getTable(sqlStr);
        }

        public void ade(string sqlStr)
        {
            try
            {
                int result = DBHelper.getNonQuery(sqlStr);
                if (result > 0)
                {
                    MessageBox.Show("操作成功", "提示");
                    showdgv();
                }
                else
                {
                    MessageBox.Show("操作失败", "提示");
                    showdgv();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("操作出错，原因：" + ex.Message, "提示");
                showdgv();
            }
        }

        private void lbName_Click(object sender, EventArgs e)
        {

        }

        private void lbID_Click(object sender, EventArgs e)
        {

        }

        private void frmSongType_Load(object sender, EventArgs e)
        {
            showdgv();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sqlStr = "update SongType set SongTypeName = '" + this.txtName.Text +"' where SongTypeID= "+this.txtID.Text;
            ade(sqlStr);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sqlStr = "insert into SongType values('"+this.txtName.Text+"')";
            ade(sqlStr);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtID.Text = "";
            this.txtName.Text = "";
            showdgv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    string sqlStr = "delete from SongType where SongTypeID=" + this.txtID.Text;
                    int result = DBHelper.getNonQuery(sqlStr);
                    if (result > 0)
                    {
                        MessageBox.Show("操作成功", "提示");
                        showdgv();
                    }
                    break;
                }
                catch (Exception)
                {
                    DialogResult dr = MessageBox.Show("即将删除有关该类型的所有音乐，是否确定", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr == DialogResult.Yes)
                    {
                        string sqlStr = "delete from Song where SongTypeID=" + this.txtID.Text;
                        int result = DBHelper.getNonQuery(sqlStr);
                        if (result > 0)
                        {
                            MessageBox.Show("删除操作成功", "提示");
                            showdgv();
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }  
        }

        private void dgvtype_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvtype.SelectedRows.Count >0)
            {
                this.txtID.Text = this.dgvtype.SelectedRows[0].Cells["SongTypeID"].Value.ToString(); ;
                this.txtName.Text = this.dgvtype.SelectedRows[0].Cells["SongTypeName"].Value.ToString();
            }
            
        }
    }
}
