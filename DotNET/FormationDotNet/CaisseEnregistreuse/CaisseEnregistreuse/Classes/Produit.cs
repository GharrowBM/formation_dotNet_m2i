using System;
namespace CaisseEnregistreuse.Classes
{
    public class Produit
    {
        private int id;
        private string titre;
        private decimal prix;
        private int stock;
        private static int compteur = 0;

        public Produit(string titre, decimal prix, int stock)
        {
            id = ++compteur;
            Titre = titre;
            Prix = prix;
            Stock = stock;
        }

        public int Id { get => id; }
        public string Titre { get => titre; set => titre = value; }
        public decimal Prix { get => prix; set => prix = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
