using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Models.Models;

namespace StudentManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //创建登录窗体
            FrmUserLogin objFrmUserLogin = new FrmUserLogin();
            var result = objFrmUserLogin.ShowDialog();

            //判断登录是否成功
            if (result == DialogResult.OK)
                Application.Run(new FrmMain());
            else
                Application.Exit();//退出整个应用程序

        }

        //定义一个全局变量保存用户对象
        public static SysAdmin objCurrentAdmin = null;
    }
}
