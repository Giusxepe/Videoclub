using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDatos.WS
{
    /// <summary>
    /// Descripción breve de wsProductos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsProductos : System.Web.Services.WebService
    {
        [WebMethod]
        public string insertarProducto(int id_producto, int id_proovedor, string tipo_prod, string nombre, string año, string genero, string tipo_publico, int cantidad, string fecha_registro)
        {
            try
            {
                Logica.Clases.clsProductos obclsProd = new Logica.Clases.clsProductos();
                return obclsProd.insertarProductos(id_producto, id_proovedor, tipo_prod, nombre, año, genero,tipo_publico,cantidad, fecha_registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet verProductos()
        {
            try
            {

                Logica.Clases.clsProductos obclsProd = new Logica.Clases.clsProductos();
                return obclsProd.verDatos();
            }
            catch (Exception ex)
            { throw ex; }
        }


        [WebMethod]
        public DataSet Buscar(long id)
        {

            try
            {

                Logica.Clases.clsProductos obclsProd = new Logica.Clases.clsProductos();
                return obclsProd.Buscar(id);
            }
            catch (Exception ex)
            { throw ex; }

        }

        [WebMethod]
        public string actualizar(int id_producto, int id_proovedor, string tipo_prod, string nombre, string año, string genero, string tipo_publico, int cantidad, string fecha_registro)
        {
            try
            {
                Logica.Clases.clsProductos obclsProd = new Logica.Clases.clsProductos();
                return obclsProd.acualizar(id_producto, id_proovedor, tipo_prod, nombre, año, genero, tipo_publico, cantidad, fecha_registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public string eliminar(int id)
        {
            try
            {
                Logica.Clases.clsProductos obclsProd = new Logica.Clases.clsProductos();
                return obclsProd.eliminar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
