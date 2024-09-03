using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataAccessLayer.Repositories;

namespace BuisnessLayer.Services
{
    ///<author>Toni Leo Modrić Dragičević</author>
    public class MessageService
    {
        MessageRepository messageRepository = new MessageRepository();
        //public int SendMessage(string bodyMessage, string toNumber, string fromNumber)
        //{
        //    var response = messageRepository.SendMessage(bodyMessage, toNumber, fromNumber);
        //    return response;
        //}
    }
}
