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

            //��ʼ���༶������
            this.cboClassName.DataSource = objClassService.GetAllClasses();
            this.cboClassName.DisplayMember = "ClassName";
            this.cboClassName.ValueMember = "ClassId";
            this.cboClassName.SelectedIndex = -1;  //Ĭ�ϲ�ѡ��

        }

        //�����ѧԱ
        private void btnAdd_Click(object sender, EventArgs e)
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
            if (objStudentService.isIdNoExisted(this.txtStudentIdNo.Text.Trim(), string.Empty))
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

            //���ú�̨���ݷ��ʷ���,��Ӷ���
            try
            {
                if (objStudentService.AddStudent(objStudent) == 1)
                {
                    var result = MessageBox.Show("��ѧԱ��ӳɹ����Ƿ�������?", "��ʾ��Ϣ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes) //����û�������
                    {
                        this.cboClassName.SelectedIndex = -1;
                        this.rdoFemale.Checked = false;
                        this.rdoMale.Checked = false;
                        //����ı���
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

        //�رմ���
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //�����Ѿ����ر�
        private void FrmAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmAddStudent = null;  //���������رյ�ʱ��,���
        }
    }
}