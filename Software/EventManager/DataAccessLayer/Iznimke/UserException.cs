using DataAccessLayer.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class UserException : EventManagerException
    {
        public UserException(string poruka) : base(poruka)
        {
        }
    }
}
