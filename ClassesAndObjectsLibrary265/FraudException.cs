using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjectsLibrary265
{
    public class FraudException : Exception
    {
        public FraudException()
            : base() { } //says that this exception inherits from the base Exception (above : Exception)
        public FraudException(string message)
            : base(message) { }
    }
}
