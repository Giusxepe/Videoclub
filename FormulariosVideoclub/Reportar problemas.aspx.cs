using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosVideoclub
{
    public partial class Reportar_problemas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            enviarcorrreo();
        }

        public void enviarcorrreo()
        {
            string from = txtEmailForm.Text;
            string pass = txtContraseña.Text;
            string to = txtEmailTo.Text;
            string msn = txtMensaje.Text;

            if(new Email().enviarcorreo(from, pass, to, msn))
            {

                Response.Write("<Script Language='JavaScript'>parent.alert('Correo enviado correctamente');</Script>");
               
                txtEmailForm.Text = string.Empty;
                txtContraseña.Text = string.Empty;
                txtEmailTo.Text = string.Empty;
                txtMensaje.Text = string.Empty;


            }
            else
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('Algo ha salido mal, intente de nuevo.');</Script>");
            }
        }
    }
}