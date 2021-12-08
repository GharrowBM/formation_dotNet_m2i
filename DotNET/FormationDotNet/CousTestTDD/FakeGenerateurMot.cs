using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpPendu.Classes;

namespace CousTestTDD
{
    public class FakeGenerateurMot : IGenerateur
    {
        public string Generer()
        {
            return "toto";
        }
    }
}
