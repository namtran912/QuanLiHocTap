using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiHocTap.WUC
{
    public partial class CapNhatDiem : System.Web.UI.UserControl
    {
        MonHocCuaSinhVienBUS monHocCuaSinhVienBUS;
        protected void Page_Load(object sender, EventArgs e)
        {
            monHocCuaSinhVienBUS = new MonHocCuaSinhVienBUS();

            MonHocBUS monHocBUS = new MonHocBUS();

            GridView_DanhSachMonHoc.DataSource = monHocBUS.LayDanhSachMonHoc();
            GridView_DanhSachMonHoc.DataBind();
        }

        protected void Button_Them_Click(object sender, EventArgs e)
        {
            if (TextBox_MSSVLayDiem.Text == "")
            {
                Label_ThongBao.Text = "Chưa điền thông tin Mã số sinh viên!";
                return;
            }

            if (TextBox_MaMonHoc.Text == "" || TextBox_Diem.Text == "" || TextBox_HocKy.Text == "")
            {
                Label_ThongBao.Text = "Thông tin điểm chưa đầy đủ!";
                return;
            }

            if (monHocCuaSinhVienBUS.KiemTraTonTaiMonHocCuaSinhVien(TextBox_MSSVLayDiem.Text, TextBox_MaMonHoc.Text))
            {
                Label_ThongBao.Text = "Điểm môn học đã tồn tại!";
                return;
            }

            if (Convert.ToDouble(TextBox_Diem.Text) >= 0 && Convert.ToDouble(TextBox_Diem.Text) <= 10 &&
                Convert.ToInt32(TextBox_HocKy.Text) > 0 && Convert.ToInt32(TextBox_HocKy.Text) <= 8 &&
                monHocCuaSinhVienBUS.ThemMonHocCuaSinhVien(TextBox_MSSVLayDiem.Text, TextBox_MaMonHoc.Text, Convert.ToDouble(TextBox_Diem.Text), Convert.ToInt32(TextBox_HocKy.Text)))
            {
                GridView_BangDiemSV.DataSource = monHocCuaSinhVienBUS.LayDanhSachDiem(TextBox_MSSVLayDiem.Text);
                GridView_BangDiemSV.DataBind();
                Label_ThongBao.Text = "Thêm điểm môn học thành công!";
            }
            else
            {
                Label_ThongBao.Text = "Thông tin nhập điểm chưa chính xác!";
                return;
            }
        }

        protected void Button_CapNhat_Click(object sender, EventArgs e)
        {
            if (TextBox_MSSVLayDiem.Text == "")
            {
                Label_ThongBao.Text = "Chưa điền thông tin Mã số sinh viên!";
                return;
            }

            if (TextBox_MSSVLayDiem.Text == "" || TextBox_Diem.Text == "" || TextBox_HocKy.Text == "")
            {
                Label_ThongBao.Text = "Thông tin điểm chưa đầy đủ!";
                return;
            }

            if (!monHocCuaSinhVienBUS.KiemTraTonTaiMonHocCuaSinhVien(TextBox_MSSVLayDiem.Text, TextBox_MaMonHoc.Text))
            {
                Label_ThongBao.Text = "Không tồn tại điểm môn học!";
                return;
            }

            if (Convert.ToDouble(TextBox_Diem.Text) >= 0 && Convert.ToDouble(TextBox_Diem.Text) <= 10 &&
                Convert.ToInt32(TextBox_HocKy.Text) > 0 && Convert.ToInt32(TextBox_HocKy.Text) <= 8 && 
                monHocCuaSinhVienBUS.CapNhatMonHocCuaSinhVien(TextBox_MSSVLayDiem.Text, TextBox_MaMonHoc.Text, Convert.ToDouble(TextBox_Diem.Text), Convert.ToInt32(TextBox_HocKy.Text)))
            {
                GridView_BangDiemSV.DataSource = monHocCuaSinhVienBUS.LayDanhSachDiem(TextBox_MSSVLayDiem.Text);
                GridView_BangDiemSV.DataBind();
                Label_ThongBao.Text = "Cập nhật điểm môn học thành công!";
            }
            else
            {
                Label_ThongBao.Text = "Thông tin nhập điểm chưa chính xác!";
                return;
            }
        }

        protected void Button_Xoa_Click(object sender, EventArgs e)
        {
            if (TextBox_MSSVLayDiem.Text == "")
            {
                Label_ThongBao.Text = "Chưa điền thông tin Mã số sinh viên!";
                return;
            }

            if (TextBox_MSSVLayDiem.Text == "")
            {
                Label_ThongBao.Text = "Chưa điền thông tin Mã số môn học!";
                return;
            }

            if (!monHocCuaSinhVienBUS.KiemTraTonTaiMonHocCuaSinhVien(TextBox_MSSVLayDiem.Text, TextBox_MaMonHoc.Text))
            {
                Label_ThongBao.Text = "Không tồn tại điểm môn học!";
                return;
            }

            if (monHocCuaSinhVienBUS.XoatMonHocCuaSinhVien(TextBox_MSSVLayDiem.Text, TextBox_MaMonHoc.Text))
            {
                GridView_BangDiemSV.DataSource = monHocCuaSinhVienBUS.LayDanhSachDiem(TextBox_MSSVLayDiem.Text);
                GridView_BangDiemSV.DataBind();
                Label_ThongBao.Text = "Xóa sinh điểm môn học thành công!";
            }
            else
            {
                Label_ThongBao.Text = "Thông tin điểm chưa chính xác!";
                return;
            }
        }

        protected void Button_XuatBangDiem_Click(object sender, EventArgs e)
        {
            GridView_BangDiemSV.DataSource = monHocCuaSinhVienBUS.LayDanhSachDiem(TextBox_MSSVLayDiem.Text);
            GridView_BangDiemSV.DataBind();
        }
    }
}