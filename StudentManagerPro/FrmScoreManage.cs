using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DAL;

namespace StudentManager
{
    public partial class FrmScoreManage : Form
    {

        private ScoreListService objScoreListService = new ScoreListService();


        public FrmScoreManage()
        {
            InitializeComponent();

        }
        //根据班级查询      
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //关闭
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //统计全校考试成绩
        private void btnStat_Click(object sender, EventArgs e)
        {
            this.gbStat.Text = "全校考试成绩统计";

            //查询成绩列表
            this.dgvScoreList.AutoGenerateColumns = false;
            this.dgvScoreList.DataSource = objScoreListService.GetScoreList(string.Empty);

            //查询并显示成绩统计
            var dic = objScoreListService.GetScoreInfo();
            this.lblAttendCount.Text = dic["stuCount"];
            this.lblCSharpAvg.Text = dic["avgCSharp"];
            this.lblDBAvg.Text = dic["avgDB"];
            this.lblCount.Text = dic["absentCount"];

            //显示缺考的人员的姓名
            var list = objScoreListService.GetAbsentList();
            this.lblList.Items.Clear();
            this.lblList.Items.AddRange(list.ToArray());
        }
    }
}