using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DataAccessLayer.Exceptions;

namespace DataAccessLayer.Iznimke
{
    public class MessageException : EventManagerException
    {
        public MessageException(string poruka) : base(poruka)
        {
        }
    }
}
