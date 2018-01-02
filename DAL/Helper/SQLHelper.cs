using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; 

namespace DAL.Helper
{
    public abstract class SQLHelper
    {
        public static readonly string connstring = ConfigurationManager.AppSettings["SQLConnString1"];

        public static object getsigle(string sql)
        {
            SqlConnection sqlconn = new SqlConnection(connstring);
            sqlconn.Open();
            SqlCommand sqlcom = new SqlCommand(sql, sqlconn);
            try
            {
                object sqldata = sqlcom.ExecuteScalar();
                return sqldata;
            }
            catch (Exception ex)
            {

                throw new Exception("发生了数据库的错误" + ex.Message);
            }
            finally
            {
                sqlconn.Close();
            }
        }
    }
}   
