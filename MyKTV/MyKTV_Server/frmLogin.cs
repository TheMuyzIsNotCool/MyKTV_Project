using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MyKTV_Tools;
namespace MyKTV_Server
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnCannel_Click(object sender, EventArgs e)
        {
            /*
             关闭当前窗体（如果当前窗体为第一个窗体，则系统关闭）
             窗口示例.CLose();

             关闭应用应用程序
             Application.Exit()
             */
            DialogResult dr = MessageBox.Show("确定关闭KTV管理系统吗？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button2);
            if (dr == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (this.txtUser.Text != "" )
            {
                this.btnOK.Enabled = true;
            }
            else
            {
                this.btnOK.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.progressBar1.Visible = true;
            progressBar1.Maximum = 100;//设置最大长度值
            progressBar1.Value = 0;//设置当前值
            progressBar1.Value = 99;//设置当前值
            progressBar1.Step = 1;//设置没次增长多少
            for (int i = 0; i < 1; i++)//循环
            {
                System.Threading.Thread.Sleep(100);//暂停0.1秒
                progressBar1.Value += progressBar1.Step; //让进度条增加一次
            }

            if (progressBar1.Value == 100)
            {
                string sqlStr = "select * from AdminInfo where AName ='" + this.txtUser.Text + "'or  APwd = '" + this.txtpwd.Text + "'";
                DataTable dt = DBHelper.getTable(sqlStr);
                if (dt != null)
                {
                    this.Hide();
                    MessageBox.Show("登录成功");
                    Helper.username = this.txtUser.Text;
                    frmMain fm = new frmMain();
                    fm.ShowDialog();
                    progressBar1.Value = 0;//设置当前值
                    this.txtpwd.Text = "";
                    this.progressBar1.Visible = false;
                    this.Visible = true;
                    
                }
                else
                {
                    MessageBox.Show("登录失败，请检查账户密码是否匹配后再试");
                    this.progressBar1.Visible = false;
                    this.txtpwd.Text = "";
                }
            }

            
            
        }
    }
}
