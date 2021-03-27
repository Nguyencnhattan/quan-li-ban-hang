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
    public partial class ShoppingCart : System.Web.UI.Page
    {
        String conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Asp.net\BanHang\BanHang\App_Data\QLBanHang.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string query;
            query = "SELECT DonHang.MaSP, TenSP, mota, Gia, Soluong, soluong*Gia as thanhtien FROM SanPham, donhang WHERE SanPham.MaSP = donhang.MaSP";
            
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.GridView1.DataSource = dt;
                this.GridView1.DataBind();
                double tong = 0;
                foreach(DataRow row in dt.Rows)
                {
                    double thanhtien = Convert.ToDouble(row["thanhtien"]);
                    tong += thanhtien;
                }
                this.Label1.Text = "Tổng tiền thanh toán: " + tong + " đồng";
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}