using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Models;
using Models.Models;

namespace StudentManager
{
    public partial class FrmStudentInfo : Form
    {
        public FrmStudentInfo()
        {
            InitializeComponent();
        }

        public FrmStudentInfo(StudentExt objStudentExt) : this()
        {
            //显示学员信息
            this.lblStudentName.Text = objStudentExt.StudentName;
            this.lblStudentIdNo.Text = objStudentExt.StudentIdNo;
            this.lblPhoneNumber.Text = objStudentExt.PhoneNumber;
            this.lblBirthday.Text = objStudentExt.Birthday.ToShortDateString();
            this.lblAddress.Text = objStudentExt.StudentAddress;
            this.lblGender.Text = objStudentExt.Gender;
            this.lblClass.Text = objStudentExt.ClassName;
            this.lblCardNo.Text = objStudentExt.CardNo;
        }

        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}