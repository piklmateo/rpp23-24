using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Exceptions;

namespace DataAccessLayer.Iznimke
{
    public class PictureException : EventManagerException
    {
        public PictureException(string poruka) : base(poruka)
        {
        }
    }
}
