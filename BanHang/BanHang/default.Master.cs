using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Data;
using System.Diagnostics;

namespace BanHang
{
    public partial class _default : System.Web.UI.MasterPage
    {
            String conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Asp.net\BanHang\BanHang\App_Data\QLBanHang.mdf;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            try
            {
                string q = "select * from Loai";
                SqlDataAdapter da = new SqlDataAdapter(q, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Debug.Print(ex.ToString());
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string maloai = ((LinkButton)sender).CommandArgument;

            Context.Items["ml"] = maloai;
            Server.Transfer("Product.aspx");
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string ten = this.Login1.UserName;
            string matkhau = this.Login1.Password;
            string sql = "select * from KhachHang where TenDN='" + ten + "' and MatKhau = '" + matkhau + "'";
            DataTable table = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(table);
            }
            catch (SqlException err)
            {
                Response.Write("<b>Error</b>" + err.Message + "<p/>");
            }
            if (table.Rows.Count != 0)
            {
                Response.Cookies["TenDN"].Value = ten;
                Server.Transfer("Product.aspx");
            }
            else this.Login1.FailureText = "Tên đăng nhập hay mật khẩu không đúng!";
        }
    }
}