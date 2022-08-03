using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WEB_NET_Aplication.models;

namespace WEB_NET_Aplication.data
{
    public class cls_products:cls_connection
    {
        public void Save(model_products model) 
        {
            ConnectionSQL();
            try
            {
                SqlCommand query = new SqlCommand("sp_SaveProducts", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_productName", model.name));
                query.Parameters.Add(new SqlParameter("@p_productPrice", model.price));
                query.Parameters.Add(new SqlParameter("@p_typeID", model.typeID));
                query.Parameters.Add(new SqlParameter("@p_colorID", model.colorID));
                query.Parameters.Add(new SqlParameter("@p_rating", model.rating));
                query.Parameters.Add(new SqlParameter("@p_productDescription", model.description));
                query.Parameters.Add(new SqlParameter("@p_productImage", model.image));
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
        public DataTable Get()
        {
            ConnectionSQL();
            DataTable dt = new DataTable();

            try
            {
                SqlCommand query = conn.CreateCommand();
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.CommandText = "sp_GetAllProducts";
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
                SqlCommand query = new SqlCommand("sp_GetTopProducts", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_productID", id));
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

        public void Modify(model_products model)
        {
            ConnectionSQL();
            try
            {
                SqlCommand query = new SqlCommand("sp_ModifyProduct", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_productID", model.id));
                query.Parameters.Add(new SqlParameter("@p_productName", model.name));
                query.Parameters.Add(new SqlParameter("@p_productPrice", model.price));
                query.Parameters.Add(new SqlParameter("@p_typeID", model.typeID));
                query.Parameters.Add(new SqlParameter("@p_colorID", model.colorID));
                query.Parameters.Add(new SqlParameter("@p_rating", model.rating));
                query.Parameters.Add(new SqlParameter("@p_productDescription", model.description));
                query.Parameters.Add(new SqlParameter("@p_productImage", model.image));
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
                SqlCommand query = new SqlCommand("sp_DeleteProduct", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_productID", id));
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
    }
}