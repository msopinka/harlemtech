using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace HarlemTech.DataAccess.Helpers
{
    public class EmailHelper
    {
        public static void SendEmail(string name, string email, string message)
        {
            try
            {
                using(var smtpClient = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("msopinka@gmail.com", "");

                    var from = new MailAddress("msopinka@gmail.com", "HarlemTech");
                    var to = new MailAddress("msopinka@gmail.com", "msopinka@gmail.com");
                    var mailMessage = new MailMessage(from, to);

                    mailMessage.Body = string.Format("{0}<br>{1}<br>{2}", name, email, message);
                    mailMessage.IsBodyHtml = true;
                    mailMessage.Subject = "[FORM] HarlemTech Tip Received";

                    smtpClient.Send(mailMessage);
                }
            }
            catch(Exception ex)
            {
            }
        }
    }
}
