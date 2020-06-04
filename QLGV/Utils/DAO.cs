using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGV.Utils
{
    public static class DAO
    {
        public static string sqlConnectionString = string.Empty;
        //  string sqlConnectionString = "Data Source=10.8.5.114;Initial Catalog=LEMON5;User ID=sa;Password=Abc123456;Persist Security Info=True";
        public static void SetConnnectionString(string serverName, string cataLog, string userName, string password)
        {
            string sqlConnectionStrFormat = "Data Source={0};Initial Catalog={1};User ID={2};Password={3};Persist Security Info=True";
            sqlConnectionString = string.Format(sqlConnectionStrFormat, serverName, cataLog, userName,password);
        }

        public static bool IsConnect()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sqlConnectionString))
                {
                    connection.Open();
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khi mo  ket noi: " + ex.Message);
            }
            return false;
        }
    }
}
