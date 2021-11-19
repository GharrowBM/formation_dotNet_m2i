using System;
using CoursPOO.Interfaces;

namespace CoursPOO
{
    public class Transporteur
    {
        private IVolant _volant;
        public Transporteur(IVolant volant)
        {
            _volant = volant;
        }

        public void Transporter()
        {
            _volant.Voler();
        }
    }
}
