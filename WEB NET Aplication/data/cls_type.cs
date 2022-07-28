using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WEB_NET_Aplication.models;

namespace WEB_NET_Aplication.data
{
    public class cls_type: cls_connection
    {
        public void Save(model_type model)
        {
            ConnectionSQL();
            try
            {
                SqlCommand query = new SqlCommand("sp_SaveType", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_typeName", model.name));

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
        public void Modify(model_type model)
        {
            ConnectionSQL();
            try
            {
                SqlCommand query = new SqlCommand("sp_ModifyTypes", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_typeId", model.id));
                query.Parameters.Add(new SqlParameter("@p_typeName", model.name));
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
                SqlCommand query = new SqlCommand("sp_DeleteTypes", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_typeID", id));
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
                query.CommandText = "sp_GetTypes";
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
                SqlCommand query = new SqlCommand("sp_GetTopTypes", conn);
                query.CommandType = System.Data.CommandType.StoredProcedure;
                query.Parameters.Add(new SqlParameter("@p_typeID",id));

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