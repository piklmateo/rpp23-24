using DataAccessLayer.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class TicketException : EventManagerException
    {
        public TicketException(string poruka) : base(poruka)
        {
        }
    }
}
