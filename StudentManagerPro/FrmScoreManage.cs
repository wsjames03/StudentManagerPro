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
        //���ݰ༶��ѯ      
        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //�ر�
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //ͳ��ȫУ���Գɼ�
        private void btnStat_Click(object sender, EventArgs e)
        {
            this.gbStat.Text = "ȫУ���Գɼ�ͳ��";

            //��ѯ�ɼ��б�
            this.dgvScoreList.AutoGenerateColumns = false;
            this.dgvScoreList.DataSource = objScoreListService.GetScoreList(string.Empty);

            //��ѯ����ʾ�ɼ�ͳ��
            var dic = objScoreListService.GetScoreInfo();
            this.lblAttendCount.Text = dic["stuCount"];
            this.lblCSharpAvg.Text = dic["avgCSharp"];
            this.lblDBAvg.Text = dic["avgDB"];
            this.lblCount.Text = dic["absentCount"];

            //��ʾȱ������Ա������
            var list = objScoreListService.GetAbsentList();
            this.lblList.Items.Clear();
            this.lblList.Items.AddRange(list.ToArray());
        }
    }
}