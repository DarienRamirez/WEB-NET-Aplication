using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_NET_Aplication.data;

namespace WEB_NET_Aplication.models
{
    public partial class products : System.Web.UI.Page
    {
        cls_products Clsproducts = new cls_products();
        protected void Page_Load(object sender, EventArgs e)
        {
            cls_type type = new cls_type();
            DataTable dt = type.Get();
            dd_type.DataSource = dt;
            dd_type.DataTextField = "Tipo";
            dd_type.DataValueField = "ID";
            dd_type.DataBind();

            cls_color color = new cls_color();
            DataTable dtcolor = color.Get();
            dd_color.DataSource = dtcolor;
            dd_color.DataTextField = "COLOR";
            dd_color.DataValueField = "ID";
            dd_color.DataBind();

            product_builder productView = new product_builder();
            table.Controls.Add(new Label {CssClass= "row ml-1 mr-5 mt-2 ", Text = productView.CreateCardProducts()});
        }

        protected void Delete(object sender, EventArgs e)
        {
            Clsproducts.Delete(int.Parse(viewid.Text));
            Response.Redirect(Request.RawUrl, true);
        }
        protected void View(object sender, EventArgs e)
        {
            DataTable dt = Clsproducts.GetTop(int.Parse(viewid.Text));
            foreach (DataRow dr in dt.Rows) 
            {
                int aux = 0;
                foreach (DataColumn dc in dt.Columns)
                {
                    switch (aux)
                    {
                        
                        case 1:
                            txt_nombre.Text = dr[dc.ColumnName].ToString();
                            aux++;
                            break;
                        case 2:
                            txt_price.Text = dr[dc.ColumnName].ToString();
                            break;
                        case 3:
                            txt_nombre.Text = dr[dc.ColumnName].ToString(); //type
                            break;
                        case 4:
                            txt_nombre.Text = dr[dc.ColumnName].ToString(); //color
                            break;

                        case 5:
                            txt_rate.Text = dr[dc.ColumnName].ToString(); 
                            break;

                        case 6:
                            txt_description.Text = dr[dc.ColumnName].ToString();
                            break;

                    }
                    aux++;
                }
            }

        }
        protected void Modify(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "")
            {
                model_products model_Products = new model_products()
                {
                    name = txt_nombre.Text.ToString(),
                    price = int.Parse(txt_price.Text),
                    rating = int.Parse(txt_rate.Text),
                    typeID = int.Parse(dd_type.SelectedValue),
                    colorID = int.Parse(dd_color.SelectedValue),
                    description = txt_description.Text.ToString(),
                    image = uploadImg()
                };
                Clsproducts.Modify(model_Products);
                viewid.Text = "";
                Response.Redirect(Request.RawUrl, true);
            }
        }
        public byte[] uploadImg()
        {
            int size = file_img.PostedFile.ContentLength;
            byte[] originalImage = new byte[size];

            file_img.PostedFile.InputStream.Read(originalImage, 0, size);

            Bitmap originalImgBinary = new Bitmap(file_img.PostedFile.InputStream);

            string ImgData64 = "data:image/jpg;base64," + Convert.ToBase64String(originalImage);
            return originalImage;
        }
    }
}