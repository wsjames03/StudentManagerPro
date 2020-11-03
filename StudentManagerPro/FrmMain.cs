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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ClosePreForm();//关闭已经存在的窗体
            OpenForm(new FrmAddStudent()); //打开窗体
        }

        #region "关闭前窗体嵌入新窗体"

        private void OpenForm(Form objAddStudent)
        {
            objAddStudent.TopLevel = false; // 将子窗体设置成非顶级控件
            objAddStudent.WindowState = FormWindowState.Maximized; //让子窗体最大化显示
            objAddStudent.FormBorderStyle = FormBorderStyle.None; //去掉窗体的边框
            objAddStudent.Parent = spContainer.Panel2; //指定子窗体显示的容器
            objAddStudent.Show();
        }

        private void ClosePreForm()
        {
            //首先判断当前容器中是否已经存在窗体
            foreach (Control item in this.spContainer.Panel2.Controls)
            {
                if (item is Form objForm)
                {
                    objForm.Close();
                }
            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClosePreForm();//关闭已经存在的窗体
            OpenForm(new FrmStudentManage()); //打开窗体
        }
    }
}
