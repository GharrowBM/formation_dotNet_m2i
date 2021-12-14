using CoursEFCore.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CoursEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pour ajouter des données à l'aide de notre dataContext
            //DataContext data = new DataContext();
            //Personne personne = new Personne()
            //{
            //    FirstName = "abadi",
            //    LastName = "ihab",
            //    Email = "ihab@ihab.fr"
            //};
            //Adresse adresse = new Adresse()
            //{
            //    Street = "tourcoing",
            //    City = "tourcoing",
            //    PostalCode = "59200"
            //};
            ////personne.Adresse = adresse;
            //personne.Adresses.Add(adresse);
            //personne.Adresses.Add(adresse);
            //data.Personnes.Add(personne);
            //int nbRow = data.SaveChanges();
            //if (nbRow > 0)
            //{
            //    Console.WriteLine("La personne a bien été ajoutée avec l'id : " + personne.Id);
            //}

            //Pour afficher les données
            //foreach (Personne p in data.Personnes.Include(p => p.Adresses))
            //{
            //    Console.WriteLine($"Nom : {p.FirstName}, Prénom : {p.LastName}");
            //}

            //Pour selctionner une personne
            //Personne p = data.Personnes.Include(p=>p.Adresse).FirstOrDefault(p=> p.Id == 1);
            //Personne p = data.Personnes.FirstOrDefault(e => e.FirstName.Contains("a"));


            //if (p != null)
            //{
            //    Console.WriteLine($"Nom : {p.FirstName}, Prénom : {p.LastName}");
            //}

            ////Pour rechercher plusieurs éléments
            //List<Personne> pers = data.Personnes.Include(p=>p.Adresse).Where(e =>e.FirstName.Contains("a")).ToList();

            //Pour la modification
            //Personne p = data.Personnes.Find(1);
            //p.LastName = "abadi";
            //p.FirstName = "ihab";
            //data.SaveChanges();

            //Pour la suppression
            //Personne p = data.Personnes.Find(1);
            //data.Personnes.Remove(p);
            //data.SaveChanges();


            //Exemple relation many to many
            //Ecole ecole = new Ecole() { Name = "m2i"};
            //Ecole ecole2 = new Ecole() { Name = "cesi"};
            //Formateur formateur = new Formateur() { FirstName = "ihab", LastName = "abadi" };
            //Formateur formateur2 = new Formateur() { FirstName = "Anthony", LastName = "Di persio" };
            //ecole.Formateurs.Add(formateur);
            //ecole.Formateurs.Add(formateur2);
            //ecole2.Formateurs.Add(formateur);
            //ecole2.Formateurs.Add(formateur2);
            //data.Ecoles.Add(ecole);
            //data.Ecoles.Add(ecole2);

            //Formateur f = data.Formateurs.Include(e => e.Ecoles).FirstOrDefault(p => p.Id == 1);
            //Ecole e = data.Ecoles.Include(f => f.Formateurs).FirstOrDefault(f => f.Id == 1);
            int i = 1;
            while (true)
            {
                
                string[] tab = new string[i++];
                Console.WriteLine(tab.Length);
            }
            //data.SaveChanges();
        }
    }
}
