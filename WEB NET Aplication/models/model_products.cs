using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_NET_Aplication.models
{
    public class model_products
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
        public int typeID { get; set; }
        public int colorID { get; set; }
        public int rating { get; set; }
        public string description { get; set; }
        public byte[] image { get; set; }


    }
}