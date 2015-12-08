using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public struct BangDiem
    {
        private int _STT;
        private string _TenMonHoc;
        private double _Diem;
        private int _SoTinChi;

        public int STT
        {
            get { return _STT; }
            set { _STT = value; }
        }

        public string TenMonHoc
        {
            get { return _TenMonHoc; }
            set { _TenMonHoc = value; }
        }

        public double Diem
        {
            get { return _Diem; }
            set { _Diem = value; }
        }

        public int SoTinChi
        {
            get { return _SoTinChi; }
            set { _SoTinChi = value; }
        }

    }

    public struct ThongTinDiem
    {
        private int _STT;
        private string _TenMonHoc;
        private double _Diem;
        private int _Hocky;

        public int STT
        {
            get { return _STT; }
            set { _STT = value; }
        }

        public string TenMonHoc
        {
            get { return _TenMonHoc; }
            set { _TenMonHoc = value; }
        }

        public double Diem
        {
            get { return _Diem; }
            set { _Diem = value; }
        }

        public int Hocky
        {
            get { return _Hocky; }
            set { _Hocky = value; }
        }
    }

    public struct ThuHang
    {
        private double _DiemTrungBinh;
        private int _ThuHangDTB;
        private double _DiemTichLuy;
        private int _ThuHangDTL;

        public double DiemTrungBinh
        {
            get { return _DiemTrungBinh; }
            set { _DiemTrungBinh = value; }
        }

        public int ThuHangDTB
        {
            get { return _ThuHangDTB; }
            set { _ThuHangDTB = value; }
        }

        public double DiemTichLuy
        {
            get { return _DiemTichLuy; }
            set { _DiemTichLuy = value; }
        }

        public int ThuHangDTL
        {
            get { return _ThuHangDTL; }
            set { _ThuHangDTL = value; }
        }
    }

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