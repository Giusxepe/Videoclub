using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosVideoclub
{
    public partial class Productoss : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            wsProductos.wsProductos obwsProd = new wsProductos.wsProductos();
            DataSet ds = obwsProd.verProductos();
            GVprod.DataSource = ds.Tables[0];
            GVprod.DataBind();

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                wsProductos.wsProductos obwsProd = new wsProductos.wsProductos();
                string stMensaje =obwsProd.insertarProducto(Convert.ToInt32(txtIdProd.Text),Convert.ToInt32(txtIdProv.Text),
                   txtTipo.Text,txtNombre.Text,txtAño.Text,txtGenero.Text,txtPublico.Text, Convert.ToInt32(txtCantidad.Text),txtFecha.Text);

                Response.Write("<Script Language='JavaScript'>parent.alert('Registro insertado correctamente');</Script>");
            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                wsProductos.wsProductos obwsProd = new wsProductos.wsProductos();
                string id = txtProd.Text;
                DataSet ds = obwsProd.Buscar(Convert.ToInt32(id));
                GVprod.DataSource = ds.Tables[0];
                GVprod.DataBind();
                if (ds.Tables[0].Rows.Count == 1)
                {

                    Response.Write("<Script Language='JavaScript'>parent.alert('Registro  encontrado');</Script>");

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
                wsProductos.wsProductos obwsProd = new wsProductos.wsProductos();
                string stMensaje = obwsProd.actualizar(Convert.ToInt32(txtIdProd.Text), Convert.ToInt32(txtIdProv.Text),
                   txtTipo.Text, txtNombre.Text, txtAño.Text, txtGenero.Text, txtPublico.Text, Convert.ToInt32(txtCantidad.Text), txtFecha.Text);

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
                wsProductos.wsProductos obwsProd = new wsProductos.wsProductos();
                string stMensaje = obwsProd.eliminar(Convert.ToInt32(txtIdProd.Text));

                Response.Write("<Script Language='JavaScript'>parent.alert('" + stMensaje + "');</Script>");
            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
        }

        protected void GVprod_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVprod.PageIndex = e.NewPageIndex;
            wsProductos.wsProductos obwsProd = new wsProductos.wsProductos();
            DataSet ds = obwsProd.verProductos();
            GVprod.DataSource = ds.Tables[0];
            GVprod.DataBind();
        }
    }
}