using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursPOO.Classes
{
    internal class AgeException : Exception
    {
        public AgeException() : base("Erreur de saisi age")
        {

        }
    }
}
