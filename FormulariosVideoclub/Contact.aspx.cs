using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosVideoclub
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargar();
        }
        public void cargar()
        {
            wsEmpleados.wsEmpleados obwsEm = new wsEmpleados.wsEmpleados();
            DataSet ds = obwsEm.verEmpleados();
            GVempleados.DataSource = ds.Tables[0];
            GVempleados.DataBind();

        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                wsEmpleados.wsEmpleados obwsEm = new wsEmpleados.wsEmpleados();
                string stMensaje = obwsEm.InsertarEmpleado (Convert.ToInt32(txtID.Text),
                    txtNombre.Text, txtAp.Text, txtAm.Text,Convert.ToInt32( txtEdad.Text), txtPuesto.Text, Convert.ToInt32( txtSxD.Text), txtCalle.Text,txtColonia.Text, Convert.ToInt32(txtNcasa.Text),txtFecha.Text);

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
                wsEmpleados.wsEmpleados obwsEm = new wsEmpleados.wsEmpleados();
                string stMensaje = obwsEm.eliminarEmpleado(Convert.ToInt32(txtID.Text));

                Response.Write("<Script Language='JavaScript'>parent.alert('" + stMensaje + "');</Script>");
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
                wsEmpleados.wsEmpleados obwsEm = new wsEmpleados.wsEmpleados();
                
                DataSet ds = obwsEm.BuscarEmpleado(Convert.ToInt32(txtEmp.Text));
                GVempleados.DataSource = ds.Tables[0];
               GVempleados.DataBind();
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

                wsEmpleados.wsEmpleados obwsEm = new wsEmpleados.wsEmpleados();
                string stMensaje = obwsEm.actualizar(Convert.ToInt32(txtID.Text),
                    txtNombre.Text, txtAp.Text, txtAm.Text, Convert.ToInt32(txtEdad.Text), txtPuesto.Text, Convert.ToInt32(txtSxD.Text), txtCalle.Text, txtColonia.Text, Convert.ToInt32(txtNcasa.Text), txtFecha.Text);


                Response.Write("<Script Language='JavaScript'>parent.alert('" + stMensaje + "');</Script>");
            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
        }

        protected void GVempleados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
             GVempleados.PageIndex = e.NewPageIndex;
            wsEmpleados.wsEmpleados obwsEm = new wsEmpleados.wsEmpleados();
            DataSet ds = obwsEm.verEmpleados();
            GVempleados.DataSource = ds.Tables[0];
           GVempleados.DataBind();
        }
    }
}