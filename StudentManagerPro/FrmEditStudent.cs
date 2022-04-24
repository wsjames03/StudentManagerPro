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
            //��ʼ���༶������
            this.cboClassName.DataSource = objClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1;  //Ĭ�ϲ�ѡ��
        }

        public FrmEditStudent(StudentExt objStudentExt) : this()
        {  //��ʾѧԱ��Ϣ
            this.txtStudentId.Text = objStudentExt.StudentId.ToString();
            this.txtStudentName.Text = objStudentExt.StudentName;
            this.txtStudentIdNo.Text = objStudentExt.StudentIdNo;
            this.txtPhoneNumber.Text = objStudentExt.PhoneNumber;
            this.dtpBirthday.Text = objStudentExt.Birthday.ToShortDateString();
            this.txtAddress.Text = objStudentExt.StudentAddress;
            rdoMale.Checked = objStudentExt.Gender == "��";
            rdoFemale.Checked = !rdoMale.Checked;
            this.cboClassName.Text = objStudentExt.ClassName;
            this.txtCardNo.Text = objStudentExt.CardNo;
        }

        //�ύ�޸�
        private void btnModify_Click(object sender, EventArgs e)
        {
            //������֤
            if (string.IsNullOrWhiteSpace(this.txtStudentName.Text))
            {
                MessageBox.Show("ѧ����������Ϊ�գ�", "��ʾ��Ϣ");
                this.txtStudentName.Focus();
                return;
            }

            if (!this.rdoMale.Checked && !this.rdoFemale.Checked)
            {
                MessageBox.Show("��ѡ��ѧԱ�Ա�", "��ʾ��Ϣ");
                return;
            }

            if (this.cboClassName.SelectedIndex < 0)
            {
                MessageBox.Show("��ѡ��༶��", "��ʾ��Ϣ");
                this.cboClassName.Focus();
                return;
            }

            if (!Common.DataValidate.IsIdentityCard(this.txtStudentIdNo.Text.Trim()))
            {
                MessageBox.Show("���֤�Ų�����Ҫ��", "��֤��ʾ");
                this.txtStudentIdNo.Focus();
                return;
            }

            //��֤���֤���Ƿ��ظ�
            if (objStudentService.isIdNoExisted(this.txtStudentIdNo.Text.Trim(), this.txtStudentId.Text.Trim()))
            {
                MessageBox.Show("���֤�Ų��ܺ�����ѧԱ�ظ����������飡", "��֤��ʾ");
                this.txtStudentIdNo.Focus();
                this.txtStudentIdNo.SelectAll();
                return;
            }

            //��֤���֤�źͳ��������Ƿ��Ǻϣ�ʡ�ԣ�

            //��װѧ������
            StudentExt objStudent = new StudentExt()
            {
                StudentId = Convert.ToInt32(this.txtStudentId.Text.Trim()),
                StudentName = this.txtStudentName.Text,
                Gender = this.rdoMale.Checked ? "��" : "Ů",
                Birthday = Convert.ToDateTime(this.dtpBirthday.Text),
                StudentIdNo = this.txtStudentIdNo.Text,
                PhoneNumber = this.txtPhoneNumber.Text,
                StudentAddress = this.txtAddress.Text,
                CardNo = this.txtCardNo.Text,
                ClassId = Convert.ToInt32(this.cboClassName.SelectedValue),//��ȡѡ��༶��Ӧ��classId
                Age = DateTime.Now.Year - Convert.ToDateTime(this.dtpBirthday.Text).Year
            };

            //�ύ�޸�
            try
            {
                if (objStudentService.ModifyStudent(objStudent) == 1)
                {
                    MessageBox.Show("ѧԱ��Ϣ�޸ĳɹ���", "��ʾ��Ϣ");
                    this.DialogResult = DialogResult.OK; //�����޸ĳɹ�����Ϣ
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