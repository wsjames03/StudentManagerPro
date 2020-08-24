using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentManagerPro
{
    public partial class FrmUserLogin : Form
    {
        public FrmUserLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // if (bLogin())
            // {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            // }

        }


        /// <summary>
        /// 系统登录
        /// </summary>
        /// <returns></returns>
        private bool bLogin()
        {

            String sAccount = this.txtAccount.Text;
            String sPassWd = this.txtPassWd.Text;

            if (sAccount == "wsjames03" && sPassWd == "960805")
            {
                return true;
            }
            else
            {
                MessageBox.Show("用户名或密码错误", "系统", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        /// <summary>
        /// 退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
