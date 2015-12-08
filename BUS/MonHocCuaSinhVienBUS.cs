using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class MonHocCuaSinhVienBUS
    {
        private MonHocCuaSinhVienDAO monHocCuaSinhVienDAO;

        public MonHocCuaSinhVienBUS()
        {
            monHocCuaSinhVienDAO = new MonHocCuaSinhVienDAO();
        }

        public List<BangDiem> TraCuuDiem(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            return monHocCuaSinhVienDAO.TraCuuDiem(MSSV, loaiTraCuu, hocKy, chuyenNganh);
        }

        public double DiemTrungBinh(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            return monHocCuaSinhVienDAO.DiemTrungBinh(MSSV, loaiTraCuu, hocKy, chuyenNganh);
        }

        public double DiemTichLuy(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            return monHocCuaSinhVienDAO.DiemTichLuy(MSSV, loaiTraCuu, hocKy, chuyenNganh);
        }

        public int SoTinChi(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            return monHocCuaSinhVienDAO.SoTinChi(MSSV, loaiTraCuu, hocKy, chuyenNganh);
        }

        public List<ThuHang> TraCuuThuHang(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            List<ThuHang> list = new List<ThuHang>();
            list.Add(monHocCuaSinhVienDAO.TraCuuThuHang(MSSV, loaiTraCuu, hocKy, chuyenNganh));
            return list;
        }

        public List<ThongTinDiem> LayDanhSachDiem(string MSSV)
        {
            return monHocCuaSinhVienDAO.LayDanhSachDiem(MSSV);
        }

         public bool ThemMonHocCuaSinhVien(string MSSV, string maMonHoc, double diem, int hocKy)
         {
             MonHocCuaSinhVienDTO monHocCuaSinhVienDTO = new MonHocCuaSinhVienDTO();
             monHocCuaSinhVienDTO.MaMonHoc = maMonHoc;
             monHocCuaSinhVienDTO.MaSoSinhVien = MSSV;
             monHocCuaSinhVienDTO.Diem = diem;
             monHocCuaSinhVienDTO.HocKi = hocKy;

             return monHocCuaSinhVienDAO.ThemMonHocCuaSinhVien(monHocCuaSinhVienDTO);
         }

         public bool XoatMonHocCuaSinhVien(string MSSV, string maMonHoc)
         {
             return monHocCuaSinhVienDAO.XoaMonHocCuaSinhVien(MSSV, maMonHoc);
         }

         public bool CapNhatMonHocCuaSinhVien(string MSSV, string maMonHoc, double diem, int hocKy)
         {
             MonHocCuaSinhVienDTO monHocCuaSinhVienDTO = new MonHocCuaSinhVienDTO();
             monHocCuaSinhVienDTO.MaMonHoc = maMonHoc;
             monHocCuaSinhVienDTO.MaSoSinhVien = MSSV;
             monHocCuaSinhVienDTO.Diem = diem;
             monHocCuaSinhVienDTO.HocKi = hocKy;

             return monHocCuaSinhVienDAO.CapNhatMonHocCuaSinhVien(monHocCuaSinhVienDTO);
         }

        public bool KiemTraTonTaiMonHocCuaSinhVien(string MSSV, string maMonHoc)
         {
             return monHocCuaSinhVienDAO.KiemTraTonTaiMonHocCuaSinhVien(MSSV, maMonHoc);
         }
    }
}