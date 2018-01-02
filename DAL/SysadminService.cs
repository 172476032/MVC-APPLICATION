using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using Models;
using DAL.Helper;
using System.Web;

namespace DAL
{
    public class SysadminService
    {
        public Sysadmin GetAdmin( Sysadmin admin) {
            string sql = "select AdminName from Admins where Loginid ={0} and LoginPwd = {1} ";
            string.Format(sql,admin.SysadminID,admin.SysadminPassword);
            admin.SysadminName = SQLHelper.getsigle(sql).ToString();
            HttpContext.Current.Session["admin"] = admin;
            return admin;
        }
    } 
}
