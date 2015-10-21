using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using Sample.ClassLib;

namespace Sample.ClassLib.Repository
{
    public class BaseRepository
    {
        public static string ExecuteNonQuery(SqlCommand cmd)
        {
            string result;
            SqlConnection conn = null;

            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SIXSDB"].ConnectionString);
                cmd.Connection = conn;
                conn.Open();
                result = Convert.ToString(cmd.ExecuteNonQuery());
                conn.Close();
                result = "Information has been added into the system.";
            }
            catch (Exception ex)
            {
                result = ex.Message + " " + ex.StackTrace;
            }
            return result;
        }

        public static DataTable ExecuteNonQueryReturn(SqlCommand cmd)
        {
            SqlConnection conn = null;
            DataTable dt = new DataTable();
            try
            {
                conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SIXSDB"].ConnectionString);
                cmd.Connection = conn;
                conn.Open();

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                AppData.Instance.customer.StoredProcResult = ex.Message + " " + ex.StackTrace;
            }
            return dt;
        }

    }
}