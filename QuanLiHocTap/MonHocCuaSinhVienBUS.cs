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

        public List<BangDiem> TraCuuDiem(int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            return monHocCuaSinhVienDAO.TraCuuDiem(loaiTraCuu, hocKy, chuyenNganh);
        }

        public double DiemTrungBinh(int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            return monHocCuaSinhVienDAO.DiemTrungBinh(loaiTraCuu, hocKy, chuyenNganh);
        }

        public double DiemTichLuy(int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            return monHocCuaSinhVienDAO.DiemTichLuy(loaiTraCuu, hocKy, chuyenNganh);
        }

        public int SoTinChi(int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            return monHocCuaSinhVienDAO.SoTinChi(loaiTraCuu, hocKy, chuyenNganh);
        }
    }
}