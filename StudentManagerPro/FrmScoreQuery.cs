using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DAL;
using Models;
using Models.Models;

namespace StudentManager
{
    public partial class FrmScoreQuery : Form
    {
        private readonly StudentClassService objClassService = new StudentClassService();
        private readonly ScoreListService objScoreListService = new ScoreListService();
        private readonly DataTable dtScoreList = null;
        public FrmScoreQuery()
        {
            InitializeComponent();
            //初始化班级下拉框
            var dt = objClassService.GetAllClasses_DS().Tables?[0];

            this.cboClass.DataSource = dt;
            this.cboClass.DisplayMember = "ClassName";
            this.cboClass.ValueMember = "ClassId";
            // this.cboClass.SelectedIndex = -1;  //默认不选择
            dtScoreList = objScoreListService.GetAllScoreList().Tables[0];
            //显示全部考试成绩
            this.dgvScoreList.DataSource = dtScoreList;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //根据班级名称动态筛选
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dtScoreList == null) return;
            this.dtScoreList.DefaultView.RowFilter = $" ClassName = '{this.cboClass.Text.Trim()}'";

        }
        //显示全部成绩
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (dtScoreList == null) return;
            this.dtScoreList.DefaultView.RowFilter = $" 1 = 1 ";
        }
        //根据C#成绩动态筛选
        private void txtScore_TextChanged(object sender, EventArgs e)
        {
            if (dtScoreList == null) return;
            if (this.txtScore.Text.Trim().Length == 0) return;
            if (!Common.DataValidate.IsInteger(this.txtScore.Text.Trim())) return;
            this.dtScoreList.DefaultView.RowFilter = $" CSharp > {this.txtScore.Text.Trim()} ";
        }
    }
}

//测试选定的班级名称对应的班级编号
//MessageBox.Show(this.cboClass.SelectedValue.ToString(), "班级ID");