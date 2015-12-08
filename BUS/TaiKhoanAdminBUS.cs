using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class TaiKhoanAdminBUS
    {
        private TaiKhoanAdminDAO taiKhoanAdminDAO;

        public TaiKhoanAdminBUS()
        {
            taiKhoanAdminDAO = new TaiKhoanAdminDAO();
        }

        public bool DangNhap(string maSoTaiKhoan, string matKhau)
        {
            return taiKhoanAdminDAO.DangNhap(maSoTaiKhoan, matKhau);
        }
    }
}