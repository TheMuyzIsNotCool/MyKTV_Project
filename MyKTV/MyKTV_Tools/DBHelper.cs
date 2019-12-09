using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyKTV_Tools
{
    public class DBHelper
    {
        private static string connStr = "server=.;database=SuperKTV;uid=***;pwd=***";

        public static SqlDataReader dr;

        public static SqlConnection conn;

        public static object getScalar(string sqlStr)
        {
            Object result = -1;
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cm = new SqlCommand(sqlStr, conn);
            result = cm.ExecuteScalar();
            conn.Close();
            return result;
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sqlStr">SQL语句【增删改】</param>
        /// <returns>影响行数</returns>
        public static int getNonQuery(string sqlStr)
        {
            int result = -1;
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cm = new SqlCommand(sqlStr, conn);
            result = cm.ExecuteNonQuery();
            conn.Close();
            return result;
        }

        public static SqlDataReader GetReader(string sqlStr)
        {
            conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            dr = cmd.ExecuteReader();
            return dr;
        }

        /// <summary>
        /// 查询一张表
        /// </summary>
        /// <param name="sqlStr">SQL语句【select】</param>
        /// <returns>查询表的DataTable结果</returns>
        public static DataTable getTable(string sqlStr)
        {
            DataTable result = null;
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sqlStr, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            result = ds.Tables[0];
            conn.Close();
            return result;
        }
    }
}
