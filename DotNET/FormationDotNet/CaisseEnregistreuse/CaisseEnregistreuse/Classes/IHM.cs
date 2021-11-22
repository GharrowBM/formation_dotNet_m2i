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
                        ActionFaireUneVente();
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
            //Console.Write("Stock initial : ");
            //int stock = Convert.ToInt32(Console.ReadLine());
            int stock;
            CustomIntTryParseLoop("Stock initial : ", out stock);
            try
            {
                Produit produit = new Produit(titre, prix, stock);
                if (caisse.AjouterProduit(produit))
                {
                    Console.WriteLine("Produit ajouté");
                }
                else
                {
                    Console.WriteLine("Erreur d'ajout produit");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void ActionFaireUneVente()
        {
            vente = new Vente();
            string choix;
            do
            {
                MenuVente();
                choix = Console.ReadLine();
                switch (choix)
                {
                    case "1":
                        ActionAjoutProduitVente();
                        break;
                    case "2":
                        ActionPaiementCB();
                        break;
                    case "3":
                        ActionPaiementEspece();
                        break;
                }
            } while (choix != "0");
        }

        private void ActionAjoutProduitVente()
        {
            int produit_id;
            CustomIntTryParseLoop("Merci de saisir l'id du produit : ", out produit_id);
            Produit produit = caisse.RechercherProduit(produit_id);
            if(produit != default(Produit))
            {
                if (vente.AjouterProduit(produit))
                {
                    Console.WriteLine("Produit ajouté à la vente");
                }
            }
            else
            {
                Console.WriteLine("Aucun produit avec cet id");
            }
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

        private void CustomIntTryParseLoop(string message, out int element)
        {
            bool error;
            do
            {
                try
                {
                    Console.Write(message);
                    element = Convert.ToInt32(Console.ReadLine());
                    error = false;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Impossible de convertir votre chaine de caractère en entier");
                    error = true;
                    element = 0;
                }

            } while (error);
        }
    }
}
