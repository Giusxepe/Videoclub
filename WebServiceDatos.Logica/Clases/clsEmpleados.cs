using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceDatos.Logica.Clases
{
    public class clsEmpleados
    {

        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter sqlParameter = null;
       
        string stConexion;
        public clsEmpleados()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        public string insertarEmpleado(int id_empleado, string nombre, 
        string Ap, string Am, int edad, string puesto, int sxdia, 
        string calle, string colonia, int ncasa, string fr)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("spInsertarEmpleados", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_empleado", id_empleado));
                sqlCommand.Parameters.Add(new SqlParameter("@Nombre_empleado",nombre));
                sqlCommand.Parameters.Add(new SqlParameter("@Apellido_paterno", Ap));
                sqlCommand.Parameters.Add(new SqlParameter("@Apellido_materno",Am));
                sqlCommand.Parameters.Add(new SqlParameter("@edad", edad));
                sqlCommand.Parameters.Add(new SqlParameter("@puesto", puesto));
                sqlCommand.Parameters.Add(new SqlParameter("@salarioxdia", sxdia));
                sqlCommand.Parameters.Add(new SqlParameter("@calle", calle));
                sqlCommand.Parameters.Add(new SqlParameter("@colonia", colonia));
                sqlCommand.Parameters.Add(new SqlParameter("@Ncasa", ncasa));
                sqlCommand.Parameters.Add(new SqlParameter("@fecha_registro", fr));
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


        public DataSet VerEmpleados()
        {
            try
            {

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM empleados", stConexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }

        public DataSet BuscarEmpleado(int id)
        {
            try
            {

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM empleados WHERE id_empleado='" + id + "'", stConexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }

        public string acualizar(int id_empleado, string nombre,
        string Ap, string Am, int edad, string puesto, int sxdia,
        string calle, string colonia, int ncasa, string fr)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("actualizarEmpl", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_empleado", id_empleado));
                sqlCommand.Parameters.Add(new SqlParameter("@Nombre_empleado", nombre));
                sqlCommand.Parameters.Add(new SqlParameter("@Apellido_paterno", Ap));
                sqlCommand.Parameters.Add(new SqlParameter("@Apellido_materno", Am));
                sqlCommand.Parameters.Add(new SqlParameter("@edad", edad));
                sqlCommand.Parameters.Add(new SqlParameter("@puesto", puesto));
                sqlCommand.Parameters.Add(new SqlParameter("@salarioxdia", sxdia));
                sqlCommand.Parameters.Add(new SqlParameter("@calle", calle));
                sqlCommand.Parameters.Add(new SqlParameter("@colonia", colonia));
                sqlCommand.Parameters.Add(new SqlParameter("@Ncasa", ncasa));
                sqlCommand.Parameters.Add(new SqlParameter("@fecha_registro", fr));

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

                sqlCommand = new SqlCommand("EliminarEmpleado", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_empleado", id));

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
