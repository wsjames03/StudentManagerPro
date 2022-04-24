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
            //初始化班级下拉框
            this.cboClass.DataSource = objClassService.GetAllClasses();
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            this.cboClass.SelectedIndex = -1;  //默认不选择
        }
        //按照班级查询
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.cboClass.SelectedIndex < 0)
            {
                MessageBox.Show("请选择班级", "提示信息");
                return;
            }

            //执行查询
            this.dgvStudentList.AutoGenerateColumns = false;
            this.dgvStudentList.DataSource = objStudentService.GetClassByClass(this.cboClass.Text);

        }
        //根据学号查询
        private void btnQueryById_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(this.txtStudentId.Text))
            {
                MessageBox.Show("请输入学号！", "提示信息");
                this.txtStudentId.Focus();
                return;
            }

            //进一步验证学号是否是数字(请使用正则)

            var objStudent = objStudentService.GetStudentById(this.txtStudentId.Text.Trim());
            if (objStudent == null)
            {
                MessageBox.Show("学员信息不存在！", "提示信息");
                this.txtStudentId.Focus();
                return;
            }
            else
            {
                //在学员详细信息窗体显示
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
        //双击选中的学员对象并显示详细信息
        private void dgvStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvStudentList.CurrentRow != null)
            {
                //获取学号
                var studentID = this.dgvStudentList.CurrentRow.Cells["StudentID"].Value.ToString();
                this.txtStudentId.Text = studentID;
                btnQueryById.PerformClick();
            }
        }
        //修改学员对象
        private void btnEidt_Click(object sender, EventArgs e)
        {

            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("没有任何要修改的学员信息！", "提示信息");
                return;
            }

            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("请选中要修改的学员信息！", "提示信息");
                return;
            }

            //获取学号
            var studentID = this.dgvStudentList.CurrentRow.Cells["StudentID"].Value.ToString();

            //获取需要修改的学员的详细信息
            var objStudent = objStudentService.GetStudentById(studentID);

            //显示要修改的学员信息窗口
            FrmEditStudent objEditStudent = new FrmEditStudent(objStudent);
            var result = objEditStudent.ShowDialog();
            if (result == DialogResult.OK)
            {
                //适合数据量小的时候查询
                this.btnQuery.PerformClick();
            }
        }
        //删除学员对象
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (this.dgvStudentList.RowCount == 0)
            {
                MessageBox.Show("没有任何要删除的学员信息！", "提示信息");
                return;
            }

            if (this.dgvStudentList.CurrentRow == null)
            {
                MessageBox.Show("请选中要删除的学员信息！", "提示信息");
                return;
            }
            var studentName = this.dgvStudentList.CurrentRow.Cells["StudentName"].Value.ToString();
            var result = MessageBox.Show($"确认要删除学员 [{studentName}] 吗？", "删除询问", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result != DialogResult.OK) return;

            //获取学号
            var studentID = this.dgvStudentList.CurrentRow.Cells["StudentID"].Value.ToString();
            try
            {
                if (objStudentService.DeleteStudentById(studentID) == 1)
                {
                    //适合数据量小的时候查询
                    this.btnQuery.PerformClick();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show(exception.Message, "提示信息");
            }
        }
        private void FrmSearchStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain.objFrmStudentManage = null;
        }
        //关闭
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