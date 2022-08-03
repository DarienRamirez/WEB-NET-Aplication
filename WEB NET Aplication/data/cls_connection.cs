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
                //conn = new SqlConnection("data source=DESKTOP-SB6PJ1C;initial catalog=NETFramework;trusted_connection=true");
                conn = new SqlConnection("Server=tcp:darien.database.windows.net,1433;Initial Catalog=Webnet;Persist Security Info=False;User ID=user;Password=sql123456*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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