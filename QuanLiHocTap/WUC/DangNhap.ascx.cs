using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiHocTap
{
    public partial class Login : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] == null || (bool)Session["isLogin"] == false)
                setLogin(true); 
            else
                setLogin(false);
        }

        private void setLogin(bool flag)
        {
            if (flag)
            {
                Label_MSSV.Text = "";
                Button_DangNhap.Visible = true;
                Button_DangKy.Visible = true;
                Label_MSSVDN.Visible = true;
                Label_MatKhauDN.Visible = true;
                TextBox_MSSV.Visible = true;
                TextBox_MatKhau.Visible = true;
                Label_MSSV.Visible = false;
                Button_DangXuat.Visible = false;
            }
            else
            {
                Label_MSSV.Text = "Xin chào, " + Session["MSSV"].ToString();
                Button_DangNhap.Visible = false;
                Button_DangKy.Visible = false;
                Label_MSSVDN.Visible = false;
                Label_MatKhauDN.Visible = false;
                TextBox_MSSV.Visible = false;
                TextBox_MatKhau.Visible = false;
                Label_MSSV.Visible = true;
                Button_DangXuat.Visible = true;
            }
        }

        protected void Button_DangNhap_Click(object sender, EventArgs e)
        {
            TaiKhoanSinhVienBUS taiKhoanSinhVienBUS = new TaiKhoanSinhVienBUS();

            if (taiKhoanSinhVienBUS.DangNhap(TextBox_MSSV.Text, TextBox_MatKhau.Text))
            {
                Session["isLogin"] = true;
                Session["isSignin"] = false;
                Session["MSSV"] = TextBox_MSSV.Text;

                setLogin(false);
                Response.Redirect("~/User/User.aspx");
            }
            else
            {
                Session["isLogin"] = false;
                Session["isSignin"] = false;
                Session["MSSV"] = "";

                setLogin(true);
                Response.Write("<script type='text/javascript'>alert('Đăng nhập thất bại');</script>");
            }

            TaiKhoanAdminBUS taiKhoanAdminBUS = new TaiKhoanAdminBUS();

            if (taiKhoanAdminBUS.DangNhap(TextBox_MSSV.Text, TextBox_MatKhau.Text))
            {
                Session["isLogin"] = true;
                Session["isSignin"] = false;
                Session["MSSV"] = TextBox_MSSV.Text;

                setLogin(false);
                Response.Redirect("~/Admin/Admin.aspx");
            }
            else
            {
                Session["isLogin"] = false;
                Session["isSignin"] = false;
                Session["MSSV"] = "";

                setLogin(true);
                Response.Write("<script type='text/javascript'>alert('Đăng nhập thất bại');</script>");
            }
        }

        protected void Button_DangKy_Click(object sender, EventArgs e)
        {
            Session["isSignin"] = true;
            Response.Redirect("~/DangKy.aspx");
        }

        protected void Button_DangXuat_Click(object sender, EventArgs e)
        {
            Session["isLogin"] = false;
            Session["isSignin"] = false;
            Session["MSSV"] = "";

            setLogin(true);

            Response.Redirect("~/index.aspx");
        }
    }
}