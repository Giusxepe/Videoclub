using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosVideoclub
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargar();
            
        }

        public void cargar()
        {
            wsClientes.wsClientes obwsClientes = new wsClientes.wsClientes();
            DataSet ds = obwsClientes.GetData();
            GvClientes.DataSource = ds.Tables[0];
            GvClientes.DataBind();

        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                wsClientes.wsClientes obwsClientes = new wsClientes.wsClientes();
                string stMensaje = obwsClientes.stInsertarClientes(Convert.ToInt64(txtIDcliente.Text),
                    txtNombreCliente.Text, txtApaterno.Text, txtAmaterno.Text, txtDir.Text, txtEmail.Text, txtTel.Text, txtFecha.Text);

                Response.Write("<Script Language='JavaScript'>parent.alert('" + stMensaje + "');</Script>");
            }
            catch(Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
           
        }

        protected void txtNombre_TextChanged(object sender, EventArgs e)
        {
        
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                wsClientes.wsClientes obwsClientes = new wsClientes.wsClientes();
                string nombre = txtNombre.Text;
                DataSet ds = obwsClientes.Buscar(nombre);
                GvClientes.DataSource = ds.Tables[0];
                GvClientes.DataBind();
                if (ds.Tables[0].Rows.Count == 1)
                {
                    
                    Response.Write("<Script Language='JavaScript'>parent.alert('Registro encontrado');</Script>");
                    
                }
                else if (ds.Tables[0].Rows.Count == 0)
                {
                    Response.Write("<Script Language='JavaScript'>parent.alert('Registro no encontrado');</Script>");
                    cargar();
               
                }
            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }

        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                wsClientes.wsClientes obwsClientes = new wsClientes.wsClientes();
                string stMensaje = obwsClientes.actualizar(Convert.ToInt64(txtIDcliente.Text),
                    txtNombreCliente.Text, txtApaterno.Text, txtAmaterno.Text, txtDir.Text, txtEmail.Text, txtTel.Text, txtFecha.Text);

                Response.Write("<Script Language='JavaScript'>parent.alert('" + stMensaje + "');</Script>");
            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                wsClientes.wsClientes obwsClientes = new wsClientes.wsClientes();
                string stMensaje = obwsClientes.eliminar(Convert.ToInt64(txtIDcliente.Text));

                Response.Write("<Script Language='JavaScript'>parent.alert('" + stMensaje + "');</Script>");
            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
        }

        protected void GvClientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GvClientes.PageIndex = e.NewPageIndex;
            wsClientes.wsClientes obwsClientes = new wsClientes.wsClientes();
            DataSet ds = obwsClientes.GetData();
            GvClientes.DataSource = ds.Tables[0];
            GvClientes.DataBind();
        }
    }
}