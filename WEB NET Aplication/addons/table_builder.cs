using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace WEB_NET_Aplication.addons
{
    public class table_builder
    {
        public string tablebuilder(DataTable dt) 
        {

            string button_view_class = "'btn-floating btn-light-green waves-effect waves-light mr-2'";
            string icon_view = "'fas fa-eye'";

            string button_edit_class = "'btn-floating btn-cyan waves-effect waves-light mr-2'";
            string icon_edit = "'fas fa-edit'";

            string button_delete_class = "'btn-floating btn-secondary waves-effect waves-light mr-2'";
            string icon_delete = "'fas fa-trash'";

            StringBuilder sb = new StringBuilder();
            sb.Append("<table class=" + "table" + ">");
            sb.Append("<tr>");
            foreach (DataColumn dc in dt.Columns)
            {
                sb.Append("<th><strong>");
                sb.Append(dc.ColumnName.ToUpper());
                sb.Append("</strong></th>");

            }
            sb.Append("<th><strong>");
            sb.Append("ACTIONS");
            sb.Append("</strong><th>");

            sb.Append("</tr> </thread>");

            foreach (DataRow dr in dt.Rows)
            {
                sb.Append("<tr>");
                string id = "";
                int aux=0;
                foreach (DataColumn dc in dt.Columns)
                {
                    if (aux == 0)
                    {
                        id = (dr[dc.ColumnName].ToString());
                        aux++;
                        sb.Append("<th id='btnid" + id + "'>");
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append("</th>");
                    }
                    else
                    {
                        sb.Append("<th>");
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append("</th>");
                    }
                    

                }
                sb.Append("<th>");
                sb.Append("<a class=" + button_view_class + "' onclick ='"+ "View(btnid"+ id + ",0)'" + " data-toggle='" + "modal" + "' data-target='" + "#modal_view" + "'><i class=" + icon_view + "></i></a>");
                sb.Append("<a class=" + button_edit_class + "' onclick=" + "'View(btnid" + id + ",1)'" + " data-toggle='" + "modal" + "' data-target='" + "#modal_edit" + "'><i class=" + icon_edit + "></i></a>");
                sb.Append("<a class=" + button_delete_class + "' onclick=" + "'View(btnid" + id + ",2)'" + " data-toggle='" + "modal" + "' data-target='" + "#modal_delete" + "'><i class=" + icon_delete + "></i></a>");
                aux = 0;
                sb.Append("</th>");

                sb.Append("</tr>");

            }
            sb.Append("</table>");
            return sb.ToString();
        }
    }
}