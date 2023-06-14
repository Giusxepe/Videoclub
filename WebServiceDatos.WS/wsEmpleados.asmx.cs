using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDatos.WS
{
    /// <summary>
    /// Descripción breve de wsEmpleados
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsEmpleados : System.Web.Services.WebService
    {

        [WebMethod]
        public string InsertarEmpleado(int id_empleado, string nombre,
        string Ap, string Am, int edad, string puesto, int sxdia,
        string calle, string colonia, int ncasa, string fr)
        {
            try
            {
                Logica.Clases.clsEmpleados obclsEmpleados = new Logica.Clases.clsEmpleados();
                return obclsEmpleados.insertarEmpleado( id_empleado, nombre, Ap,  Am,  edad, puesto, sxdia, calle, colonia, ncasa, fr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet verEmpleados()
        {
            try
            {

                Logica.Clases.clsEmpleados obclsEmpleados = new Logica.Clases.clsEmpleados();
                return obclsEmpleados.VerEmpleados();
            }
            catch (Exception ex)
            { throw ex; }
        }


        [WebMethod]
        public DataSet BuscarEmpleado(int id)
        {

            try
            {

                Logica.Clases.clsEmpleados obclsEmpleados = new Logica.Clases.clsEmpleados();
                return obclsEmpleados.BuscarEmpleado(id);
            }
            catch (Exception ex)
            { throw ex; }

        }

        [WebMethod]
        public string actualizar(int id_empleado, string nombre,
        string Ap, string Am, int edad, string puesto, int sxdia,
        string calle, string colonia, int ncasa, string fr)
        {
            try
            {
                Logica.Clases.clsEmpleados obclsEmpleados = new Logica.Clases.clsEmpleados();
                return obclsEmpleados.acualizar(id_empleado, nombre, Ap, Am, edad, puesto, sxdia, calle, colonia, ncasa, fr);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public string eliminarEmpleado(int id)
        {
            try
            {
                Logica.Clases.clsEmpleados obclsEmpleados = new Logica.Clases.clsEmpleados();
                return obclsEmpleados.eliminar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
