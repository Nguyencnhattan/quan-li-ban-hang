using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

namespace BanHang
{
    public partial class Product : System.Web.UI.Page
    {
        String conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Asp.net\BanHang\BanHang\App_Data\QLBanHang.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string query;
            if (Context.Items["ml"] == null)
                query = "SELECT * FROM SanPham";
            else
            {
                string maloai = Context.Items["ml"].ToString();
                query = "SELECT * FROM SanPham WHERE MaLoai = '" + maloai + "'";
            }
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();
                
            } catch (SqlException ex) 
            {
                Response.Write(ex.Message);
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Context.Items["mh"] = mahang;
            Server.Transfer("ProductDetail.aspx");
        }
    }
}