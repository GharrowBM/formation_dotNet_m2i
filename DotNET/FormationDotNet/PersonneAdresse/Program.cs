using PersonneAdresse.Classes;
using System;

namespace PersonneAdresse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Personne personne = new Personne();
            //Console.Write("Votre titre : ");
            //personne.Titre = Console.ReadLine();
            //Console.Write("Votre nom : ");
            //personne.Nom = Console.ReadLine();
            //Console.Write("Votre prénom : ");
            //personne.Prenom = Console.ReadLine();
            //Console.Write("Votre téléphone : ");
            //personne.Telephone = Console.ReadLine();
            //Console.Write("Votre email : ");
            //personne.Email = Console.ReadLine();
            //if(personne.Save())
            //{
            //    Adresse adresse = new Adresse();
            //    adresse.PersonneId = personne.Id;
            //    Console.Write("Rue : ");
            //    adresse.Rue = Console.ReadLine();
            //    Console.Write("Ville : ");
            //    adresse.Ville = Console.ReadLine();
            //    Console.Write("Code postal : ");
            //    adresse.CodePostal = Console.ReadLine();
            //    if (adresse.Save())
            //    {
            //        Console.WriteLine("La personne a bien été enregistrée ainsi que son adresse");
            //    }
            //}

            foreach(Personne p in Personne.GetPersonnes())
            {
                Console.WriteLine($"{p.Nom}, {p.Prenom}, {p.Telephone}");
                Adresse adresse = Adresse.GetAdresseByPersonne(p.Id);
                if(adresse != default(Adresse))
                    Console.WriteLine($"{adresse.Rue} {adresse.Ville} {adresse.CodePostal}");
            }
        }
    }
}
