using System;

namespace Exercice08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Calcul de la T.V.A et du montant T.T.C ---\n");
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            #region Déclaration des variables
            double prixObjetHt;
            double tauxTva;
            double mtTva;
            double prixObjetTtc;
            #endregion


            #region Récupération des saisies utilisateur
            Console.Write("Entrez le prix HT de l'objet (en €) : ");
            prixObjetHt = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez le taux de TVA (en %) : ");
            tauxTva = Convert.ToDouble(Console.ReadLine())/100;
            #endregion


            #region Calcul du montant de la T.V.A et du prix T.T.C
            mtTva = prixObjetHt * tauxTva;
            prixObjetTtc = prixObjetHt + mtTva;
            #endregion


            #region Affichage des résultats
            Console.WriteLine("Le montant de la T.V.A est de " + mtTva + " €");
            Console.WriteLine("Le prix TTC de l'objet est de " + prixObjetTtc + " €\n");
            #endregion
        }
    }
}
