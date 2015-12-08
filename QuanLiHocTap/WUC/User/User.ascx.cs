using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiHocTap.WUC
{
    public partial class User : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] == null || (bool)Session["isLogin"] == false)
                return;
           
            SinhVienBUS sinhVienBUS = new SinhVienBUS();
            SinhVienDTO sinhVienDTO = sinhVienBUS.LayThongTinSinhVien(Session["MSSV"].ToString());

            Label_MSSV.Text = "Mã số sinh viên: " + sinhVienDTO.MaSoSinhVien;
            Label_TenSV.Text = "Họ tên sinh vien: " + sinhVienDTO.TenSinhVien;
            Label_Khoa.Text = "Khóa: " + sinhVienDTO.Khoa.ToString(); 
            Label_HeDaoTao.Text = "Hệ đào tạo: " + sinhVienDTO.HeDaoTao;
        }
    }
}