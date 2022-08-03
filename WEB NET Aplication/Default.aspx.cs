using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB_NET_Aplication.data
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel tb = Master.FindControl("page_rute") as Panel;
            tb.Controls.Add(new Label { CssClass = "breadcrumb-dn mr-auto", Text = "<p><strong>Inicio</strong></p>" });

        }
    }
}