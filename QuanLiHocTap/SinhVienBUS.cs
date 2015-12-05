using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class SinhVienBUS
    {
        private SinhVienDAO sinhVienDAO;

        public SinhVienBUS()
        {
            sinhVienDAO = new SinhVienDAO();
        }

        public SinhVienDTO DangNhap(string MSSV, string matKhau)
        {
            return sinhVienDAO.DangNhap(MSSV, matKhau);
        }

        public SinhVienDTO LayThongTinSinhVien(string MSSV)
        {
            return sinhVienDAO.LayThongTinSinhVien(MSSV);
        }
    }
}