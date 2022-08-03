using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_NET_Aplication.addons;
using WEB_NET_Aplication.data;
using WEB_NET_Aplication.models;

namespace WEB_NET_Aplication
{

    public partial class color_register : System.Web.UI.Page
    {
        cls_color color = new cls_color();
        table_builder tablebuilder = new table_builder();
        protected void Page_Load(object sender, EventArgs e)
        {
            Panel tb = Master.FindControl("page_rute") as Panel;
            tb.Controls.Add(new Label { CssClass = "breadcrumb-dn mr-auto", Text = "<p><strong>Inicio</strong>/Registrar/Colores</p>" });
            Get();
        }

        public void Get()
        {
            table.Controls.Add(new Label { Text = tablebuilder.tablebuilder(color.Get()) });
        }

        protected void Register(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                model_color modelcolor = new model_color()
                {
                    name = txt_nombre.Text,
                };
                color.Save(modelcolor);
                txt_nombre.Text = "";
                Response.Redirect(Request.RawUrl, true);
            }
        }

        protected void Delete(object sender, EventArgs e)
        {
            color.Delete(int.Parse(deleteid.Text));
            Response.Redirect(Request.RawUrl, true);
        }

        protected void View(object sender, EventArgs e)
        {
            ViewTop();

        }
        public void ViewTop()
        {
            color.GetTop(int.Parse(deleteid.Text));
            DataTable dt = new DataTable();
            dt = color.GetTop(int.Parse(deleteid.Text));

            string view = "", modify = "";
            foreach (DataRow dr in dt.Rows)
            {

                foreach (DataColumn dc in dt.Columns)
                {
                    view = dr[dc.ColumnName].ToString();
                    modify = dr[dc.ColumnName].ToString();

                }
            }
            txt_view.Text = view;
            txt_modify.Text = modify;
        }

        protected void Modify(object sender, EventArgs e)
        {
            if (txt_modify.Text != "")
            {
                model_color modelcolor = new model_color()
                {
                    id = int.Parse(deleteid.Text),
                    name = txt_modify.Text,
                };
                color.Modify(modelcolor);
                txt_modify.Text = "";
                deleteid.Text = "";
                Response.Redirect(Request.RawUrl, true);
            }
        }
    }
}