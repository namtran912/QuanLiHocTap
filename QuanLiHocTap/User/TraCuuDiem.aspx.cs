using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QuanLiHocTap
{
    public partial class TraCuuDiem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["isLogin"] == null || (bool)Session["isLogin"] == false)
            {
                this.TraCuuDiem1.Visible = false;
                return;
            }
            this.TraCuuDiem1.Visible = true;
        }

    }
}