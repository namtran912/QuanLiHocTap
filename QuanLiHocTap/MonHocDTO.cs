using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class MonHocDTO
    {
        private string _MaMonHoc;
        private string _TenMonHoc;
        private string _ThuocChuyenNganh;
        private int _SoTinChi;
        private bool _BatBuocHayTuChon;

        public bool BatBuocHayTuChon
        {
            get { return _BatBuocHayTuChon; }
            set { _BatBuocHayTuChon = value; }
        }

        public int SoTinChi
        {
            get { return _SoTinChi; }
            set { _SoTinChi = value; }
        }

        public string ThuocChuyenNganh
        {
            get { return _ThuocChuyenNganh; }
            set { _ThuocChuyenNganh = value; }
        }

        public string TenMonHoc
        {
            get { return _TenMonHoc; }
            set { _TenMonHoc = value; }
        }

        public string MaMonHoc
        {
            get { return _MaMonHoc; }
            set { _MaMonHoc = value; }
        }
    }
}