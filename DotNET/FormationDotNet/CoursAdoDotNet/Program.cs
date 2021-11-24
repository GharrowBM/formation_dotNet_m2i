using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace CoursAdoDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objets pour se connecter à la base de données
            string connectionString = @"Data Source=(LocalDb)\coursDotNet;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            //Console.WriteLine(connection.State);
            //connection.Open();
            //Console.WriteLine(connection.State);
            //connection.Close();
            //Console.WriteLine(connection.State);
            //Pour executer des requêtes, on aura besoin des objets de types SqlCommand;
            string titre = "produit en c# 2";
            decimal prix = 1200;
            string request = "INSERT INTO produit(titre, prix) " +
                " OUTPUT INSERTED.id values (@t, @p)";
            SqlCommand command = new SqlCommand(request, connection);
            //Ajouter des paramètres de requête
            command.Parameters.Add(new SqlParameter("@t", titre));
            command.Parameters.Add(new SqlParameter("@p", prix));
            connection.Open();
            //1ere façon d'executer une commande => si aucun retour attendu.
            //int nbRow = command.ExecuteNonQuery();
            //2eme façon d'executer une commande => une seul et unique resultat attendu.
            if(connection.State == ConnectionState.Open)
            {
                int id = (int)command.ExecuteScalar();
                command.Dispose();
                connection.Close();
                Console.WriteLine(id);
            }
            
        }
    }
}
