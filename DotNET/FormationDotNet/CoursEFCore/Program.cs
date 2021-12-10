using CoursEFCore.Classes;
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
            DataContext data = new DataContext();
            //Personne personne = new Personne()
            //{
            //    FirstName = "abadi",
            //    LastName = "ihab"
            //};
            //data.Personnes.Add(personne);
            //int nbRow = data.SaveChanges();
            //if(nbRow > 0)
            //{
            //    Console.WriteLine("La personne a bien été ajoutée avec l'id : " + personne.Id);
            //}

            //Pour afficher les données
            //foreach(Personne p in data.Personnes)
            //{
            //    Console.WriteLine($"Nom : {p.FirstName}, Prénom : {p.LastName}");
            //}

            //Pour selctionner une personne
            //Personne p = data.Personnes.Find(1);
            //Personne p = data.Personnes.FirstOrDefault(e => e.FirstName.Contains("a"));


            //if (p != null)
            //{
            //    Console.WriteLine($"Nom : {p.FirstName}, Prénom : {p.LastName}");
            //}

            ////Pour rechercher plusieurs éléments
            //List<Personne> pers = data.Personnes.Where(e =>e.FirstName.Contains("a")).ToList();

            //Pour la modification
            //Personne p = data.Personnes.Find(1);
            //p.LastName = "abadi";
            //p.FirstName = "ihab";
            //data.SaveChanges();

            //Pour la suppression
            Personne p = data.Personnes.Find(1);
            data.Personnes.Remove(p);
            data.SaveChanges();
        }
    }
}
