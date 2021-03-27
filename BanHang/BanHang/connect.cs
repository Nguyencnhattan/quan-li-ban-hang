using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace BanHang
{
    public class connect
    {
        private SqlConnection con;

        public connect()

        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=G:\ASP.NET\Final\BanHang\BanHang\App_Data\QLBanHang.mdf;Integrated Security=True");
        }

        private void OpenConnection()
        {
            con.Open();
        }

        private void CloseConnection()
        {
            if (con.State == ConnectionState.Open) //nếu kết nối đang mở
            {
                con.Close();
            }
        }

        public int ChangeData(String query)
        {
            int kq = 0;
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, con);
                kq = command.ExecuteNonQuery();
            }
            catch
            {
                kq = 0;
            }
            finally
            {
                CloseConnection();
            }
            return kq;
        }

        public DataTable GetData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnection();
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                adapter.Fill(dt);
            }
            catch
            {
                dt = null;
            }
            finally
            {
                CloseConnection();
            }
            return dt;
        }
    }
}
