using System.Collections.Generic;

namespace FormationAspNetCoreMVC.Models
{
    public class Adresse
    {
        private int id;
        private string rue;
        private string ville;

        public int Id { get => id; set => id = value; }
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }


        public static List<Adresse> GetAdresses()
        {
            return new List<Adresse>() { new Adresse() };
        }
    }
}
