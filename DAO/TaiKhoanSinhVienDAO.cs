using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class TaiKhoanSinhVienDAO
    {
        public bool DangNhap(string MSSV, string matKhau)
        {
            string query =
                "SELECT * FROM TaiKhoanSinhVien WHERE [Ma so sinh vien]='" + MSSV + "' and [Mat khau dang nhap] = '" + matKhau + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
                return true;

            return false;
        }

        public bool DangKy(string MSSV, string matKhau)
        {
            string query = "INSERT INTO TaiKhoanSinhVien VALUES('" + MSSV + "', '" + matKhau + "')";
            try
            {
                DataProvider.ExecuteNonQuery(query);
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}