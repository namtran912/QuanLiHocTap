using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class TaiKhoanAdminDAO
    {
        public bool DangNhap(string maSoTaiKhoan, string matKhau)
        {
            string query =
                "SELECT * FROM TaiKhoanAdmin WHERE [Ma so tai khoan]='" + maSoTaiKhoan + "' and [Mat khau dang nhap] = '" + matKhau + "'";
            DataTable dt = DataProvider.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
                return true;

            return false;
        }
    }
}