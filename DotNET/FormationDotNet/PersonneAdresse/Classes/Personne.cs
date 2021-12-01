using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneAdresse.Classes
{
    public class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;
        private string telephone;
        private string titre;
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string request;

        
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Titre { get => titre; set => titre = value; }
        public int Id { get => id; set => id = value; }

        public bool Save()
        {
            connection = DataBase.Connection;
            request = "INSERT INTO personne " +
                "(titre, nom, prenom, email, telephone) OUTPUT INSERTED.ID values " +
                "(@titre, @nom, @prenom, @email, @telephone)";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@titre", Titre));
            command.Parameters.Add(new SqlParameter("@nom", Nom));
            command.Parameters.Add(new SqlParameter("@prenom", Prenom));
            command.Parameters.Add(new SqlParameter("@telephone", Telephone));
            command.Parameters.Add(new SqlParameter("@email", Email));
            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public bool Delete()
        {
            connection= DataBase.Connection;
            request = "DELETE FROM personne where id=@id";
            command= new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", Id));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }

        public bool Update()
        {
            connection = DataBase.Connection;
            request = "UPDATE personne set titre=@titre," +
                " nom=@nom, prenom=@prenom, email=@email, telephone=@telephone " +
                "where id=@id";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", Id));
            command.Parameters.Add(new SqlParameter("@titre", Titre));
            command.Parameters.Add(new SqlParameter("@nom", Nom));
            command.Parameters.Add(new SqlParameter("@prenom", Prenom));
            command.Parameters.Add(new SqlParameter("@telephone", Telephone));
            command.Parameters.Add(new SqlParameter("@email", Email));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }

        public static List<Personne> GetPersonnes()
        {
            List<Personne> personnes = new List<Personne>();
            connection = DataBase.Connection;
            request = "SELECT * FROM personne";
            command = new SqlCommand(request,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Personne person = new Personne()
                {
                    Id = reader.GetInt32(0),
                    Titre = reader.GetString(1),
                    Prenom = reader.GetString(2),
                    Nom = reader.GetString(3),
                    Telephone = reader.GetString(5),
                    Email = reader.GetString(4),
                };
                personnes.Add(person);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return personnes;
        }
        public override string ToString()
        {
            return $"Titre {Titre}, Nom {Nom}, Prénom:{Prenom}, Email : {Email}, Telephone : {Telephone}";
        }
    }
}
