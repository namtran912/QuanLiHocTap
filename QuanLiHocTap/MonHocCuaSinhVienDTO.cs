using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class MonHocCuaSinhVienDTO
    {
        private string _MaSoSinhVien;
        private string _MaMonHoc;
        private double _Diem;
        private int _HocKi;

        public int HocKi
        {
            get { return _HocKi; }
            set { _HocKi = value; }
        }

        public double Diem
        {
            get { return _Diem; }
            set { _Diem = value; }
        }

        public string MaMonHoc
        {
            get { return _MaMonHoc; }
            set { _MaMonHoc = value; }
        }

        public string MaSoSinhVien
        {
            get { return _MaSoSinhVien; }
            set { _MaSoSinhVien = value; }
        }
    }
}