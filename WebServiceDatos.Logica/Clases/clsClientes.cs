using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace WebServiceDatos.Logica.Clases
{
    public class clsClientes
    {

        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter sqlParameter = null;
      
        string stConexion;
        public clsClientes()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        public string stInsertarClientes(long id,string Nombre ,
        string Apellido_paterno, string Apellido_materno ,
        string Direccion ,string Email , string Telefono ,
        string fecha_registro)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("spInsertarClientes", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id",id));
                sqlCommand.Parameters.Add(new SqlParameter("@Nombre",Nombre));
                sqlCommand.Parameters.Add(new SqlParameter("@Apellido_paterno",Apellido_paterno));
                sqlCommand.Parameters.Add(new SqlParameter("@Apellido_materno",Apellido_materno));
                sqlCommand.Parameters.Add(new SqlParameter("@Direccion", Direccion));
                sqlCommand.Parameters.Add(new SqlParameter("@Email", Email));
                sqlCommand.Parameters.Add(new SqlParameter("@Telefono",Telefono));
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

        
        public DataSet GetData()
        {
            try
            {

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM clientes", stConexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }

        public DataSet Buscar(string nombre)
        {
            try
            {

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM clientes WHERE nombre='"+nombre+"'", stConexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }

        public string acualizar(long id, string Nombre,
         string Apellido_paterno, string Apellido_materno,
         string Direccion, string Email, string Telefono,
         string fecha_registro)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("actualizar", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id", id));
                sqlCommand.Parameters.Add(new SqlParameter("@Nombre", Nombre));
                sqlCommand.Parameters.Add(new SqlParameter("@Apellido_paterno", Apellido_paterno));
                sqlCommand.Parameters.Add(new SqlParameter("@Apellido_materno", Apellido_materno));
                sqlCommand.Parameters.Add(new SqlParameter("@Direccion", Direccion));
                sqlCommand.Parameters.Add(new SqlParameter("@Email", Email));
                sqlCommand.Parameters.Add(new SqlParameter("@Telefono", Telefono));
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

        public string eliminar(long id)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("EliminarCliente", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_cliente", id));
               
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

        
       public bool Autenticar(string usuario, string password)
       {
                //consulta a la base de datos
                string sql = @"SELECT COUNT(*)
                              FROM usuarios
                              WHERE usuario = @usuario AND contraseña = @contraseña";
                //cadena conexion
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Cnx"].ToString()))
                {
                    conn.Open();//abrimos conexion

                    SqlCommand cmd = new SqlCommand(sql,conn); //ejecutamos la instruccion
                    cmd.Parameters.AddWithValue("@usuario", usuario); //enviamos los parametros
                    cmd.Parameters.AddWithValue("@contraseña", password);


                    Int32 count = (Int32)cmd.ExecuteScalar(); //devuelve la fila afectada

                    if (count == 0)
                        return false;
                    else
                        return true;

                }
        }
    } 
       
}
