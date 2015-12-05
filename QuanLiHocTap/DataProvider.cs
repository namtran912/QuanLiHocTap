using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class DataProvider
    {
        private static SqlConnection sqlcnt = null;

        static DataProvider()
        {
            sqlcnt = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\hoc\PTTKPM\ZZZZZZZZ\QuanLiHocTap\QuanLiHocTap\QuanLiHocTap.mdf;Integrated Security=True;Connect Timeout=30");
        }

        public static DataTable ExecuteQuery(string query)
        {
            DataTable dtTable = new DataTable();

            try
            {
                sqlcnt.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcnt;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dtTable);
            }
            catch (Exception ex)
            {
                throw new Exception("Error execute query: " + ex.Message);
            }
            finally
            {
                sqlcnt.Close();
            }

            return dtTable;
        }

        public static void ExecuteNonQuery(string query)
        {
            try
            {
                sqlcnt.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = sqlcnt;
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Error execute non-query: " + ex.Message);
            }
            finally
            {
                sqlcnt.Close();
            }
        }
    }
}