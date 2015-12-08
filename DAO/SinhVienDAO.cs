using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class SinhVienDAO
    {
        public SinhVienDTO LayThongTinSinhVien(string MSSV)
        {
            string query =
                "SELECT * FROM SinhVien WHERE [Ma so sinh vien]='" + MSSV + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                SinhVienDTO sinhVienDTO = new SinhVienDTO();
                sinhVienDTO.MaSoSinhVien = dt.Rows[0]["Ma so sinh vien"].ToString();
                sinhVienDTO.TenSinhVien = dt.Rows[0]["Ten sinh vien"].ToString();
                sinhVienDTO.Khoa = Convert.ToInt32(dt.Rows[0]["Khoa"]);
                sinhVienDTO.HeDaoTao = dt.Rows[0]["He dao tao"].ToString();

                return sinhVienDTO;
            }
            return null;
        }

        public bool KiemTraTonTaiSinhVien(string MSSV)
        {
            string query = 
                "SELECT * FROM SinhVien WHERE [Ma so sinh vien] = '" + MSSV + "'";
            try
            {
                DataTable dt = DataProvider.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                    if (dt.Rows[0]["Ma so sinh vien"] != null)
                        return true;
            }
            catch
            {
                return false;
            }

            return false;
        }

        public List<SinhVienDTO> LayDanhSachSinhVien()
        {
            string query =
                "SELECT * FROM SinhVien ORDER BY [Ma so sinh vien] ASC";

            DataTable dt = DataProvider.ExecuteQuery(query);
            List<SinhVienDTO> listSinhVienDTO = new List<SinhVienDTO>();

            foreach(DataRow dr in dt.Rows)
            {
                SinhVienDTO sinhVienDTO = new SinhVienDTO();
                sinhVienDTO.MaSoSinhVien = dr["Ma so sinh vien"].ToString();
                sinhVienDTO.TenSinhVien = dr["Ten sinh vien"].ToString();
                sinhVienDTO.Khoa = Convert.ToInt32(dr["Khoa"]);
                sinhVienDTO.HeDaoTao = dr["He dao tao"].ToString();

                listSinhVienDTO.Add(sinhVienDTO);
            }

            return listSinhVienDTO;
        }

        public bool ThemSinhVien(SinhVienDTO sinhVienDTO)
        {
            string query =
                "INSERT INTO SinhVien VALUES('" +
                sinhVienDTO.MaSoSinhVien + "', N'" +
                sinhVienDTO.TenSinhVien + "', '" +
                sinhVienDTO.Khoa.ToString() + "', N'" +
                sinhVienDTO.HeDaoTao + "')";

            try
            {
                DataProvider.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }

            return false;
        }

        public bool XoaSinhVien(string MSSV)
        {
            string query =
                "DELETE FROM SinhVien WHERE [Ma so sinh vien] = '" + MSSV + "'";

            try
            {
                DataProvider.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }

            return false;
        }

        public bool CapNhatSinhVien(SinhVienDTO sinhVienDTO)
        {
            string query =
                "UPDATE SinhVien " +
                                 "SET [Ten sinh vien] = N'" + sinhVienDTO.TenSinhVien + "', " +
                                    "[Khoa] = '" + sinhVienDTO.Khoa.ToString() + "', " +
                                    "[He dao tao] = N'" + sinhVienDTO.HeDaoTao + "' " +
                              "WHERE [Ma so sinh vien] = '" + sinhVienDTO.MaSoSinhVien + "'";

            try
            {
                DataProvider.ExecuteNonQuery(query);
                return true;
            }
            catch
            {
                return false;
            }

            return false;
        }
    }
}