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
            SinhVienBUS sinhVienBUS = new SinhVienBUS();
            SinhVienDTO sinhVienDTO = sinhVienBUS.DangNhap(TextBox_MSSV.Text, TextBox_MatKhau.Text);

            if (sinhVienDTO != null)
            {
                Session["isLogin"] = true;
                Session["MSSV"] = sinhVienDTO.MaSoSinhVien;

                setLogin(false);
                Response.Redirect("~/User.aspx");
            }
            else
            {
                Session["isLogin"] = false;
                Session["MSSV"] = "";

                setLogin(true);
                Response.Write("<script type='text/javascript'>alert('Đăng nhập thất bại');</script>");
            }
        }

        protected void Button_DangKy_Click(object sender, EventArgs e)
        {

        }

        protected void Button_DangXuat_Click(object sender, EventArgs e)
        {
            Session["isLogin"] = false;
            Session["MSSV"] = "";

            setLogin(true);

            Response.Redirect("~/index.aspx");
        }
    }
}