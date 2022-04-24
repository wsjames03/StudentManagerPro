using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            //��ʾ��¼�û���
            this.lblCurrentUser.Text = (Program.objCurrentAdmin?.AdminName ?? string.Empty) + " ]";

        }


        ////��ʾ���ѧԱ����
        //private void tsmiAddStudent_Click(object sender, EventArgs e)
        //{
        //    FrmAddStudent objAddStudent = new FrmAddStudent();
        //    objAddStudent.ShowDialog();
        //}

        public static FrmAddStudent objFrmAddStudent = null;

        private void tsmiAddStudent_Click(object sender, EventArgs e)
        {
            if (objFrmAddStudent == null)
            {
                objFrmAddStudent = new FrmAddStudent();
                objFrmAddStudent.Show();
            }
            else
            {
                objFrmAddStudent.Activate();//����ֻ������С����ʱ��������
                objFrmAddStudent.WindowState = FormWindowState.Normal;
            }

        }

        public static FrmStudentManage objFrmStudentManage = null;
        private void tsmiManageStudent_Click(object sender, EventArgs e)
        {
            if (objFrmStudentManage == null)
            {
                objFrmStudentManage = new FrmStudentManage();
                objFrmStudentManage.Show();
            }
            else
            {
                objFrmStudentManage.Activate();//����ֻ������С����ʱ��������
                objFrmStudentManage.WindowState = FormWindowState.Normal;
            }
        }

        //��ʾ�ɼ���ѯ���������    
        public static FrmScoreManage ObjFrmScoreManage = null;

        private void tsmiQueryAndAnalysis_Click(object sender, EventArgs e)
        {
            if (ObjFrmScoreManage == null)
            {
                ObjFrmScoreManage = new FrmScoreManage();
                ObjFrmScoreManage.Show();
            }
            else
            {
                ObjFrmScoreManage.Activate();//����ֻ������С����ʱ��������
                ObjFrmScoreManage.WindowState = FormWindowState.Normal;
            }
        }
        //�˳�ϵͳ
        private void tmiClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //��ʾ�ɼ���ѯ���������    
        public static FrmScoreQuery ObjFrmScoreQuery = null;
        
        //�ɼ����ٲ�ѯ
        private void tsmiQuery_Click(object sender, EventArgs e)
        {
            if (ObjFrmScoreQuery == null)
            {
                ObjFrmScoreQuery = new FrmScoreQuery();
                ObjFrmScoreQuery.Show();
            }
            else
            {
                ObjFrmScoreQuery.Activate();//����ֻ������С����ʱ��������
                ObjFrmScoreQuery.WindowState = FormWindowState.Normal;
            }
        }
        //�����޸�
        private void tmiModifyPwd_Click(object sender, EventArgs e)
        {

        }

        private void tsbAddStudent_Click(object sender, EventArgs e)
        {
            tsmiAddStudent_Click(null, null);
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tsmiManageStudent_Click(null, null);
        }
        private void tsbScoreAnalysis_Click(object sender, EventArgs e)
        {
            tsmiQueryAndAnalysis_Click(null, null);
        }
        private void tsbModifyPwd_Click(object sender, EventArgs e)
        {
            tmiModifyPwd_Click(null, null);
        }
        private void tsbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void tsbQuery_Click(object sender, EventArgs e)
        {
            tsmiQuery_Click(null, null);
        }

        private void tsmi_Card_Click(object sender, EventArgs e)
        {

        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("ȷ���˳���", "�˳�ѯ��", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK)
            {
                //ȡ����ǰ�Ĺرղ���
                e.Cancel = true;
            }
        }


    }
}