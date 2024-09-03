using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Exceptions
{
    public class EventException : EventManagerException
    {
        public EventException(string poruka) : base(poruka)
        {

        }
    }
}
