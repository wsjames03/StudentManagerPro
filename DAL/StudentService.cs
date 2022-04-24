using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Models.Models;

namespace DAL
{
    /// <summary>
    /// 学院信息数据访问类
    /// </summary>
    public class StudentService
    {
        #region "添加学员对象"

        /// <summary>
        /// 判断当前身份证号是否已经存在,其他学员是否重复
        /// </summary>
        /// <param name="studentIdNo"></param>
        /// <returns></returns>
        public bool isIdNoExisted(string studentIdNo, string studentId)
            => Convert.ToInt32(SQLHelper.GetSingleResult($"select count(*) from students where studentIdNo = {studentIdNo} And studentId<>{studentId}")) == 1;

        /// <summary>
        /// 添加学员
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int AddStudent(StudentExt objStudent)
        {

            //1.编写sql语句,解析对象
            var sqlBuilder = new StringBuilder();
            sqlBuilder.Append("INSERT INTO Students( StudentName, Gender, Birthday, StudentIdNo, CardNo, StuImage, Age, PhoneNumber, StudentAddress, ClassId) ");
            sqlBuilder.Append($"VALUES( '{objStudent.StudentName}','{objStudent.Gender}','{objStudent.Birthday}','{objStudent.StudentIdNo}', ");
            sqlBuilder.Append($" '{objStudent.CardNo}', '{objStudent.StuImage}', '{objStudent.Age}', '{objStudent.PhoneNumber}', '{objStudent.StudentAddress}','{objStudent.ClassId}' )");

            //2.提交到数据库
            try
            {
                return SQLHelper.Update(sqlBuilder.ToString());
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw new Exception("数据库操作出现异常！具体信息：" + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        #endregion

        #region "查询学员"
        /// <summary>
        /// 根据班级获取学生
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public List<StudentExt> GetClassByClass(string className)
        {
            var list = new List<StudentExt>();
            var sql = "select StudentName,StudentID,Gender,Birthday,ClassName from Students ";
            sql += " inner join StudentClass on Students.ClassId = StudentClass.ClassId ";
            sql += $" where ClassName = '{className}' ";

            var objReader = SQLHelper.GetReader(sql);
            while (objReader.Read())
            {
                list.Add(new StudentExt
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = Convert.ToString(objReader["StudentName"]),
                    Gender = Convert.ToString(objReader["Gender"]),
                    Birthday = Convert.ToDateTime(objReader["Birthday"]),
                    ClassName = Convert.ToString(objReader["ClassName"])
                });
            }

            return list;
        }

        /// <summary>
        /// 根据学号查询学员对象
        /// </summary>
        /// <param name="studentID"></param>
        /// <returns></returns>
        public StudentExt GetStudentById(string studentID)
        {
            var sql = "select Students.*,StudentClass.ClassName FROM Students " +
                      "inner join StudentClass on Students.ClassId = StudentClass.ClassId " +
                      $"where Students.studentID = '{studentID}' ";

            var objReader = SQLHelper.GetReader(sql);
            StudentExt objStudent = null;
            if (objReader.Read())
            {
                objStudent = new StudentExt()
                {
                    StudentId = Convert.ToInt32(objReader["StudentId"]),
                    StudentName = Convert.ToString(objReader["StudentName"]),
                    Gender = Convert.ToString(objReader["Gender"]),
                    Age = Convert.ToInt32(objReader["Age"]),
                    Birthday = Convert.ToDateTime(objReader["Birthday"]),
                    ClassName = Convert.ToString(objReader["ClassName"]),
                    CardNo = Convert.ToString(objReader["CardNo"]),
                    StudentIdNo = Convert.ToString(objReader["StudentIdNo"]),
                    PhoneNumber = Convert.ToString(objReader["PhoneNumber"]),
                    StudentAddress = Convert.ToString(objReader["StudentAddress"]),
                };
            }

            objReader.Close();
            return objStudent;
        }

        #endregion

        #region "修改学员对象"

        /// <summary>
        /// 修改学员对象
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int ModifyStudent(Student objStudent)
        {
            var sqlBuilder = new StringBuilder();
            sqlBuilder.Append($"Update Students set StudentName='{objStudent.StudentName}',");
            sqlBuilder.Append($"Gender='{objStudent.Gender}',Age='{objStudent.Age}',");
            sqlBuilder.Append($"Birthday='{objStudent.Birthday}',CardNo='{objStudent.CardNo}',");
            sqlBuilder.Append($"StudentIdNo='{objStudent.StudentIdNo}',PhoneNumber='{objStudent.PhoneNumber}',");
            sqlBuilder.Append($"StudentAddress='{objStudent.StudentAddress}',ClassId='{objStudent.ClassId}' ");
            sqlBuilder.Append($"where StudentId ='{objStudent.StudentId}'");

            try
            {
                return SQLHelper.Update(sqlBuilder.ToString());
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                throw new Exception("数据库操作出现异常！具体信息：" + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        #endregion

        #region "删除学员对象"

        public int DeleteStudentById(string studentID)
        {
            try
            {
                return SQLHelper.Update($"delete from students where studentId={studentID}");
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                if (ex.Number == 547)
                    throw new Exception("该学号被其他数据表引用，不能直接删除！不能直接删除该学员对象");
                else
                    throw new Exception("数据库操作出现异常！具体信息：" + ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        // => SQLHelper.Update($"delete from students where studentId={studentID}");

        #endregion
    }
}
