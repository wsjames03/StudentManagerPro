using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DAL;
using Models;
using Models.Models;

namespace StudentManager
{
    public partial class FrmAddStudent : Form
    {
        private readonly StudentClassService objClassService = new StudentClassService();
        private readonly StudentService objStudentService = new StudentService();

        public FrmAddStudent()
        {
            InitializeComponent();

            //初始化班级下拉框
            this.cboClassName.DataSource = objClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1;  //默认不选择

        }

        //添加新学员
        private void btnAdd_Click(object sender, EventArgs e)
        {

            //数据验证
            if (string.IsNullOrWhiteSpace(this.txtStudentName.Text))
            {
                MessageBox.Show("学生姓名不能为空！", "提示信息");
                this.txtStudentName.Focus();
                return;
            }

            if (!this.rdoMale.Checked && !this.rdoFemale.Checked)
            {
                MessageBox.Show("请选择学员性别！", "提示信息");
                return;
            }

            if (this.cboClassName.SelectedIndex < 0)
            {
                MessageBox.Show("请选择班级！", "提示信息");
                this.cboClassName.Focus();
                return;
            }

            if (!Common.DataValidate.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("身份证号不符合要求！", "验证提示");
                this.txtStudentIdNo.Focus();
                return;
            }

            //验证身份证号是否重复
            if (objStudentService.isIdNoExisted(this.txtStudentIdNo.Text.Trim(), string.Empty))
            {
                MessageBox.Show("身份证号不能和现有学员重复，请认真检查！", "验证提示");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }

            //验证身份证号和出生日期是否吻合（省略）

            //封装学生对象
            StudentExt objStudent = new StudentExt()
            {
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoMale.Checked ? "男" : "女",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = this.txtStudentIdNo.Text,
                PhoneNumber = this.txtPhoneNumber.Text,
                StudentAddress = this.txtAddress.Text,
                CardNo = this.txtCardNo.Text,
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),//获取选择班级对应的classId
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year
            };

            //调用后台数据访问方法,添加对象
            try
            {
                if (objStudentService.AddStudent(objStudent) == 1)
                {
                    var result = MessageBox.Show("新学员添加成功！是否继续添加?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) //清空用户的输入
                    {
                        this.cboClassName.SelectedIndex = -1;
                        this.rdoFemale.Checked = false;
                        this.rdoMale.Checked = false;
                        //清楚文本框
                        foreach (Control item in this.Controls)
                        {
                            if (item is TextBox)
                                item.Text = string.Empty;
                        }

                        this.txtStudentName.Focus();
                    }
                    else
                    {
                        this.Close();
                    }

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        //关闭窗体
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //窗体已经被关闭
        private void FrmAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAddStudent = null;  //当窗体对象关闭的时候,清空
        }
    }
}