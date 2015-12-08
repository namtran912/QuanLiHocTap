using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiHocTap.WUC
{
    public partial class Dangky : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] != null && (bool)Session["isLogin"] == true)
                return;
        }

        protected void Button_DangKy_Click(object sender, EventArgs e)
        {
            if (TextBox_MatKhau.Text.Length < 6)
            {
                Label_ThongBao.Text = "Mật khẩu cần ít nhất 6 kí tự";
                return;
            }

            if (TextBox_MatKhau.Text != TextBox_MatKhauXN.Text)
            {
                Label_ThongBao.Text = "Mật khẩu và mật khảu xác nhận không chính xác";
                return;
            }

            SinhVienBUS sinhVienBUS = new SinhVienBUS();
            if (!sinhVienBUS.KiemTraTonTaiSinhVien(TextBox_MSSV.Text))
            {
                Label_ThongBao.Text = "Mã số sinh viên không hợp lệ";
                return;
            }

            TaiKhoanSinhVienBUS taiKhoanSinhVienBUS = new TaiKhoanSinhVienBUS();
            if (!taiKhoanSinhVienBUS.DangKy(TextBox_MSSV.Text, TextBox_MatKhau.Text))
            {
                Label_ThongBao.Text = "Mã số sinh viên này đã đăng ký tài khoản";
                return;
            }
            else
            {
                Session["isSignin"] = false;
                Label_ThongBao.Text = "Đăng ký thành công với Mã số sinh viên là: " + TextBox_MSSV.Text;
            }
        }

    }
}