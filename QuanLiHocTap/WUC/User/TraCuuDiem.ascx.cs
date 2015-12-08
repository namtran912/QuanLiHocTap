using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiHocTap.WUC
{
    public partial class TraCuuDiem : System.Web.UI.UserControl
    {
        MonHocCuaSinhVienBUS monHocCuaSinhVienBUS;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] == null || (bool)Session["isLogin"] == false)
                return;

            monHocCuaSinhVienBUS = new MonHocCuaSinhVienBUS();
            TraCuu();
        }

        protected void DropDownList_TraCuu_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (DropDownList_TraCuu.SelectedIndex)
            {
                case 0:
                    DropDownList_HocKy.Enabled = false;
                    DropDownList_ChuyenNganh.Enabled = false;
                    break;
                case 1:
                    DropDownList_HocKy.Enabled = true;
                    DropDownList_ChuyenNganh.Enabled = false;
                    break;
                case 2:
                    DropDownList_HocKy.Enabled = false;
                    DropDownList_ChuyenNganh.Enabled = true;
                    break;
            }
            TraCuu();
        }

        protected void DropDownList_HocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TraCuu();
        }

        protected void DropDownList_ChuyenNganh_SelectedIndexChanged(object sender, EventArgs e)
        {
            TraCuu();
        }

        private void TraCuu()
        {
            
                GridView_TraCuuDiem.DataSource =
                    monHocCuaSinhVienBUS.TraCuuDiem(Session["MSSV"].ToString(),  DropDownList_TraCuu.SelectedIndex, DropDownList_HocKy.SelectedIndex + 1, DropDownList_ChuyenNganh.SelectedValue);
                GridView_TraCuuDiem.DataBind();
          
            double diemTB = monHocCuaSinhVienBUS.DiemTrungBinh(Session["MSSV"].ToString(), DropDownList_TraCuu.SelectedIndex, DropDownList_HocKy.SelectedIndex + 1, DropDownList_ChuyenNganh.SelectedValue),
                   diemTichLuy = monHocCuaSinhVienBUS.DiemTichLuy(Session["MSSV"].ToString(), DropDownList_TraCuu.SelectedIndex, DropDownList_HocKy.SelectedIndex + 1, DropDownList_ChuyenNganh.SelectedValue);
            int soTC = monHocCuaSinhVienBUS.SoTinChi(Session["MSSV"].ToString(), DropDownList_TraCuu.SelectedIndex, DropDownList_HocKy.SelectedIndex + 1, DropDownList_ChuyenNganh.SelectedValue);

            if (diemTB < 0)
                diemTB = 0;
            if (diemTichLuy < 0)
                diemTichLuy = 0;
            if (soTC < 0)
                soTC = 0;

            Label_DiemTB.Text = "Điểm trung bình: " + diemTB.ToString();
            Label_DiemTichLuy.Text = "Điểm tích lũy: " + diemTichLuy.ToString();
            Label_SoTC.Text = "Số tín chỉ: " + soTC.ToString();
        }
    }
}