using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyect
{
        public class ErrorRedException : Exception
        {
            public ErrorRedException(string mensaje) : base(mensaje) { }
        }
}
