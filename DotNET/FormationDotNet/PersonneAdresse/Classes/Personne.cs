using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneAdresse.Classes
{
    internal class Personne
    {
        private int id;
        private string nom;
        private string prenom;
        private string email;
        private string telephone;
        private string titre;
        private static SqlConnection connection;
        private static SqlCommand command;
        private string request;

        public int Id { get { return id; }  }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public string Titre { get => titre; set => titre = value; }

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
            id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return id > 0;
        }
    }
}
