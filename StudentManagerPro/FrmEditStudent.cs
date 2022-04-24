using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using Models;
using DAL;
using Models.Models;

namespace StudentManager
{
    public partial class FrmEditStudent : Form
    {
        private readonly StudentClassService objClassService = new StudentClassService();
        private readonly StudentService objStudentService = new StudentService();

        public FrmEditStudent()
        {
            InitializeComponent();
            //初始化班级下拉框
            this.cboClassName.DataSource = objClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1;  //默认不选择
        }

        public FrmEditStudent(StudentExt objStudentExt) : this()
        {  //显示学员信息
            this.txtStudentId.Text = objStudentExt.StudentId.ToString();
            this.txtStudentName.Text = objStudentExt.StudentName;
            this.txtStudentIdNo.Text = objStudentExt.StudentIdNo;
            this.txtPhoneNumber.Text = objStudentExt.PhoneNumber;
            this.dtpBirthday.Text = objStudentExt.Birthday.ToShortDateString();
            this.txtAddress.Text = objStudentExt.StudentAddress;
            rdoMale.Checked = objStudentExt.Gender == "男";
            rdoFemale.Checked = !rdoMale.Checked;
            this.cboClassName.Text = objStudentExt.ClassName;
            this.txtCardNo.Text = objStudentExt.CardNo;
        }

        //提交修改
        private void btnModify_Click(object sender, EventArgs e)
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
            if (objStudentService.isIdNoExisted(this.txtStudentIdNo.Text.Trim(), this.txtStudentId.Text.Trim()))
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
                StudentId = Convert.ToInt32(this.txtStudentId.Text.Trim()),
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

            //提交修改
            try
            {
                if (objStudentService.ModifyStudent(objStudent) == 1)
                {
                    MessageBox.Show("学员信息修改成功！", "提示信息");
                    this.DialogResult = DialogResult.OK; //返回修改成功的信息
                    this.Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}