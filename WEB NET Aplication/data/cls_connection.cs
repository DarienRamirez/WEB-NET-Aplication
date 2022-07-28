using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WEB_NET_Aplication.data
{
    public class cls_connection
    {
        protected SqlConnection conn;

        protected void ConnectionSQL() 
        {
            try
            {
                conn = new SqlConnection("data source=DESKTOP-SB6PJ1C;initial catalog=NETFramework;trusted_connection=true");
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        protected void Desconect() 
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}