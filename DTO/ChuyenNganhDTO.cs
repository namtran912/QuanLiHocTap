using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class ChuyenNganhDTO
    {
        private string _MaChuyenNganh;
        private string _TenChuyenNganh;

        public string TenChuyenNganh
        {
            get { return _TenChuyenNganh; }
            set { _TenChuyenNganh = value; }
        }

        public string MaChuyenNganh
        {
            get { return _MaChuyenNganh; }
            set { _MaChuyenNganh = value; }
        }
    }
}