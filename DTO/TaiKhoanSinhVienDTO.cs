using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class TaiKhoanSinhVienDTO
    {
        private string _MaSoSinhVien;
        private string _MatKhauDangNhap;

        public string MatKhauDangNhap
        {
            get { return _MatKhauDangNhap; }
            set { _MatKhauDangNhap = value; }
        }

        public string MaSoSinhVien
        {
            get { return _MaSoSinhVien; }
            set { _MaSoSinhVien = value; }
        }
    }
}