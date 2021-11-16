using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpPendu.Classes
{
    internal class IHM
    {
        Pendu pendu;
        GenerateurDeMot generateurDeMot;
        public void Demarrer()
        {
            Console.WriteLine("----Jeu du pendu----");
            string choix;
            do
            {
                MenuPrincipal();
                choix = Console.ReadLine();
                switch(choix)
                {
                    case "1":
                        ActionStartGame();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("---Erreur Menu---");
                        break;
                }
            }while (choix != "0") ;
        }

        private void MenuPrincipal()
        {
            Console.WriteLine("1 -- Démarrer");
            Console.WriteLine("0 -- Quitter");
        }

        private void ActionStartGame()
        {
            //On crée notre objet pendu
            pendu = new Pendu();
            //On crée notre générateur de mot
            generateurDeMot = new GenerateurDeMot();
            //On utilise la méthode generer masque de notre generateur de mots.
            pendu.GenererMasque(generateurDeMot.Generer());
            Play();
        }

        private void Play()
        {
            while(pendu.NbEssai > 0 && !pendu.testWin())
            {
                Console.WriteLine(pendu.Masque);
                Console.Write("Proposer un caractère : ");
                char c = Convert.ToChar(Console.ReadLine());
                if (pendu.TestChar(c))
                {
                    Console.WriteLine("Bravo vous avez trouvé un caractère"); 
                }
                else
                {
                    Console.WriteLine($"Perdu, il vous reste {pendu.NbEssai} essai");
                }
            }
            if(pendu.NbEssai > 0)
            {
                Console.WriteLine("Bravo vous avez gagné");
            }
            else
            {
                Console.WriteLine("Perdu");
            }
        }
    }
}
