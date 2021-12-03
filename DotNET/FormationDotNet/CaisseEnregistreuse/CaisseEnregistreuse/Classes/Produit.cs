using System;
namespace CaisseEnregistreuse.Classes
{
    public class Produit
    {
        private int id;
        private string titre;
        private decimal prix;
        private int stock;
        //private static int compteur = 0;

        public Produit()
        {

        }
        public Produit(string titre, decimal prix, int stock)
        {
            //id = ++compteur;
            Titre = titre;
            Prix = prix;
            Stock = stock;
        }

        public int Id { get => id; set => id = value; }
        public string Titre
        {
            get => titre;
            set
            {
                if (value.Length > 3)
                    titre = value;
                else
                   throw new FormatException("Le titre doit avoir 3 caractères min");
            }
        }
        public decimal Prix
        {
            get => prix; 
            set
            {
                if (value > 0)
                    prix = value;
                else
                    throw new FormatException("Le prix du produit doit être un nombre positif");
            }
        }
        public int Stock { get => stock; set => stock = value; }
    }
}
