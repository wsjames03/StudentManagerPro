using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using Models.Models;

namespace DAL
{
    /// <summary>
    /// 班级数据访问类
    /// </summary>
    public class StudentClassService
    {

        /// <summary>
        /// 获取所有的班级对象
        /// </summary>
        /// <returns></returns>
        public List<StudentClass> GetAllClasses()
        {
            var sql = "select ClassName,ClassId from StudentClass";
            SqlDataReader objDataReader = SQLHelper.GetReader(sql);
            var list = new List<StudentClass>();
            while (objDataReader.Read())
            {
                list.Add(new StudentClass()
                {
                    ClassId = Convert.ToInt32(objDataReader["ClassId"]),
                    ClassName = Convert.ToString(objDataReader["ClassName"])
                });
            }

            objDataReader.Close();
            return list;
        }

        /// <summary>
        /// 获取所有的班级对象_DataSet
        /// </summary>
        /// <returns></returns>
        public DataSet GetAllClasses_DS() => SQLHelper.GetDataSet("select ClassName,ClassId from StudentClass");

    }
}
