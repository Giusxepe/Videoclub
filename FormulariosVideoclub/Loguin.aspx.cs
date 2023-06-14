using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FormulariosVideoclub
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //if (!IsPostBack)
            //    if (Request.Cookies["Token"] != null)
            //        txtUsuario.Text = Request.Cookies["Token"].Value;

            //if (Request.Params["men"] != null)
            //{
            //    string men = Request.Params["men"];


            //    if (men == "1")
            //    {
            //        Response.Write("<Script Language='JavaScript'>parent.alert('Primero deve iniciar sesion >:(');</Script>");
            //    }

            //}

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {

            try
            {
                wsClientes.wsClientes obwsClientes = new wsClientes.wsClientes();

                if (obwsClientes.loguear(txtUsuario.Text, txtContra.Text) == true)
                {
                    string susuario = txtUsuario.Text;
                    Session["nombre"] = susuario;
                    if (chbxRecordar.Checked)
                    {
                        HttpCookie cookie = new HttpCookie("Token", txtUsuario.Text);
                        cookie.Expires = DateTime.Now.AddDays(2);
                        this.Response.Cookies.Add(cookie);
                    }
                    else
                    {
                        HttpCookie cookie = new HttpCookie("Token", txtUsuario.Text);
                        cookie.Expires = DateTime.Now.AddDays(-1);
                        this.Response.Cookies.Add(cookie);
                    }



                }
                else
                {
                    Response.Write("<Script Language='JavaScript'>parent.alert('Contraseña o usuario incorrecto, intente de nuevo D:<');</Script>");
                }
            }
            catch (Exception ex)
            {
                Response.Write("<Script Language='JavaScript'>parent.alert('" + ex.Message + "');</Script>");
            }

            Response.Redirect("Default.aspx");


        }
    }
}