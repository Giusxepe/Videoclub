using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDatos.WS
{
    /// <summary>
    /// Descripción breve de wsTransacciones
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsTransacciones : System.Web.Services.WebService
    {

        [WebMethod]
        public string stInsertarTransacciones(long id_tran, long id_producto, long id_empleado, long id_cliente, string Tipo_tran, long Cantidad,
            string fecha_registro, long MontoxDia, long Dias_renta, string fecha_entrega, long Total)
        {
            try
            {
                Logica.Clases.clsTransacciones bclsTransaccion = new Logica.Clases.clsTransacciones();
                return bclsTransaccion.stInsertarTransaccion(id_tran, id_producto, id_empleado, id_cliente, Tipo_tran, Cantidad, fecha_registro, MontoxDia, Dias_renta, fecha_entrega, Total);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetDataTrans()
        {
            try
            {

                Logica.Clases.clsTransacciones bclsTransaccion = new Logica.Clases.clsTransacciones();
                return bclsTransaccion.GetDataTrans();
            }
            catch (Exception ex)
            { throw ex; }
        }

        [WebMethod]
        public DataSet BuscarTransaccion(int id_tran)
        {

            try
            {

                Logica.Clases.clsTransacciones bclsTransaccion = new Logica.Clases.clsTransacciones();
                return bclsTransaccion.BuscarTransaccion(id_tran);
            }
            catch (Exception ex)
            { throw ex; }

        }

        [WebMethod]
        public string actualizarTransaccion(long id_tran, long id_producto, long id_empleado, long id_cliente, string Tipo_tran, long Cantidad,
            string fecha_registro, long MontoxDia, long Dias_renta, string fecha_entrega, long Total)
        {
            try
            {
                Logica.Clases.clsTransacciones bclsTransaccion = new Logica.Clases.clsTransacciones();
                return bclsTransaccion.actualizarTransax(id_tran, id_producto, id_empleado, id_cliente, Tipo_tran, Cantidad, fecha_registro, MontoxDia, Dias_renta, fecha_entrega, Total);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        [WebMethod]
        public string eliminarTransaccion(int id_transaccion)
        {
            try
            {
                Logica.Clases.clsTransacciones bclsTransaccion = new Logica.Clases.clsTransacciones();
                return bclsTransaccion.eliminarTran(id_transaccion);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
