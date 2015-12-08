using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class TaiKhoanAdminDTO
    {
        private string _MaSoTaiKhoan;
        private string _MatKhauDangNhap;

        public string MatKhauDangNhap
        {
            get { return _MatKhauDangNhap; }
            set { _MatKhauDangNhap = value; }
        }

        public string MaSoTaiKhoan
        {
            get { return _MaSoTaiKhoan; }
            set { _MaSoTaiKhoan = value; }
        }

    }
}