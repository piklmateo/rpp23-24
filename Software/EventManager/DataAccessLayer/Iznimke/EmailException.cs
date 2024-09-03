using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Exceptions;

namespace DataAccessLayer.Iznimke
{
    public class EmailException : EventManagerException
    {
        public EmailException(string poruka) : base(poruka)
        {
        }
    }
}
