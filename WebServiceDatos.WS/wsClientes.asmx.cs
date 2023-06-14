using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceDatos.WS
{
    /// <summary>
    /// Descripción breve de wsClientes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class wsClientes : System.Web.Services.WebService
    {

        [WebMethod]
        public string stInsertarClientes(long id, string Nombre,
               string Apellido_paterno, string Apellido_materno,
               string Direccion, string Email, string Telefono,
               string fecha_registro)
        {
            try
            {
                Logica.Clases.clsClientes obclsClientes = new Logica.Clases.clsClientes();
                return obclsClientes.stInsertarClientes(id, Nombre, Apellido_paterno, Apellido_materno, Direccion, Email, Telefono, fecha_registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public DataSet GetData()
        {
            try
            {

                Logica.Clases.clsClientes obclsClientes = new Logica.Clases.clsClientes();
                return obclsClientes.GetData();
            }
            catch (Exception ex)
            { throw ex; }
        }


        [WebMethod]
        public DataSet Buscar(string nombre)
        {

            try
            {

                Logica.Clases.clsClientes obclsClientes = new Logica.Clases.clsClientes();
                return obclsClientes.Buscar(nombre);
            }
            catch (Exception ex)
            { throw ex; }

        }

        [WebMethod]
        public string actualizar(long id, string Nombre,
               string Apellido_paterno, string Apellido_materno,
               string Direccion, string Email, string Telefono,
               string fecha_registro)
        {
            try
            {
                Logica.Clases.clsClientes obclsClientes = new Logica.Clases.clsClientes();
                return obclsClientes.acualizar(id, Nombre, Apellido_paterno, Apellido_materno, Direccion, Email, Telefono, fecha_registro);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public string eliminar(long id)
        {
            try
            {
                Logica.Clases.clsClientes obclsClientes = new Logica.Clases.clsClientes();
                return obclsClientes.eliminar(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [WebMethod]
        public bool loguear(string usuario, string contraseña)
        {
            try
            {
                Logica.Clases.clsClientes obclsClientes = new Logica.Clases.clsClientes();
                return obclsClientes.Autenticar(usuario, contraseña);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //transacciones//
       
    }
}
