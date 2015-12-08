using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiHocTap.WUC
{
    public partial class CapNhatSinhVien : System.Web.UI.UserControl
    {
        SinhVienBUS sinhVienBUS;
        protected void Page_Load(object sender, EventArgs e)
        {
            sinhVienBUS = new SinhVienBUS();
           
            GridView_DanhSachSV.DataSource = sinhVienBUS.LayDanhSachSinhVien();
            GridView_DanhSachSV.DataBind();
            Label_ThongBao.Text = "";
        }

        protected void Button_Them_Click(object sender, EventArgs e)
        {
            if (TextBox_MSSV.Text == "" || TextBox_TenSV.Text == "" || TextBox_Khoa.Text == "" || TextBox_HeDaoTao.Text == "")
            {
                Label_ThongBao.Text = "Thông tin sinh viên chưa đầy đủ!";
                return;
            }

            if (sinhVienBUS.KiemTraTonTaiSinhVien(TextBox_MSSV.Text))
            {
                Label_ThongBao.Text = "Sinh viên đã tồn tại!";
                return;
            }

            if (sinhVienBUS.ThemSinhVien(TextBox_MSSV.Text, TextBox_TenSV.Text, Convert.ToInt32(TextBox_Khoa.Text), TextBox_HeDaoTao.Text))
            {
                GridView_DanhSachSV.DataSource = sinhVienBUS.LayDanhSachSinhVien();
                GridView_DanhSachSV.DataBind();
                Label_ThongBao.Text = "Thêm sinh viên " + TextBox_MSSV.Text + " thành công!";
            }
        }

        protected void Button_CapNhat_Click(object sender, EventArgs e)
        {
            if (TextBox_MSSV.Text == "" || TextBox_TenSV.Text == "" || TextBox_Khoa.Text == "" || TextBox_HeDaoTao.Text == "")
            {
                Label_ThongBao.Text = "Thông tin sinh viên chưa đầy đủ!";
                return;
            }

            if (!sinhVienBUS.KiemTraTonTaiSinhVien(TextBox_MSSV.Text))
            {
                Label_ThongBao.Text = "Không tồn tại sinh viên!";
                return;
            }

            if (sinhVienBUS.CapNhatSinhVien(TextBox_MSSV.Text, TextBox_TenSV.Text, Convert.ToInt32(TextBox_Khoa.Text), TextBox_HeDaoTao.Text))
            {
                GridView_DanhSachSV.DataSource = sinhVienBUS.LayDanhSachSinhVien();
                GridView_DanhSachSV.DataBind();
                Label_ThongBao.Text = "Cập nhật sinh viên " + TextBox_MSSV.Text + " thành công!";
            }
        }

        protected void Button_Xoa_Click(object sender, EventArgs e)
        {
            if (TextBox_MSSV.Text == "")
            {
                Label_ThongBao.Text = "Chưa điền thông tin Mã số sinh viên!";
                return;
            }

            if (!sinhVienBUS.KiemTraTonTaiSinhVien(TextBox_MSSV.Text))
            {
                Label_ThongBao.Text = "Không tồn tại sinh viên!";
                return;
            }

            if (sinhVienBUS.XoaSinhVien(TextBox_MSSV.Text))
            {
                GridView_DanhSachSV.DataSource = sinhVienBUS.LayDanhSachSinhVien();
                GridView_DanhSachSV.DataBind();
                Label_ThongBao.Text = "Xóa sinh viên " + TextBox_MSSV.Text + " thành công!";
            }
            else
            {
                Label_ThongBao.Text = "Không thể xóa sinh viên do dữ liệu điểm!";
            }
        }
    }
}