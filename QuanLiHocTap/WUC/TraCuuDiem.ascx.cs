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
            {
                SetForm(false);
                return;
            }

            SetForm(true);
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
            try
            {
                GridView_TraCuuDiem.DataSource =
                monHocCuaSinhVienBUS.TraCuuDiem(DropDownList_TraCuu.SelectedIndex, DropDownList_HocKy.SelectedIndex + 1, DropDownList_ChuyenNganh.SelectedValue);
                GridView_TraCuuDiem.DataBind();
            }
            catch
            {

            }
            double diemTB = monHocCuaSinhVienBUS.DiemTrungBinh(DropDownList_TraCuu.SelectedIndex, DropDownList_HocKy.SelectedIndex + 1, DropDownList_ChuyenNganh.SelectedValue),
                   diemTichLuy = monHocCuaSinhVienBUS.DiemTichLuy(DropDownList_TraCuu.SelectedIndex, DropDownList_HocKy.SelectedIndex + 1, DropDownList_ChuyenNganh.SelectedValue);
            int soTC = monHocCuaSinhVienBUS.SoTinChi(DropDownList_TraCuu.SelectedIndex, DropDownList_HocKy.SelectedIndex + 1, DropDownList_ChuyenNganh.SelectedValue);

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

        private void SetForm(bool visible)
        {
            Label_TraCuuTheo.Visible = visible;
            Label_DiemTB.Visible = visible;
            Label_DiemTichLuy.Visible = visible;
            Label_SoTC.Visible = visible;
            Label_HocKy.Visible = visible;
            Label_ChuyenNganh.Visible = visible;
            DropDownList_TraCuu.Visible = visible;
            DropDownList_HocKy.Visible = visible;
            DropDownList_ChuyenNganh.Visible = visible;
        }
    }
}