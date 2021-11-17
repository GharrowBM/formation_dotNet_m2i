using CoursPOO;
using CoursPOO.Classes;
//using CoursPOO.AirBus;
//using CoursPOO.Boeing;
using System;
namespace CoursPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Avion avion1 = new Avion("rouge", 189);
            ////avion1.nbPlaces = 189;
            ////avion1.couleur = "rouge";
            //Console.WriteLine(avion1.nbPlaces);
            //Console.WriteLine(avion1.couleur);
            //string result = avion1.Voler();
            //Console.WriteLine(result);
            //Console.WriteLine(avion1.GetType());

            #region exercice chaise
            //Chaise chaise1 = new Chaise(4, "rouge", "bois");
            //Chaise chaise2 = new Chaise(5, "blanche", "metal");
            ////chaise1.Afficher();
            ////chaise2.Afficher();
            //Chaise chaise3 = new Chaise();
            //chaise3.NbPieds = 6;
            ////chaise3.couleur = "jaune";
            ////chaise3.materiel = "plexiglass";
            ////chaise3.SetNbPieds(6);

            //Chaise[] tabChaises = new Chaise[] {chaise1, chaise2, chaise3};
            //foreach(Chaise chaise in tabChaises)
            //{
            //    chaise.Afficher();
            //}
            ////chaise3.Afficher();

            //Console.WriteLine($"Le nombre de chaise est de {Chaise.NbChaise}");
            #endregion
            #region cours héritage
            Etudiant e = new Etudiant();
            e.Nom = "abadi";
            e.Prenom = "Ihab";
            e.Niveau = 1;
            //e.AfficherAvecNiveau();
            //e.Marcher();

            //new Prof().Marcher();

            Etudiant e2 = new Etudiant("toto", "tata", 4);

            Prof p1 = new Prof();
            Prof p2 = new Prof();
            Personne pr = new Personne();
            Personne[] personnes = new Personne[4];
            personnes[0] = p1;
            personnes[1] = p2;
            personnes[2] = e;
            personnes[3] = e2;
            foreach(Personne p in personnes)
            {
                
                p.Marcher();
            }
            #endregion
        }

    }
}
