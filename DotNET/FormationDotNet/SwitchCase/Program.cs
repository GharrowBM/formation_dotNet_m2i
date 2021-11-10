using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cas d'un Switch simple avec string
            ////string civilite = "Mr";
            //string civilite = "Mme";
            ////string civilite = "Mlle";
            ////string civilite = "?";

            //switch (civilite)
            //{
            //    case "Mr":
            //        Console.WriteLine("Bonjour Monsieur");
            //        break;
            //    case "Mme":
            //        Console.WriteLine("Bonjour Madame");
            //        break;
            //    case "Mlle":
            //        Console.WriteLine("Bonjour Mademoiselle");
            //        break;
            //    default:
            //        Console.WriteLine("Bonjour...");
            //        break;
            //}

            //Console.WriteLine("Je suis à l'extérieur du Switch Case String");

            #endregion

            #region Cas d'un Switch simple avec int
            ////int choix = 1;
            ////int choix = 2;
            ////int choix = 3;
            //int choix = 2;

            //switch (choix)
            //{
            //    case 1:
            //        Console.WriteLine("Choix 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("Choix 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("Choix 3");
            //        break;
            //    default:
            //        Console.WriteLine("Bonjour...Faite le bon choix!");
            //        break;
            //}

            //Console.WriteLine("Je suis à l'extérieur du Switch Case Integer");

            //#endregion

            //#region Switch Case avec condition de choix
            //int compte = 00;

            //switch (compte)
            //{
            //    case int w when w > 0 || w == 0:
            //        Console.WriteLine("Votre compte est créditeur ou nul");
            //        break;
            //    case int n when n < 0:
            //        Console.WriteLine("Votre compte est débiteur");
            //        break;
            //    default:
            //        Console.WriteLine("Votre compte est nul");
            //        break;
            //}

            //Console.WriteLine("Je suis à l'extérieur du Switch Case Avec condition");

            #endregion

            #region Instruction Goto
            //int choix = 1;
            int choix = 2;
            //int choix = 3;
            //int choix = 3;

            switch (choix)
            {
                case 1:
                    Console.WriteLine("Choix 1");
                    break;
                case 2:
                    Console.WriteLine("Choix 2");
                    goto case 1;
                case 3:
                    Console.WriteLine("Choix 3");
                    goto case 1;
                default:
                    Console.WriteLine("Bonjour...Faite le bon choix!");
                    break;
            }

            Console.WriteLine("Je suis à l'extérieur du Switch Case Goto");
            #endregion
        }
    }
}
