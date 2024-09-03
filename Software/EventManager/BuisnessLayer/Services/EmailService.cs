using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;

namespace BuisnessLayer.Services
{
    ///<author>Toni Leo Modrić Dragičević</author>
    public class EmailService
    {
        EmailRepository emailRepository = new EmailRepository();
        public void SendEmail(string recipientEmail, string body, string subject)
        {
            emailRepository.SendEmail(recipientEmail, body, subject);
        }
    }
}
