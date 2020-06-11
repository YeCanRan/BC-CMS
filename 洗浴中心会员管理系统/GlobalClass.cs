using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace 洗浴中心会员管理系统
{
    class GlobalClass
    {
        public static string StrCnn;
        public static string UserName;
        public static string EmployeeNo="100000";
        public static int PrivilegeLevel;
        public enum Privilege{ Administrator, Director, Manager , Reception, Logistics, Staff };
        public static SqlConnection Connection = new SqlConnection();
        public static string MD5(string String)
        {
            MD5 MD5 = new MD5CryptoServiceProvider();
            byte[] TargetData = MD5.ComputeHash(Encoding.UTF8.GetBytes(String));
            string Value = null;
            for (int i = 0; i < TargetData.Length; i++)
                Value += TargetData[i].ToString("x2");
            return Value.ToUpper();
        }
    }
}