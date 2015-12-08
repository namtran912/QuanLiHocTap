using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class TaiKhoanSinhVienBUS
    {
        private TaiKhoanSinhVienDAO taiKhoanSinhVienDAO;

        public TaiKhoanSinhVienBUS()
        {
            taiKhoanSinhVienDAO = new TaiKhoanSinhVienDAO();
        }

        public bool DangNhap(string MSSV, string matKhau)
        {
            return taiKhoanSinhVienDAO.DangNhap(MSSV, matKhau);
        }

        public bool DangKy(string MSSV, string matKhau)
        {
            return taiKhoanSinhVienDAO.DangKy(MSSV, matKhau);
        }
    }
}