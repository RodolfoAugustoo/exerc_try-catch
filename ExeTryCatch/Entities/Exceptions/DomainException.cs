using System;
using System.Collections.Generic;
using System.Text;

namespace ExeTryCatch.Entities.DomainExceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message) { }
    }
}
