using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPendu.Classes
{
    internal class GenerateurDeMot
    {
        private Random random = new Random();
        private string[] mots = new string[] { "google", "apple", "microsoft", "amazon", "facebook" };

        public string Generer()
        {
            return mots[random.Next(mots.Length)];
        }
    }
}
