using System;
namespace CaisseEnregistreuse.Classes
{
    public class IHM
    {
        private Caisse caisse;
        private Vente vente;
        public IHM()
        {
            caisse = new Caisse();
        }

        public void Demarrer()
        {

        }

        private void MenuPrincipal()
        {
            Console.WriteLine("1- Ajouter un produit");
            Console.WriteLine("2- Faire une vente");
            Console.WriteLine("0- Quitter");
        }

        private void MenuVente()
        {
            Console.WriteLine("1- Ajouter un produit à la vente");
            Console.WriteLine("2- Paiement CB");
            Console.WriteLine("3- Paiement Espece");
        }

        private void ActionAjouterProduit()
        {

        }

        private void ActionFaireUneVente()
        {

        }

        private void ActionAjoutProduitVente()
        {

        }

        private void ActionPaiementCB()
        {

        }
        private void ActionPaiementEspece()
        {

        }
    }
}
