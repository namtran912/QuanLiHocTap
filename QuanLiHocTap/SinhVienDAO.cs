using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class SinhVienDAO
    {
        public SinhVienDTO DangNhap(string MSSV, string matKhau)
        {
            string query =
                "SELECT * FROM TaiKhoanSinhVien WHERE [Ma so sinh vien]='" + MSSV + "' and [Mat khau dang nhap] = '" + matKhau + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);
            if (dt.Rows.Count > 0)
            {
                string query2 =
                    "SELECT * FROM SinhVien WHERE [Ma so sinh vien]='" + dt.Rows[0]["Ma so sinh vien"].ToString() + "'";
                DataTable dt2 = DataProvider.ExecuteQuery(query2);
                SinhVienDTO sinhVienDTO = new SinhVienDTO();
                sinhVienDTO.MaSoSinhVien = dt2.Rows[0]["Ma so sinh vien"].ToString();
                sinhVienDTO.TenSinhVien = dt2.Rows[0]["Ten sinh vien"].ToString();
                sinhVienDTO.Khoa = Convert.ToInt32(dt2.Rows[0]["Khoa"]);
                sinhVienDTO.HeDaoTao = dt2.Rows[0]["He dao tao"].ToString();

                return sinhVienDTO;
            }
            return null;
        }

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
    }
}