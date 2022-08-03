using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;

namespace WEB_NET_Aplication.data
{
    public class product_builder
    {
        cls_products products = new cls_products();
        public string CreateCardProducts()
        {
            DataTable dt = products.Get();
            StringBuilder sb = new StringBuilder();
            string name = "", desc = "", price = "", rating = "", id = "";
            byte[] img = null;
            foreach (DataRow dr in dt.Rows)
            {
                int aux =0;
                foreach(DataColumn dc in dt.Columns) 
                {
                    if (aux ==0)
                    {
                        img = (byte[])dr[dc.ColumnName];
                    }
                    if (aux == 1)
                    {
                        id = dr[dc.ColumnName].ToString();
                    }
                    if (aux == 2)
                    {
                        name = dr[dc.ColumnName].ToString();
                    }
                    if (aux == 3)
                    {
                        desc = dr[dc.ColumnName].ToString();
                    }
                    if (aux == 4)
                    {
                        rating = dr[dc.ColumnName].ToString();
                    }
                    if (aux == 5)
                    {
                        price = dr[dc.ColumnName].ToString();
                    }
                    aux++;
                }
                string imageString = Convert.ToBase64String(img);
                
                sb.Append("<div class='col-lg-3 col-md-3'>");
                sb.Append("<div class='view overlay z-depth-1'>");
                sb.Append("<img src='"+ String.Format("data:image/jpg;base64,{0}", imageString)+ "' alt='' width='300' height='200''; '>"); //FOTO
                sb.Append("<div class='mask flex-center rgba-gradient'>");
                sb.Append("<span class='btn-rounded btn badge indigo'onclick='View(viewid" + id + ")' data-toggle='modal' data-target='#modal_edit'><i class='fas fa-edit fa-2x' aria-hidden='true'></i> <span id='viewid" + id+ "' style='display: none '>" + id + "</span></span>"); //ID EDITAR
                sb.Append("<span class='btn-rounded btn badge-danger'onclick='View(viewid" + id + ")' data-toggle='modal' data-target='#modal_delete'><i class='fas fa-trash fa-2x' aria-hidden='true'></i> <span id='viewid" + id + "' style='display: none '> " + id + "</span></span>");//ID BORRAR
                sb.Append("</div></div>");
                sb.Append("<div class='card-body'><div class='row'>");
                sb.Append("<h5 class='card-title mb-1 text-left'><strong><a href='' class='dark-grey-text'>" + name + "</a></strong></h5>"); //NOMBRE
                sb.Append("<div class='text-left'>");
                sb.Append("<p>" + desc + "</p>"); //DESC
                sb.Append("</div>");
                sb.Append("<ul class='rating'>");
                //ESTRELLAS DE COLORES DEPENDIENDO DE CUANTAS TENGA
                for (int i = 0; i < int.Parse(rating); i++)
                {
                    sb.Append("<li><i class='fas fa-star blue-text'></i></li>");
                }
                int AuxStar = ( int.Parse(rating)- 5) * (-1);
                for (int i = 0; i < AuxStar; i++)
                {
                    sb.Append("<li><i class='fas fa-star grey-text'></i></li>");
                }

                sb.Append("</ul>");
                sb.Append("</div>");
                sb.Append("<div class='pb-0'>");
                sb.Append("<div class='row mb-0'>");
                sb.Append("<span class='float-left'><strong>" + price + "$</strong></span>"); //PRECIO
                sb.Append("<span class='float-right'>");
                sb.Append("<a class='' data-toggle='tooltip' data-placement='top' title='' data-original-title='Add to Cart'><i class='fas fa-shopping-cart ml-3'></i></a>");
                sb.Append("</span>");
                sb.Append("</div></div></div></div>");

            }

            return sb.ToString();

            
        }
    }
}