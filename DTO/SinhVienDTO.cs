using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class SinhVienDTO
    {
        private string _MaSoSinhVien;
        private string _TenSinhVien;
        private int _Khoa;
        private string _HeDaoTao;

        public string MaSoSinhVien
        {
            get { return _MaSoSinhVien; }
            set { _MaSoSinhVien = value; }
        }

        public string TenSinhVien
        {
            get { return _TenSinhVien; }
            set { _TenSinhVien = value; }
        }

        public int Khoa
        {
            get { return _Khoa; }
            set { _Khoa = value; }
        }

        public string HeDaoTao
        {
            get { return _HeDaoTao; }
            set { _HeDaoTao = value; }
        }
    }
}