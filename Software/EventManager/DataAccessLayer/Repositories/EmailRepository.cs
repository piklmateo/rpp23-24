using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Iznimke;

namespace DataAccessLayer.Repositories
{
    ///<author>Toni Leo Modrić Dragičević</author>
    public class EmailRepository
    {
        public void SendEmail(string recipientEmail, string body, string subject)
        {
            string senderEmail = "tmodricdr20test@gmail.com";
            string password = "djqj tgqc tpqt shfj";

            using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
            using (MailMessage mailMessage = new MailMessage(senderEmail, recipientEmail, subject, body))
            {
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(senderEmail, password);
                smtpClient.EnableSsl = true;

                try
                {
                    smtpClient.Send(mailMessage);
                }
                catch (MessageException ex)
                {
                    throw new MessageException("Error sending email: " + ex);
                }
            }
        }
    }
}
