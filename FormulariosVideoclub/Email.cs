using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace FormulariosVideoclub
{
    public class Email
    {
        MailMessage m = new MailMessage();
        SmtpClient smtp = new SmtpClient();

        public bool enviarcorreo( string from,string password, string to, string mensaje)
        {
            try
            {
                m.From = new MailAddress(from);
                m.To.Add(new MailAddress(to));
                m.Subject = "Videoclub";
                m.Body = mensaje;
                smtp.Host = "smtp.live.com";
                smtp.Port = 587;
                smtp.Credentials = new NetworkCredential(from, password);
                smtp.EnableSsl = true;
                smtp.Send(m);


                //m.IsBodyHtml = true;



                return true;
            }
            catch(Exception ex)
            {
                return false;
                throw ex;
                
            }
        }
    }
}