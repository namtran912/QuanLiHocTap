using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class MonHocBUS
    {
        MonHocDAO monHocDAO;
        public MonHocBUS()
        {
            monHocDAO = new MonHocDAO();
        }

        public List<MonHoc> LayDanhSachMonHoc()
        {
            return monHocDAO.LayDanhSachMonHoc();
        }
    }
}