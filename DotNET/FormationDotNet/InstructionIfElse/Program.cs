using System;

namespace InstructionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Structure if avec une seule action
            double compteEnBanque = -100;
            if (compteEnBanque >= 0)
                Console.WriteLine("Votre compte est créditeur");

            // Structure if avec plusieurs actions
            if (compteEnBanque >= 0)
            {
                Console.WriteLine("Votre compte est créditeur");
                Console.WriteLine($"Les solde de votre compte est de {compteEnBanque}€");
            }

            // Plusieur test logiques
            if (compteEnBanque >= 0)
                Console.WriteLine("Votre compte est créditeur");
            else
                Console.WriteLine("Votre compte est débiteur");


            #region Exemple de structure conditionnelle If...Else If... Else avec block d'instructions
            compteEnBanque = 00;
            if (compteEnBanque > 0)
            {
                Console.WriteLine("Votre compte est créditeur");
                Console.WriteLine($"Le montant du compte est : {compteEnBanque}€ ");
            }
            else if (compteEnBanque == 0)
            {
                Console.WriteLine("Votre solde est nul");
                Console.WriteLine($"Le montant du compte est : {compteEnBanque}€");
            }
            else
            {
                Console.WriteLine("Votre compte est débiteur");
                Console.WriteLine($"Le montant du compte est : {compteEnBanque}€");
            }
            #endregion

        }
    }
}
