using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Exceptions
{
    public class EventManagerException : ApplicationException
    {
        public string Poruka { get; set; }
        public EventManagerException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
