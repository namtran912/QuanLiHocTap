using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiHocTap
{
    public partial class TraCuuThuHang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] == null || (bool)Session["isLogin"] == false)
            {
                this.TraCuuThuHang1.Visible = false;
                return;
            }
            this.TraCuuThuHang1.Visible = true;
        }
    }
}