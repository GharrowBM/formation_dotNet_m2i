using System.Collections.Generic;

namespace FormationAspNetCoreMVC.Models
{
    public class Personne
    {
        private int id;
        private string name;
        private int age;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }


        public static List<Personne> GetPersonnes()
        {
            return new List<Personne>() { new Personne() { Age = 20, Name = "toto" }, new Personne() { Age = 20, Name = "tata" } };
        }
    }
}
