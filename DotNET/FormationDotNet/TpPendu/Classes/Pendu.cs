using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPendu.Classes
{
    internal class Pendu
    {
        private int nbEssai;
        private string masque;
        private string motAtrouve;

        public int NbEssai { get => nbEssai;  }
        public string Masque { get => masque;}
        public string MotAtrouve { get => motAtrouve; }

        public Pendu()
        {
            nbEssai = 10;
        }

        public bool TestChar(char c)
        {
            string tmpMasque = "";
            bool test = false;
            for(int i = 0; i < MotAtrouve.Length; i++)
            {
                if(MotAtrouve[i] == c)
                {
                    tmpMasque += c;
                    test = true;
                }
                else
                {
                    tmpMasque += masque[i];
                    
                }
            }
            if(!test)
                nbEssai--;
            masque = tmpMasque;
            return test;
        }

        public bool testWin()
        {
            return NbEssai > 0 && Masque == MotAtrouve;
        }

        public void GenererMasque(string mot)
        {
            motAtrouve = mot;
            masque = "";
            foreach(char c in MotAtrouve)
            {
                masque += "*";
            }
        }
    }
}
