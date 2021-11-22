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
            string choix;
            do
            {
                MenuPrincipal();
                choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "1":
                        ActionAjouterProduit();
                        break;
                    case "2":
                        break;
                    default:
                        break;
                }
            } while (choix != "0");
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
            Console.Write("Titre produit : ");
            string titre = Console.ReadLine();
            
            decimal prix;
            CustomDecimalTryParseLoop("Merci de saisir le prix : ", out prix);
            //Console.Write("Prix du produit : ");
            //decimal prix = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Stock initial : ");
            int stock = Convert.ToInt32(Console.ReadLine());
            Produit produit = new Produit(titre, prix, stock);
            if(caisse.AjouterProduit(produit))
            {
                Console.WriteLine("Produit ajouté");
            }
            else
            {
                Console.WriteLine("Erreur d'ajout produit");
            }
        }

        private void ActionFaireUneVente()
        {
            vente = new Vente();
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

        private void CustomDecimalTryParseLoop(string message, out decimal element)
        {
            bool error;
            do
            {
                try
                {
                    Console.Write(message);
                    element = Convert.ToDecimal(Console.ReadLine());
                    error = false;
                }catch(FormatException ex)
                {
                    Console.WriteLine("Impossible de convertir votre chaine de caractère en decimal");
                    error = true;
                    element = 0;
                }
                
            } while (error);
        }
    }
}
