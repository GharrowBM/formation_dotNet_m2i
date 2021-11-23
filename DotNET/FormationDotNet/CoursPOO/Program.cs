using CoursPOO;
using CoursPOO.Classes;
using CoursPOO.Interfaces;
//using CoursPOO.AirBus;
//using CoursPOO.Boeing;
using System;
using System.Collections.Generic;
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
            //Etudiant e = new Etudiant();
            //e.Nom = "abadi";
            //e.Prenom = "Ihab";
            //e.Niveau = 1;
            ////e.AfficherAvecNiveau();
            ////e.Marcher();

            ////new Prof().Marcher();

            //Etudiant e2 = new Etudiant("toto", "tata", 4);

            //Prof p1 = new Prof();
            //Prof p2 = new Prof();
            //Personne pr = new Etudiant();
            //Personne[] personnes = new Personne[4];
            //personnes[0] = p1;
            //personnes[1] = p2;
            //personnes[2] = e;
            //personnes[3] = e2;
            //foreach(Personne p in personnes)
            //{

            //    p.Marcher();
            //}
            #endregion

            #region cours generique
            //Maison<Personne> maison = new Maison<Personne>();
            //Maison<int> maisonEntier = new Maison<int>();
            //maison.Ajouter(new Etudiant());
            //maisonEntier.Ajouter(10);

            //Exemple de classe generique dans le framework .net
            //List<string> list = new List<string>();
            //On peut ajouter des éléments dans notre liste
            //list.Add("toto");
            //list.Add("tata");
            //list.Add("titi");

            ////On peut parccourir une liste
            //for(int i = 0; i < list.Count; i++)
            //{
            //    Console.WriteLine(list[i]);
            //}

            ////On peut supprimer des éléments
            //list.RemoveAt(1);
            //list.Remove("titi");
            ////On peut également utiliser la boucle foreach
            //foreach(string s in list)
            //{
            //    Console.WriteLine(s);
            //}
            ////On peut récupérer un element avec son index comme dans un tableau
            //Console.WriteLine(list[0]);

            ////Exercice : Il faut modifier la correction du ForumNouvelle en remplaçant les tableaux par des listes.
            ////D'autre exemple de generique
            ////HashSet<string> set = new HashSet<string>();
            ////Dictionnary
            //Dictionary<string, string> dic = new Dictionary<string, string>();
            //dic.Add("toto", "valueToto");
            //Console.WriteLine(dic["toto"]);
            #endregion

            #region cours interface
            //IVolant elementVolant1 = new Avion(); 
            //IVolant elementVolant2 = new Oiseau();
            ////List<IVolant> volants = new List<IVolant>();
            ////volants.Add(elementVolant1);
            ////volants.Add(elementVolant2);
            ////foreach(IVolant volant in volants)
            ////{
            ////    volant.Decoller();
            ////    volant.Voler();
            ////    volant.Atterrir();
            ////}

            //Transporteur transporteurAncien = new Transporteur(new Oiseau());
            //Transporteur transporteurModerne = new Transporteur(new Avion());
            //transporteurAncien.Transporter();
            //transporteurModerne.Transporter();
            #endregion

            #region cours gestion des exceptions
            //try
            //{
            //    int[] tab = new int[2];
            //    Console.Write("Merci de saisir un entier :");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Vous avez saisi " + a);
            //    tab[0] = a;
            //    //Code à executer
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.GetType()); 
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine("vous n'avez pas saisi un entier");
            //    //Code à executer

            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine("Vous êtes à l'exterieur du tableau");
            //}
            //finally
            //{
            //    Console.WriteLine("Partie executée quelque soit le scénario try ou catch");
            //}

            //bool error;
            //int a = 0;
            //do
            //{
            //    try
            //    {
            //        Console.Write("Merci de saisir un entier : ");
            //        a = Convert.ToInt32(Console.ReadLine());
            //        error = false;
            //    }catch(Exception e)
            //    {
            //        Console.WriteLine("Erreur, vous n'avez pas saisi un entier");
            //        error = true;
            //    }
            //} while (error);
            //Console.WriteLine("Valeur de a " + a);

            //Personne p = new Etudiant();
            //try
            //{

            //    int a = 130;
            //    //if(a >= 0 && a < 100)
            //    //{
            //    //    p.Age = a;
            //    //}
            //    p.Age = a;
            //}catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            #endregion

            #region cours expression lambda
            //Calculatrice calculatrice = new Calculatrice();
            //calculatrice.Calculer(10, 20, Soustraction);
            //calculatrice.Calculer(10, 30, delegate (double a, double b) { return a * b; });
            //calculatrice.Calculer(10, 30,  (a,b) =>  a / b  );


            #endregion

            #region cours event
            Avion avion = new Avion();
            avion.Prix = 100000;
            avion.Promotion += EnvoieSMS;
            avion.Promotion += EnvoieEmail;
            string choix;
            int compteur = 0;
            do
            {
                Console.WriteLine("Est ce qu'il y a une promotion sur l'avion ? ");
                choix = Console.ReadLine();
                if(choix == "o")
                {
                    decimal reduction = Convert.ToDecimal(Console.ReadLine());
                    avion.Reduction(reduction);
                    compteur++;
                    if(compteur >= 2)
                    {
                        avion.Promotion -= EnvoieSMS;
                    }
                }

            } while (choix != "0");
            #endregion
        }


        static void EnvoieSMS(decimal prix)
        {
            Console.WriteLine("SMS : Il y a une promotion sur l'avion, voici le noueau prix : " + prix);
        }

        static void EnvoieEmail(decimal prix)
        {
            Console.WriteLine("Email : Il y a une promotion sur l'avion, voici le noueau prix : " + prix);
        }
        static double Soustraction(double x, double y)
        {
            return x - y;
        }
    }
}
