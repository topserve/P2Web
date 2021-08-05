using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Service.Execptions
{
    public class NotFountException : ApplicationException
    {
        public NotFountException(string message) : base(message)
        {

        }
    }
}
