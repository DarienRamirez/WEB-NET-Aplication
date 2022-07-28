using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WEB_NET_Aplication.models;

namespace WEB_NET_Aplication.data
{
    public class cls_color: cls_connection
    {
        public void Save(model_color model)
        {
            ConnectionSQL();
            try
            {
                SqlCommand query = new SqlCommand("sp_SaveColor", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_colorName", model.name));

                query.ExecuteNonQuery();
                query.Dispose();
            }
            catch (Exception e)

            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconect();
            }
        }
        public void Modify(model_color model)
        {
            ConnectionSQL();
            try
            {
                SqlCommand query = new SqlCommand("sp_ModifyColors", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_colorId", model.id));
                query.Parameters.Add(new SqlParameter("@p_colorName", model.name));
                query.ExecuteNonQuery();
                query.Dispose();
            }
            catch (Exception e)

            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconect();
            }
        }
        public void Delete(int id)
        {
            ConnectionSQL();

            try
            {
                SqlCommand query = new SqlCommand("sp_DeleteColors", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_colorId", id));
                query.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconect();
            }
        }

        public DataTable Get()
        {
            ConnectionSQL();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand query = conn.CreateCommand();
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.CommandText = "sp_GetColors";
                SqlDataAdapter adapter = new SqlDataAdapter(query);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconect();
            }
            return dt;
        }

        public DataTable GetTop(int id)
        {
            ConnectionSQL();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand query = new SqlCommand("sp_GetTopColors", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_colorId", id));

                SqlDataAdapter adapter = new SqlDataAdapter(query);
                dt = new DataTable();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                Desconect();
            }
            return dt;
        }
    }
}