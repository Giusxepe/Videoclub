using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Channels;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosVideoclub
{
    public partial class _Default : Page
    {
        HttpCookie cookieMultiple = new HttpCookie("Multiple");
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if(Session["nombre"] != null)
                {

                    string nombre = Session["nombre"].ToString();
                    lblBienvenido.Text = "Bienvenido " + nombre;
                }

                //Response.Redirect("Loguin.aspx");
            }
            catch(Exception ex)
            {

               Response.Redirect("Loguin.aspx?men=1");
                throw ex;
            }
            buscar1();
        }

        public void buscar1()
        {
            wsTransacciones.wsTransacciones obwsTransax = new wsTransacciones.wsTransacciones();
            DataSet ds = obwsTransax.GetDataTrans();
            GVtran.DataSource = ds.Tables[0];
            GVtran.DataBind();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                wsTransacciones.wsTransacciones obwsTransax = new wsTransacciones.wsTransacciones();
                string fehca = txtTransac.Text;
                DataSet ds =obwsTransax.BuscarTransaccion(Convert.ToInt32(fehca));
                GVtran.DataSource = ds.Tables[0];
                GVtran.DataBind();
                if (ds.Tables[0].Rows.Count == 1)
                {

                    Response.Write("<Script Language='JavaScript'>parent.alert('Registro  encontrado');</Script>");

                }
                else if (ds.Tables[0].Rows.Count == 0)
                {
                    Response.Write("<Script Language='JavaScript'>parent.alert('Registro no encontrado');</Script>");
                   buscar1();

                }

            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }

            if (txtTransac.Text.Equals(" "))
            {
                wsTransacciones.wsTransacciones obwsTransax = new wsTransacciones.wsTransacciones();
                DataSet ds = obwsTransax.GetDataTrans();
                GVtran.DataSource = ds.Tables[0];
                GVtran.DataBind();
            }
        }

        protected void GVtran_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GVtran.PageIndex = e.NewPageIndex;
            wsTransacciones.wsTransacciones obwsTransax = new wsTransacciones.wsTransacciones();
            DataSet ds = obwsTransax.GetDataTrans();
            GVtran.DataSource = ds.Tables[0];
            GVtran.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Response.Cookies["Multiple"]["idtran"] = txtIdTran.Text;
            Response.Cookies["Multiple"]["idprod"] = txtIdProd.Text;
            Response.Cookies["Multiple"]["idclien"] = txtIdCliente.Text;
            Response.Cookies["Multiple"]["tipotran"] = txtTipoTran.Text;
            Response.Cookies["Multiple"]["total"] = txtTotal.Text;
            Response.Cookies["Multiple"].Expires = DateTime.Now.AddDays(1);
            string cadena;
            cadena = Request.Cookies["Multiple"]["idtran"];
            cadena = cadena + "Id producto: " + Request.Cookies["Multiple"]["idprod"];
            cadena = cadena + " Id cliente: " + Request.Cookies["Multiple"]["idclien"];
            cadena = cadena + "Tipo de transaccio: " + Request.Cookies["Multiple"]["tipotran"];
            cadena = cadena + "Total de transaccion: " + Request.Cookies["Multiple"]["total"];

            Label1.Text = "ID transaccion: "+cadena;
            try
            {
                wsTransacciones.wsTransacciones obwsTranx = new wsTransacciones.wsTransacciones();
                string stMensaje = obwsTranx.stInsertarTransacciones(Convert.ToInt64(txtIdTran.Text),Convert.ToInt64(txtIdProd.Text), Convert.ToInt64(txtIdEmpl.Text), Convert.ToInt64(txtIdCliente.Text),
                   txtTipoTran.Text,Convert.ToInt64( txtCant.Text), txtFecha.Text,Convert.ToInt64(txtMxDia.Text),Convert.ToInt64(txtDiasRen.Text),txtFechaEntrega.Text,Convert.ToInt64(txtTotal.Text));

                Response.Write("<Script Language='JavaScript'>parent.alert('Registro insertado correctamente');</Script>");
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

                wsTransacciones.wsTransacciones obwsTranx = new wsTransacciones.wsTransacciones();
                

                string stMensaje = obwsTranx.eliminarTransaccion(Convert.ToInt32(txtIdTran.Text));
                Response.Write("<Script Language='JavaScript'>parent.alert('" + stMensaje + "');</Script>");
            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
        }

        protected void btnAct_Click(object sender, EventArgs e)
        {
            try
            {
                wsTransacciones.wsTransacciones obwsTranx = new wsTransacciones.wsTransacciones();
                string stMensaje = obwsTranx.actualizarTransaccion(Convert.ToInt64(txtIdTran.Text), Convert.ToInt64(txtIdProd.Text), Convert.ToInt64(txtIdEmpl.Text), Convert.ToInt64(txtIdCliente.Text),
                   txtTipoTran.Text, Convert.ToInt64(txtCant.Text), txtFecha.Text, Convert.ToInt64(txtMxDia.Text), Convert.ToInt64(txtDiasRen.Text), txtFechaEntrega.Text, Convert.ToInt64(txtTotal.Text));

                Response.Write("<Script Language='JavaScript'>parent.alert('" + stMensaje + "');</Script>");
            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }
        }

        protected void bntCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("nombre");
            Response.Redirect("Loguin.aspx");
        }
    }
}