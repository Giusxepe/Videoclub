using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceDatos.Logica.Clases
{
    public class clsProductos
    {

        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter sqlParameter = null;
      
        string stConexion;
        public clsProductos()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        public string insertarProductos(int id_producto, int id_proovedor, string tipo_prod,string nombre,string año,string genero, string tipo_publico,int cantidad, string fecha_registro)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("spProductos", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_producto",id_producto));
                sqlCommand.Parameters.Add(new SqlParameter("@id_proovedor",id_proovedor));
                sqlCommand.Parameters.Add(new SqlParameter("@tipo_prod",tipo_prod));
                sqlCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
                sqlCommand.Parameters.Add(new SqlParameter("@año", año));
                sqlCommand.Parameters.Add(new SqlParameter("@genero", genero));
                sqlCommand.Parameters.Add(new SqlParameter("@tipo_publico", tipo_publico));
                sqlCommand.Parameters.Add(new SqlParameter("@cantidad", cantidad));
                sqlCommand.Parameters.Add(new SqlParameter("@fecha_registro", fecha_registro));

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Mensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 50;
                sqlParameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();

                return sqlParameter.Value.ToString();





            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }


        public DataSet verDatos()
        {
            try
            {

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM productos WHERE Existencia= 1", stConexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }

        public DataSet Buscar(long id_prod)
        {
            try
            {

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM productos WHERE id_producto='" + id_prod + "' AND Existencia=1", stConexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }

        public string acualizar(int id_producto, int id_proovedor, string tipo_prod, string nombre, string año, string genero, string tipo_publico, int cantidad, string fecha_registro)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("actualizarProd", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_producto", id_producto));
                sqlCommand.Parameters.Add(new SqlParameter("@id_proovedor", id_proovedor));
                sqlCommand.Parameters.Add(new SqlParameter("@tipo_prod", tipo_prod));
                sqlCommand.Parameters.Add(new SqlParameter("@nombre", nombre));
                sqlCommand.Parameters.Add(new SqlParameter("@año", año));
                sqlCommand.Parameters.Add(new SqlParameter("@genero", genero));
                sqlCommand.Parameters.Add(new SqlParameter("@tipo_publico", tipo_publico));
                sqlCommand.Parameters.Add(new SqlParameter("@cantidad", cantidad));
                sqlCommand.Parameters.Add(new SqlParameter("@fecha_registro", fecha_registro));

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Mensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 50;
                sqlParameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();
                return sqlParameter.Value.ToString();

            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }

        public string eliminar(int id)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("EliminarProducto", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_producto", id));

                sqlParameter = new SqlParameter();
                sqlParameter.ParameterName = "@Mensaje";
                sqlParameter.SqlDbType = SqlDbType.VarChar;
                sqlParameter.Size = 50;
                sqlParameter.Direction = ParameterDirection.Output;
                sqlCommand.Parameters.Add(sqlParameter);
                sqlCommand.ExecuteNonQuery();
                return sqlParameter.Value.ToString();
            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }


       
    }
}
