using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;

namespace DAL
{
    public class ScoreListService
    {

        #region "成绩查询"

        /// <summary>
        /// 根据班级查询考试成绩列表
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public List<StudentExt> GetScoreList(string className)
        {
            var sql = " select s.StudentId,StudentName,ClassName,CSharp,SQLServerDB from Students s ";
            sql += " inner join StudentClass sc On s.ClassId = sc.ClassId ";
            sql += " inner join ScoreList sl On s.StudentId = sl.StudentId ";

            if (className?.Length > 0)
            {
                sql += $"where ClassName = {className}";
            }

            SqlDataReader objReader = SQLHelper.GetReader(sql);
            var list = new List<StudentExt>();
            while (objReader.Read())
            {
                list.Add(new StudentExt()
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = Convert.ToString(objReader["StudentName"]),
                    ClassName = Convert.ToString(objReader["ClassName"]),
                    CSharp = Convert.ToInt32(objReader["CSharp"]),
                    SQLServerDB = Convert.ToInt32(objReader["SQLServerDB"]),

                });
            }

            objReader.Close();
            return list;

        }

        /// <summary>
        /// 获取全部考试的统计信息
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetScoreInfo()
        {

            var sql = "select stuCount=count(*),avgCSharp=avg(CSharp),avgDB=avg(SQLServerDB) from ScoreList;";
            sql += "select absentCount=count(*) from Students where StudentId not in(select StudentId from ScoreList)";
            var scoreInfo = new Dictionary<string, string>();
            var objReader = SQLHelper.GetReader(sql);

            if (objReader.Read())
            {
                scoreInfo.Add("stuCount", objReader["stuCount"].ToString());
                scoreInfo.Add("avgCSharp", objReader["avgCSharp"].ToString());
                scoreInfo.Add("avgDB", objReader["avgDB"].ToString());
            }

            if (objReader.NextResult() && objReader.Read())
            {
                scoreInfo.Add("absentCount", objReader["absentCount"].ToString());
            }

            objReader.Close();
            return scoreInfo;
        }

        /// <summary>
        /// 获取所有未参加考试的学员名单
        /// </summary>
        /// <returns></returns>
        public List<string> GetAbsentList()
        {
            var sql = "select StudentName from Students where StudentId not in (select StudentId from ScoreList) ";
            var objReader = SQLHelper.GetReader(sql);
            var list = new List<string>();
            while (objReader.Read())
            {
                list.Add(objReader["StudentName"].ToString());
            }

            objReader.Close();
            return list;
        }

        #endregion

        #region "基于数据集Dataset的数据查询"

        /// <summary>
        /// 获取所有考试信息
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllScoreList() => SQLHelper.GetDataSet(" select s.StudentId,StudentName,ClassName,CSharp,SQLServerDB " +
                                                                    " from Students s " +
                                                                    " inner join StudentClass sc On s.ClassId = sc.ClassId" +
                                                                    " inner join ScoreList sl On s.StudentId = sl.StudentId ");


        #endregion


    }
}
