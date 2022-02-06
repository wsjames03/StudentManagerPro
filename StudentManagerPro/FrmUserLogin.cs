﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using Models.Models;


namespace StudentManager
{
    public partial class FrmUserLogin : Form
    {
        /// <summary>
        /// 创建数据访问类对象
        /// </summary>
        private SysAdminService objAdminService = new SysAdminService();

        public FrmUserLogin()
        {
            InitializeComponent();
        }


        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //1.数据验证
            if (string.IsNullOrWhiteSpace(this.txtLoginId.Text))
            {
                MessageBox.Show("请输入登录账号!", "登录提示");
                this.txtLoginId.Focus();
                return;
            }

            //2.封装对象(实际封装的是用户的登录账号和密码)
            var objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim()
            };

            //3.和后台交互，判断登录信息是否正确
            try
            {
                objAdmin = objAdminService.AdminLogin(objAdmin);
                if (objAdmin?.LoginPwd == this.txtLoginPwd.Text.Trim())   //如果登录成功
                {
                    //保存登录信息
                    Program.objCurrentAdmin = objAdmin;
                    //设置登录窗体的返回值
                    this.DialogResult = DialogResult.OK;
                    //关闭窗体
                    this.Close();
                }
                else
                {
                    MessageBox.Show("登录账号或者密码有误！", "登录提示");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("数据访问出现异常，登录失败！具体原因：" + ex.Message);
            }



        }
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        #region 改善用户体验

        private void txtLoginId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                if (string.IsNullOrWhiteSpace(this.txtLoginId.Text))
                {
                    MessageBox.Show("请输入登录账号!", "登录提示");
                    this.txtLoginId.Focus();
                    return;
                }
                else
                {
                    this.txtLoginPwd.Focus();//将当前的焦点跳转到密码框
                }
            }

        }

        private void txtLoginPwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.btnLogin_Click(null, null); //直接调用登录按钮的事件
            }
        }

        #endregion

    }
}
