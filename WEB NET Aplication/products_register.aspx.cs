using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB_NET_Aplication.data;
using WEB_NET_Aplication.models;
using System.IO;
using System.Drawing;

namespace WEB_NET_Aplication
{
    public partial class products_register : System.Web.UI.Page
    {
        cls_products products = new cls_products();
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
        }
        protected void Register(object sender, EventArgs e)
        {
            if (int.Parse(txt_rate.Text) <= 5 && txt_rate.Text != "")
            {
                if (txt_nombre.Text != "" && txt_price.Text != "" && txt_rate.Text != "" && txt_description.Text != "")
                {
                    model_products modelproducts = new model_products()
                    {
                        name = txt_nombre.Text.ToString(),
                        price = int.Parse(txt_price.Text),
                        rating = int.Parse(txt_rate.Text),
                        typeID = int.Parse(dd_type.SelectedValue),
                        colorID = int.Parse(dd_color.SelectedValue),
                        description = txt_description.Text.ToString(),
                        image = uploadImg()
                    };
                    products.Save(modelproducts);
                    Response.Redirect(Request.RawUrl, true);
                }
            }
        }

        public byte[] uploadImg()
        {
            int size = file_img.PostedFile.ContentLength;
            byte[] originalImage = new byte[size];
            if (file_img.PostedFile.ContentLength != 0)
            {
                size = file_img.PostedFile.ContentLength;
                originalImage = new byte[size];

                file_img.PostedFile.InputStream.Read(originalImage, 0, size);

                Bitmap originalImgBinary = new Bitmap(file_img.PostedFile.InputStream);

                string ImgData64 = "data:image/jpg;base64," + Convert.ToBase64String(originalImage);
                
            }
            return originalImage;

        }
    }
}