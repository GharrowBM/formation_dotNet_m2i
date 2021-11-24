using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonneAdresse.Classes
{
    internal class Adresse
    {
        private int id;
        private string rue;
        private string ville;
        private string codePostal;
        private int personneId;
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string request;
        public string Rue { get => rue; set => rue = value; }
        public string Ville { get => ville; set => ville = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public int PersonneId { get => personneId; set => personneId = value; }

        public bool Save()
        {
            connection = DataBase.Connection;
            request = "INSERT INTO adresse " +
                "(rue, ville, code_postal, personne_id) OUTPUT INSERTED.ID values " +
                "(@rue, @ville, @code_postal, @personne_id)";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@rue", Rue));
            command.Parameters.Add(new SqlParameter("@ville", Ville));
            command.Parameters.Add(new SqlParameter("@code_postal", CodePostal));
            command.Parameters.Add(new SqlParameter("@personne_id", PersonneId));
            connection.Open();
            id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return id > 0;
        }

        public static Adresse GetAdresseByPersonne(int personneId)
        {
            Adresse adresse = default(Adresse);
            connection = DataBase.Connection;
            request = "SELECT * FROM adresse where personne_id = @personne_id";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@personne_id", personneId));
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                adresse = new Adresse()
                {
                    Rue = reader.GetString(1),
                    Ville = reader.GetString(2),
                    CodePostal = reader.GetString(3)
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close ();
            return adresse;
        }
    }
}
