using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

using System.Configuration;//引入读取配置文件的命名空间

namespace DAL
{
    /// <summary>
    /// 通用数据访问类
    /// </summary>
    public class SQLHelper
    {
        // private static readonly string ConnString = "Server=127.0.0.1,1433;DataBase=SMDB;Uid=sa;Pwd=zq123456";
        private static readonly string ConnString = Common.StringSecurity.DESDecrypt(ConfigurationManager.ConnectionStrings["connString"].ToString());

        /// <summary>
        /// 执行增删改的方法
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Update(string sql)
        {
            var conn = new SqlConnection(ConnString);
            var cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                //TODO:将错误信息写入日志..
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        /// <summary>
        /// 返回单一结果插叙
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static object GetSingleResult(string sql)
        {

            var conn = new SqlConnection(ConnString);
            var cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                //TODO:将错误信息写入日志..
                throw;
            }
            finally
            {
                conn.Close();
            }

        }

        /// <summary>
        /// 执行结果集查询
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetReader(string sql)
        {

            var conn = new SqlConnection(ConnString);
            var cmd = new SqlCommand(sql, conn);

            try
            {
                conn.Open();
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                conn.Close();
                //TODO:将错误信息写入日志..
                throw;
            }

        }

        /// <summary>
        /// 执行查询返回一个DataSet
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataSet GetDataSet(string sql)
        {
            var conn = new SqlConnection(ConnString);
            var cmd = new SqlCommand(sql, conn);
            var da = new SqlDataAdapter(cmd);  //创建数据适配器对象
            var ds = new DataSet();            //创建一个内存数据集

            try
            {
                conn.Open();
                da.Fill(ds);//创建一个内存数据集
                return ds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                conn.Close();
                //TODO:将错误信息写入日志..
                throw;
            }

        }

    }
}
