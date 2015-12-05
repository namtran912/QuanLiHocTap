using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public struct BangDiem
    {
        private int _STT;
        private string _TenMonHoc;
        private double _Diem;
        private int _SoTinChi;

        public int  STT
        {
            get { return _STT; }
            set { _STT = value; }
        }

        public string TenMonHoc
        {
            get { return _TenMonHoc; }
            set { _TenMonHoc = value; }
        }

        public double Diem
        {
            get { return _Diem; }
            set { _Diem = value; }
        }

        public int SoTinChi
        {
            get { return _SoTinChi; }
            set { _SoTinChi = value; }
        }
       
    } 

    public class MonHocCuaSinhVienDAO
    {
        public List<BangDiem> TraCuuDiem(int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            List<BangDiem> listBD = new List<BangDiem>();
            string query = "";

            switch (loaiTraCuu)
            {
                case 0:
                    query = "SELECT * FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc]";
                    break;
                case 1:
                    query = "SELECT * FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] WHERE [Hoc ki] = '" + hocKy.ToString() + "'";
                    break;
                case 2:
                    query = "SELECT * FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nhanh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "'";
                    break;
            }
                
            DataTable dt = DataProvider.ExecuteQuery(query);
            int stt = 0;
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    BangDiem bd = new BangDiem();
                    bd.STT = ++stt;
                    bd.TenMonHoc = dr["Ten mon hoc"].ToString();
                    bd.SoTinChi = Convert.ToInt32(dr["So tin chi"]);
                    bd.Diem = Convert.ToDouble(dr["Diem"]);
                    listBD.Add(bd);
                }
                return listBD;
            }
            catch
            {
                return null;
            }
            
        }

        public double DiemTrungBinh(int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            string query = "";

            switch (loaiTraCuu)
            {
                case 0:
                    query = "SELECT avg(Diem) as [Diem trung binh] FROM MonHocCuaSinhVien";
                    break;
                case 1:
                    query = "SELECT avg(Diem) as [Diem trung binh] FROM MonHocCuaSinhVien WHERE [Hoc ki] = '" + hocKy.ToString() + "'";
                    break;
                case 2:
                    query = "SELECT avg(Diem) as [Diem trung binh] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nhanh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "'";
                    break;
            }

            DataTable dt = DataProvider.ExecuteQuery(query);
            try
            {
                if (dt.Rows.Count > 0)
                    return Convert.ToDouble(dt.Rows[0]["Diem trung binh"]);
            }
            catch
            {
                return -1;
            }
            return -1;
        }

        public double DiemTichLuy(int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            string query = "";

            switch (loaiTraCuu)
            {
                case 0:
                    query = "SELECT avg(Diem) as [Diem tich luy] FROM MonHocCuaSinhVien";
                    break;
                case 1:
                    query = "SELECT avg(Diem) as [Diem tich luy] FROM MonHocCuaSinhVien WHERE [Hoc ki] <= '" + hocKy.ToString() + "'";
                    break;
                case 2:
                    query = "SELECT avg(Diem) as [Diem tich luy] FROM MonHocCuaSinhVienjoin MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nhanh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "'";
                    break;
            }

            DataTable dt = DataProvider.ExecuteQuery(query);
            try
            {
                if (dt.Rows.Count > 0)
                    return Convert.ToDouble(dt.Rows[0]["Diem tich luy"]);
            }
            catch
            {
                return -1;
            }

            return -1;
        }

        public int SoTinChi(int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            string query = "";

            switch (loaiTraCuu)
            {
                case 0:
                    query = "SELECT sum([So tin chi]) as [Tong so tin chi] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc]";
                    break;
                case 1:
                    query = "SELECT sum([So tin chi]) as [Tong so tin chi] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] WHERE [Hoc ki] = '" + hocKy.ToString() + "'";
                    break;
                case 2:
                    query = "SELECT sum([So tin chi]) as [Tong so tin chi] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nhanh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "'";
                    break;
            }

            DataTable dt = DataProvider.ExecuteQuery(query);
            try
            {
                if (dt.Rows.Count > 0)
                    return Convert.ToInt32(dt.Rows[0]["Tong so tin chi"]);
            }
            catch
            {
                return -1;
            }
            return -1;
        }
    }
}