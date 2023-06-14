using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceDatos.Logica.Clases
{
    public class clsTransacciones
    {
        SqlCommand sqlCommand = null;
        SqlConnection sqlConnection = null;
        SqlParameter sqlParameter = null;
   
        string stConexion;
        public clsTransacciones()
        {
            clsConexion obclsConexion = new clsConexion();
            stConexion = obclsConexion.getConexion();
        }

        public string stInsertarTransaccion(long id_tran, long id_producto, long id_empleado, long id_cliente, string Tipo_tran, long Cantidad,
            string fecha_registro, long MontoxDia, long Dias_renta, string fecha_entrega, long Total)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("spTransacciones", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_transaccion", id_tran));
                sqlCommand.Parameters.Add(new SqlParameter("@id_producto", id_producto));
                sqlCommand.Parameters.Add(new SqlParameter("@id_empleado", id_empleado));
                sqlCommand.Parameters.Add(new SqlParameter("@id_cliente", id_cliente));
                sqlCommand.Parameters.Add(new SqlParameter("@Tipo_transaccion", Tipo_tran));
                sqlCommand.Parameters.Add(new SqlParameter("@cantidad", Cantidad));
                sqlCommand.Parameters.Add(new SqlParameter("@fecha", fecha_registro));
                sqlCommand.Parameters.Add(new SqlParameter("@monto_dia", MontoxDia));
                sqlCommand.Parameters.Add(new SqlParameter("@dias_renta", Dias_renta));
                sqlCommand.Parameters.Add(new SqlParameter("@fecha_entrega", fecha_entrega));
                sqlCommand.Parameters.Add(new SqlParameter("@total", Total));

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

        public DataSet GetDataTrans()
        {
            try
            {

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  transacciones.id_transaccion, clientes.nombre AS NombreCliente, clientes.apellido_p, clientes.apellido_m, productos.tipo, productos.nombre AS Nombre_producto, transacciones.tipo_transaccion,  transacciones.cantidad, transacciones.fecha, transacciones.total, transacciones.dias_renta, transacciones.monto_dia, transacciones.fecha_entrega FROM            clientes INNER JOIN transacciones ON clientes.id_cliente = transacciones.id_cliente INNER JOIN empleados ON transacciones.id_empleado = empleados.id_empleado INNER JOIN productos ON transacciones.id_producto = productos.id_producto ", stConexion);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }
        }

        public DataSet BuscarTransaccion(int id_tran)
        {
            try
            {

                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT  transacciones.id_transaccion, clientes.nombre AS NombreCliente, clientes.apellido_p, clientes.apellido_m, productos.tipo, productos.nombre AS Nombre_producto, transacciones.tipo_transaccion,  transacciones.cantidad, transacciones.fecha, transacciones.total, transacciones.dias_renta, transacciones.monto_dia, transacciones.fecha_entrega FROM            clientes INNER JOIN transacciones ON clientes.id_cliente = transacciones.id_cliente INNER JOIN empleados ON transacciones.id_empleado = empleados.id_empleado INNER JOIN productos ON transacciones.id_producto = productos.id_producto" , stConexion);
                DataSet ds = new DataSet();
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            { throw ex; }
            finally { sqlConnection.Close(); }

        }

        public string actualizarTransax(long id_tran, long id_producto, long id_empleado, long id_cliente, string Tipo_tran, long Cantidad,
            string fecha_registro, long MontoxDia, long Dias_renta, string fecha_entrega, long Total)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("actualizarTrans", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_transaccion", id_tran));
                sqlCommand.Parameters.Add(new SqlParameter("@id_producto", id_producto));
                sqlCommand.Parameters.Add(new SqlParameter("@id_empleado", id_empleado));
                sqlCommand.Parameters.Add(new SqlParameter("@id_cliente", id_cliente));
                sqlCommand.Parameters.Add(new SqlParameter("@Tipo_transaccion", Tipo_tran));
                sqlCommand.Parameters.Add(new SqlParameter("@cantidad", Cantidad));
                sqlCommand.Parameters.Add(new SqlParameter("@fecha", fecha_registro));
                sqlCommand.Parameters.Add(new SqlParameter("@monto_dia", MontoxDia));
                sqlCommand.Parameters.Add(new SqlParameter("@dias_renta", Dias_renta));
                sqlCommand.Parameters.Add(new SqlParameter("@fecha_entrega", fecha_entrega));
                sqlCommand.Parameters.Add(new SqlParameter("@total", Total));

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

        public string eliminarTran(int id_transaccion)
        {
            try
            {
                sqlConnection = new SqlConnection(stConexion);
                sqlConnection.Open();

                sqlCommand = new SqlCommand("EliminarTransaccion", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@id_transaccion",id_transaccion));

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
