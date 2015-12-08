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

        public SinhVienDTO LayThongTinSinhVien(string MSSV)
        {
            return sinhVienDAO.LayThongTinSinhVien(MSSV);
        }

        public bool KiemTraTonTaiSinhVien(string MSSV)
        {
            return sinhVienDAO.KiemTraTonTaiSinhVien(MSSV);
        }

        public List<SinhVienDTO> LayDanhSachSinhVien()
        {
            return sinhVienDAO.LayDanhSachSinhVien();
        }

        public bool ThemSinhVien(string MSSV, string tenSV, int khoa, string heDaoTao)
        {
            SinhVienDTO sinhVienDTO = new SinhVienDTO();
            sinhVienDTO.MaSoSinhVien = MSSV;
            sinhVienDTO.TenSinhVien = tenSV;
            sinhVienDTO.Khoa = khoa;
            sinhVienDTO.HeDaoTao = heDaoTao;

            return sinhVienDAO.ThemSinhVien(sinhVienDTO);
        }

        public bool XoaSinhVien(string MSSV)
        {
            return sinhVienDAO.XoaSinhVien(MSSV);
        }

        public bool CapNhatSinhVien(string MSSV, string tenSV, int khoa, string heDaoTao)
        {
            SinhVienDTO sinhVienDTO = new SinhVienDTO();
            sinhVienDTO.MaSoSinhVien = MSSV;
            sinhVienDTO.TenSinhVien = tenSV;
            sinhVienDTO.Khoa = khoa;
            sinhVienDTO.HeDaoTao = heDaoTao;

            return sinhVienDAO.CapNhatSinhVien(sinhVienDTO);
        }
    }
}