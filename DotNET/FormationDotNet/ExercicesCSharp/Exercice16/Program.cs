using System;

namespace Exercice16
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Déclaration des variables
            double revenus = 0;
            int nbAdulte = 0;
            int nbEnfants = 0;
            double nbParts;
            double revenuImposable = 0;
            double montantImpot = 0;
            #endregion

            #region Récupération des saisies Utilisateur
            Console.WriteLine("--- Quelle sera le montant des mes impôts ? --- \n");
            Console.Write("Entrez le montant net imposable du foyer (en Euros): ");
            revenus = Convert.ToDouble(Console.ReadLine());
            Console.Write("Entrez le nombre d'adulte du foyer : ");
            nbAdulte = Convert.ToInt32(Console.ReadLine());
            Console.Write("Entrez le nombre d'enfants du foyer : ");
            nbEnfants = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            #endregion

            #region Calcul du nombre de parts du foyer            
            if (nbEnfants <= 2)
                nbParts = nbAdulte + nbEnfants * 0.5;
            else
                nbParts = nbAdulte + nbEnfants - 1;
            #endregion

            #region Sugar Syntaxe (ternaire) pour le Calcul du nombre de parts
            //nbParts = nbEnfants <= 2 ? nbAdulte + nbEnfants * 0.5 : nbAdulte + nbEnfants - 1;
            #endregion

            #region Calcul du montant de l'impôt            
            revenuImposable = revenus / nbParts;

            if (revenuImposable >= 10085 && revenuImposable <= 25710)
                montantImpot = Math.Round((revenuImposable - 10084) * 0.11,0);
            else if (revenuImposable >= 25711 && revenuImposable <= 73516)
                montantImpot = Math.Round((revenuImposable - 25711) * 0.30 + (25711 - 10085) * 0.11 ,0);
            else if (revenuImposable >= 73517 && revenuImposable <= 158122)
                montantImpot = Math.Round((revenuImposable - 73516) * 0.41 + (73516 - 25710) * 0.30 + (25711 - 10085) * 0.11 ,0);
            else if (revenuImposable >= 158123)
                montantImpot = Math.Round((revenuImposable - 158122) * 0.45 + (158122 - 73516) * 0.41 + (73516 - 25710) * 0.30 + (25711 - 10085) * 0.11 ,0);
            montantImpot = montantImpot * nbParts;
            #endregion

            #region Sugar syntaxe pour le calcul des impôts
            //revenuImposable = revenus / nbParts;
            //if (revenuImposable > 10064)
            //{
            //    montantImpot += (revenuImposable > 25659) ? ((revenuImposable > 73369) ? ((revenuImposable > 157806) ?
            //    ((revenuImposable - 157806) * 0.45) + ((157806 - 73369) * 0.41) + ((73369 - 25659) * 0.3) + ((25659 - 10064) * 0.11)
            //    : ((revenuImposable - 73369) * 0.41) + ((73369 - 25659) * 0.3) + ((25659 - 10064) * 0.11))
            //    : ((revenuImposable - 25659) * 0.3) + ((25659 - 10064) * 0.11))
            //    : (revenuImposable - 10064) * 0.11;
            //}
            //montantImpot = Math.Round(montantImpot * nbParts,2);
            #endregion

            #region Affichage des résultats
            Console.WriteLine("Vous allez payer " + montantImpot + " Euros\n");
            #endregion

        }
    }
}
