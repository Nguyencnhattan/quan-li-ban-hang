using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BanHang
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        String conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Asp.net\BanHang\BanHang\App_Data\QLBanHang.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string query;
            if (Context.Items["mh"] == null)
                query = "SELECT * FROM SanPham";
            else
            {
                string maloai = Context.Items["mh"].ToString();
                query = "SELECT * FROM SanPham WHERE MaSP = '" + maloai + "'";
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Button mua = (Button)sender;
            string mahang = mua.CommandArgument.ToString();
            DataListItem item = (DataListItem)mua.Parent;
            string soluong = ((TextBox)item.FindControl("TextBox1")).Text;
            if (Request.Cookies["TenDN"] == null) return;
            string ten = Request.Cookies["TenDN"].Value;
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "SELECT * FROM donhang WHERE TenDN='" + ten + "' and MaSP='" + mahang + "'";
            SqlCommand command = new SqlCommand(query, con);
            SqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                query = "UPDATE donhang SET soluong=soluong+" + soluong + " WHERE TenDN='" + ten + "' and MaSP='" + mahang + "'";
            }
            else
            {
                query = "INSERT INTO donhang VALUES(" + mahang + ", '" + ten + "', " + soluong + ");";
            }
            reader.Close();
            command = new SqlCommand(query, con);
            command.ExecuteNonQuery();
            con.Close();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Server.Transfer("ShoppingCart.aspx");
        }
    }
}