using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleMVC.Data.Exceptions
{
    public class CreationException : Exception
    {

        public CreationException(string msg) : base(msg)
        {

        }
    }
}
