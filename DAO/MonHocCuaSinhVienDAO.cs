using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLiHocTap
{
    public class MonHocCuaSinhVienDAO
    {
        public List<BangDiem> TraCuuDiem(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            List<BangDiem> listBD = new List<BangDiem>();
            string query = "";

            switch (loaiTraCuu)
            {
                case 0:
                    query = "SELECT * FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] WHERE [Ma so sinh vien] = '" + MSSV + "'";
                    break;
                case 1:
                    query = "SELECT * FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] WHERE [Hoc ky] = '" + hocKy.ToString() + "' and [Ma so sinh vien] = '" + MSSV + "'";
                    break;
                case 2:
                    query = "SELECT * FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nganh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "' and [Ma so sinh vien] = '" + MSSV + "'";
                    break;
            }
                
            DataTable dt = DataProvider.ExecuteQuery(query);
            int stt = 0;
            try
            {
                if (dt.Rows.Count == 0)
                {
                    BangDiem bd = new BangDiem();
                    bd.STT = 0;
                    bd.TenMonHoc = "";
                    bd.SoTinChi = 0;
                    bd.Diem = 0;
                    listBD.Add(bd);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    BangDiem bd = new BangDiem();
                    bd.STT = ++stt;
                    bd.TenMonHoc = dr["Ten mon hoc"].ToString();
                    bd.SoTinChi = Convert.ToInt32(dr["So tin chi"]);
                    bd.Diem = Convert.ToDouble(dr["Diem"]);
                    listBD.Add(bd);
                }
            }
            catch
            {
                BangDiem bd = new BangDiem();
                bd.STT = 0;
                bd.TenMonHoc = "";
                bd.SoTinChi = 0;
                bd.Diem = 0;
                listBD.Add(bd);
            }
            return listBD;
        }

        public double DiemTrungBinh(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            string query = "";

            switch (loaiTraCuu)
            {
                case 0:
                    query = "SELECT avg(Diem) as [Diem trung binh] FROM MonHocCuaSinhVien WHERE [Ma so sinh vien] = '" + MSSV + "'";
                    break;
                case 1:
                    query = "SELECT avg(Diem) as [Diem trung binh] FROM MonHocCuaSinhVien WHERE [Hoc ky] = '" + hocKy.ToString() + "' and [Ma so sinh vien] = '" + MSSV + "'";
                    break;
                case 2:
                    query = "SELECT avg(Diem) as [Diem trung binh] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nganh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "' and [Ma so sinh vien] = '" + MSSV + "'";
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

        public double DiemTichLuy(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            string query = "";

            switch (loaiTraCuu)
            {
                case 0:
                    query = "SELECT avg(Diem) as [Diem tich luy] FROM MonHocCuaSinhVien WHERE [Ma so sinh vien] = '" + MSSV + "'";
                    break;
                case 1:
                    query = "SELECT avg(Diem) as [Diem tich luy] FROM MonHocCuaSinhVien WHERE [Hoc ky] <= '" + hocKy.ToString() + "' and [Ma so sinh vien] = '" + MSSV + "'";
                    break;
                case 2:
                    query = "SELECT avg(Diem) as [Diem tich luy] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nganh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "'  and MonHocCuaSinhVien.[Ma so sinh vien] = '" + MSSV + "'";
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

        public int SoTinChi(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            string query = "";

            switch (loaiTraCuu)
            {
                case 0:
                    query = "SELECT sum([So tin chi]) as [Tong so tin chi] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] WHERE [Ma so sinh vien] = '" + MSSV + "'";
                    break;
                case 1:
                    query = "SELECT sum([So tin chi]) as [Tong so tin chi] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] WHERE [Hoc ky] = '" + hocKy.ToString() + "' and [Ma so sinh vien] = '" + MSSV + "'";
                    break;
                case 2:
                    query = "SELECT sum([So tin chi]) as [Tong so tin chi] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nganh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "' and [Ma so sinh vien] = '" + MSSV + "'";
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

        public ThuHang TraCuuThuHang(string MSSV, int loaiTraCuu, int hocKy = 0, string chuyenNganh = "")
        {
            ThuHang thuHang = new ThuHang();
            thuHang.DiemTrungBinh = DiemTrungBinh(MSSV, loaiTraCuu, hocKy, chuyenNganh);
            thuHang.DiemTichLuy = DiemTichLuy(MSSV, loaiTraCuu, hocKy, chuyenNganh);
            thuHang.ThuHangDTB = 0;
            thuHang.ThuHangDTL = 0;
            if (thuHang.DiemTichLuy < 0)
                thuHang.DiemTichLuy = 0;
            if (thuHang.DiemTrungBinh < 0)
                thuHang.DiemTrungBinh = 0;

            string query1 = "", query2 = "";

            switch (loaiTraCuu)
            {
                case 0:
                    query1 = "SELECT avg(Diem) as [Diem trung binh], [Ma so sinh vien] FROM MonHocCuaSinhVien GROUP BY [Ma so sinh vien] ORDER BY [Diem trung binh] DESC";
                    query2 = "SELECT avg(Diem) as [Diem tich luy], [Ma so sinh vien] FROM MonHocCuaSinhVien GROUP BY [Ma so sinh vien] ORDER BY [Diem tich luy] DESC";
                    break;
                case 1:
                    query1 = "SELECT avg(Diem) as [Diem trung binh], [Ma so sinh vien] FROM MonHocCuaSinhVien WHERE [Hoc ky] = '" + hocKy.ToString() + "' GROUP BY [Ma so sinh vien] ORDER BY [Diem trung binh] DESC";
                    query2 = "SELECT avg(Diem) as [Diem tich luy], [Ma so sinh vien] FROM MonHocCuaSinhVien WHERE [Hoc ky] <= '" + hocKy.ToString() + "' GROUP BY [Ma so sinh vien] ORDER BY [Diem tich luy] DESC";
                    break;
                case 2:
                    query1 = "SELECT avg(Diem) as [Diem trung binh], [Ma so sinh vien] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nganh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "' GROUP BY [Ma so sinh vien] ORDER BY [Diem trung binh] DESC";
                    query2 = "SELECT avg(Diem) as [Diem tich luy], [Ma so sinh vien] FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] join ChuyenNganh on ChuyenNganh.[Ma chuyen nganh] = MonHoc.[Thuoc chuyen nganh] WHERE [Ten chuyen nganh] = N'" + chuyenNganh + "' GROUP BY [Ma so sinh vien] ORDER BY [Diem tich luy] DESC";
                    break;
            }

            DataTable dt1 = DataProvider.ExecuteQuery(query1);
            DataTable dt2 = DataProvider.ExecuteQuery(query2);
            try
            {
                int index = 1;
                foreach (DataRow dr in dt1.Rows)
                {
                    bool ch = true;
                    for (int i = 0; i < MSSV.Length; i++)
                        if (MSSV[i] != dr["Ma so sinh vien"].ToString()[i])
                        {
                            ch = false;
                            break;
                        }
                    if (ch)
                    {
                        thuHang.ThuHangDTB = index;
                        break;
                    }
                    index++;
                }

                index = 1;
                foreach (DataRow dr in dt2.Rows)
                {
                    bool ch = true;
                    for (int i = 0; i < MSSV.Length; i++)
                        if (MSSV[i] != dr["Ma so sinh vien"].ToString()[i])
                        {
                            ch = false;
                            break;
                        }
                    if (ch)
                    {
                        thuHang.ThuHangDTL = index;
                        break;
                    }
                    index++;
                }
            }
            catch
            {
                thuHang.ThuHangDTB = 0;
                thuHang.ThuHangDTL = 0;
            }
            return thuHang;
        }

        public List<ThongTinDiem> LayDanhSachDiem(string MSSV)
        {
            List<ThongTinDiem> listBD = new List<ThongTinDiem>();
            string query =
                "SELECT * FROM MonHocCuaSinhVien join MonHoc on MonHocCuaSinhVien.[Ma mon hoc] = MonHoc.[Ma mon hoc] WHERE [Ma so sinh vien] = '" + MSSV + "' ORDER BY [Hoc ky] ASC";

            DataTable dt = DataProvider.ExecuteQuery(query);
            int stt = 0;
            try
            {
                if (dt.Rows.Count == 0)
                {
                    ThongTinDiem bd = new ThongTinDiem();
                    bd.STT = 0;
                    bd.TenMonHoc = "";
                    bd.Diem = 0;
                    bd.Hocky = 0;
                    listBD.Add(bd);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    ThongTinDiem bd = new ThongTinDiem();
                    bd.STT = ++stt;
                    bd.TenMonHoc = dr["Ten mon hoc"].ToString();
                    bd.Diem = Convert.ToDouble(dr["Diem"]);
                    bd.Hocky = Convert.ToInt32(dr["Hoc ky"]);
                    listBD.Add(bd);
                }
            }
            catch
            {
                ThongTinDiem bd = new ThongTinDiem();
                bd.STT = 0;
                bd.TenMonHoc = "";
                bd.Diem = 0;
                bd.Hocky = 0;
                listBD.Add(bd);
            }
            return listBD;
        }

        public bool KiemTraTonTaiMonHocCuaSinhVien(string MSSV, string maMonHoc)
        {
            string query =
                "SELECT * FROM MonHocCuaSinhVien WHERE [Ma so sinh vien] = '" + MSSV + "' and [Ma mon hoc] = '" + maMonHoc + "'";
            try
            {
                DataTable dt = DataProvider.ExecuteQuery(query);
                if (dt.Rows.Count > 0)
                    if (dt.Rows[0]["Ma so sinh vien"] != null && dt.Rows[0]["Ma mon hoc"] != null)
                        return true;
            }
            catch
            {
                return false;
            }

            return false;
        }

        public bool ThemMonHocCuaSinhVien(MonHocCuaSinhVienDTO monHocCuaSinhVienDTO)
        {
            string query =
                "INSERT INTO MonHocCuaSinhVien VALUES('" +
                monHocCuaSinhVienDTO.MaSoSinhVien + "', '" +
                monHocCuaSinhVienDTO.MaMonHoc + "', " +
                monHocCuaSinhVienDTO.Diem.ToString() + ", " +
                monHocCuaSinhVienDTO.HocKi.ToString() + ")";

            
                DataProvider.ExecuteNonQuery(query);
                return true;
           

            return false;
        }

        public bool XoaMonHocCuaSinhVien(string MSSV, string maMonHoc)
        {
            string query =
                "DELETE FROM MonHocCuaSinhVien WHERE [Ma so sinh vien] = '" + MSSV + "' and [Ma mon hoc] = '" + maMonHoc + "'";

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

        public bool CapNhatMonHocCuaSinhVien(MonHocCuaSinhVienDTO monHocCuaSinhVienDTO)
        {
            string query =
                "UPDATE MonHocCuaSinhVien " +
                                 "SET [Diem] = '" + monHocCuaSinhVienDTO.Diem.ToString() + "', " +
                                    "[Hoc ky] = '" + monHocCuaSinhVienDTO.HocKi.ToString() + "' " +
                              "WHERE [Ma so sinh vien] = '" + monHocCuaSinhVienDTO.MaSoSinhVien + "' and [Ma mon hoc] = '" + monHocCuaSinhVienDTO.MaMonHoc + "'";

            
                DataProvider.ExecuteNonQuery(query);
                return true;
            
        

            return false;
        }
    }
}