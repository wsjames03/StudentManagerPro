using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;
using Models;
using Models.Models;

namespace StudentManager
{
    public partial class FrmStudentManage : Form
    {
        private readonly StudentClassService objClassService = new StudentClassService();
        private readonly StudentService objStudentService = new StudentService();

        public FrmStudentManage()
        {
            InitializeComponent();
            //��ʼ���༶������
            this.cboClass.DataSource = objClassService.GetAllClasses();
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;  //Ĭ�ϲ�ѡ��
        }
        //���հ༶��ѯ
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex < 0)
            {
                MessageBox.Show("��ѡ��༶", "��ʾ��Ϣ");
                return;
            }

            //ִ�в�ѯ
            this.dgvStudentList.AutoGenerateColumns = false;
            this.dgvStudentList.DataSource = objStudentService.GetClassByClass(this.cboClass.Text);

        }
        //����ѧ�Ų�ѯ
        private void btnQueryById_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(this.txtStudentId.Text))
            {
                MessageBox.Show("������ѧ�ţ�", "��ʾ��Ϣ");
                this.txtStudentId.Focus();
                return;
            }

            //��һ����֤ѧ���Ƿ�������(��ʹ������)

            var objStudent = objStudentService.GetStudentById(this.txtStudentId.Text.Trim());
            if (objStudent == null)
            {
                MessageBox.Show("ѧԱ��Ϣ�����ڣ�", "��ʾ��Ϣ");
                this.txtStudentId.Focus();
                return;
            }
            else
            {
                //��ѧԱ��ϸ��Ϣ������ʾ
                FrmStudentInfo objFrmStudentInfo = new FrmStudentInfo(objStudent);
                objFrmStudentInfo.Show();
            }
        }
        private void txtStudentId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13 && !string.IsNullOrWhiteSpace(this.txtStudentId.Text))
            {
                btnQueryById_Click(null, null);
            }
        }
        //˫��ѡ�е�ѧԱ������ʾ��ϸ��Ϣ
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvStudentList.CurrentRow != null)
            {
                //��ȡѧ��
                var studentID = this.dgvStudentList.CurrentRow.Cells["StudentID"].Value.ToString();
                this.txtStudentId.Text = studentID;
                btnQueryById.PerformClick();
            }
        }
        //�޸�ѧԱ����
        private void btnEidt_Click(object sender, EventArgs e)
        {

            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("û���κ�Ҫ�޸ĵ�ѧԱ��Ϣ��", "��ʾ��Ϣ");
                return;
            }

            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("��ѡ��Ҫ�޸ĵ�ѧԱ��Ϣ��", "��ʾ��Ϣ");
                return;
            }

            //��ȡѧ��
            var studentID = this.dgvStudentList.CurrentRow.Cells["StudentID"].Value.ToString();

            //��ȡ��Ҫ�޸ĵ�ѧԱ����ϸ��Ϣ
            var objStudent = objStudentService.GetStudentById(studentID);

            //��ʾҪ�޸ĵ�ѧԱ��Ϣ����
            FrmEditStudent objEditStudent = new FrmEditStudent(objStudent);
            var result = objEditStudent.ShowDialog();
            if (result == DialogResult.OK)
            {
                //�ʺ�������С��ʱ���ѯ
                this.btnQuery.PerformClick();
            }
        }
        //ɾ��ѧԱ����
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("û���κ�Ҫɾ����ѧԱ��Ϣ��", "��ʾ��Ϣ");
                return;
            }

            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("��ѡ��Ҫɾ����ѧԱ��Ϣ��", "��ʾ��Ϣ");
                return;
            }
            var studentName = this.dgvStudentList.CurrentRow.Cells["StudentName"].Value.ToString();
            var result = MessageBox.Show($"ȷ��Ҫɾ��ѧԱ [{studentName}] ��", "ɾ��ѯ��", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK) return;

            //��ȡѧ��
            var studentID = this.dgvStudentList.CurrentRow.Cells["StudentID"].Value.ToString();
            try
            {
                if (objStudentService.DeleteStudentById(studentID) == 1)
                {
                    //�ʺ�������С��ʱ���ѯ
                    this.btnQuery.PerformClick();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "��ʾ��Ϣ");
            }
        }
        private void FrmSearchStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmStudentManage = null;
        }
        //�ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiModifyStu_Click(object sender, EventArgs e)
        {
            btnEidt_Click(null, null);
        }
    }
}