using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiHocTap.WUC
{
    public partial class TraCuuThuHang : System.Web.UI.UserControl
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
            try
            {
                GridView_TraCuuThuHang.DataSource =
                    monHocCuaSinhVienBUS.TraCuuThuHang(Session["MSSV"].ToString(), DropDownList_TraCuu.SelectedIndex, DropDownList_HocKy.SelectedIndex + 1, DropDownList_ChuyenNganh.SelectedValue);
                GridView_TraCuuThuHang.DataBind();
            }
            catch
            {

            }
        }
    }
}