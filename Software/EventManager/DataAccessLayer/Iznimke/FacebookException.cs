using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Exceptions;

namespace DataAccessLayer.Iznimke
{
    public class FacebookException : EventManagerException
    {
        public FacebookException(string poruka) : base(poruka)
        {
        }
    }
}
