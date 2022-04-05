using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataBaseContentExample.src
{
    internal static class DataService
    {
        public static SqlConnection CreateConnection()
        {

            SqlConnection c = new SqlConnection();
            c.ConnectionString = "Data Source=(local)\\DartNET;Initial Catalog=testDB;Persist Security Info=True;User ID=sa;Password=junak";

            return c;
        }
        public static object SetQuery(string sql, IDataBase db)
        {
            SqlDataReader r = null;
            using (SqlConnection conn = CreateConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand c = new SqlCommand(sql, conn);
                    r = c.ExecuteReader();

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"SetQuery{ex.Message}");
                }
                return db.DbReader(r);
            }

        }
        public static int GetDataSQLNonQuery(string sql)
        {
            int r = 0;
            using (SqlConnection conn = CreateConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand c = new SqlCommand(sql, conn);
                    r = c.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message + conn.ConnectionString, "GetDataSQLScalar");
                }

            }

            return r;
        }
        public static object GetDataSQLScalar(string sql)
        {
            object r = null;
            using (SqlConnection conn = CreateConnection())
            {
                try
                {
                    conn.Open();
                    SqlCommand c = new SqlCommand(sql, conn);
                    r = c.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message + conn.ConnectionString, "GetDataSQLScalar");
                }
            }
            return r;
        }
    }
    public interface IDataBase
    {
        object DbReader(IDataReader rd);
    }
}
