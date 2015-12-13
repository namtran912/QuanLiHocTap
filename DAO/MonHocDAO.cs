using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class MonHocDAO
    {
        public List<MonHoc> LayDanhSachMonHoc()
        {
            string query
                = "SELECT * FROM MonHoc ORDER BY [Ma mon hoc] ASC";

            List<MonHoc> list = new List<MonHoc>();
            DataTable dt = DataProvider.ExecuteQuery(query);
            try
            {
                foreach(DataRow dr in dt.Rows)
                {
                    MonHoc monHoc = new MonHoc();
                    monHoc.MaMonHoc = dr["Ma mon hoc"].ToString();
                    monHoc.TenMonHoc = dr["Ten mon hoc"].ToString();
                    list.Add(monHoc);
                }
            }
            catch
            {

            }

            return list;
        }
    }
}