using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    public class Client
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        private static string request;
        
        //private static SqlConnection connection;
        //private static SqlCommand command;
        //private static SqlDataReader reader;
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }
        public int Id { get => id; set => id = value; }
        public Client()
        {

        }
        public Client(string nom, string prenom, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }

        public override string ToString()
        {
            return $"Client : {Nom} {Prenom}, Tel : {Telephone}";
        }


        public bool Save()
        {

            DataContext.Data.Clients.Add(this);
            int nbRow = DataContext.Data.SaveChanges();
            //request = "INSERT INTO client (nom, prenom, telephone) " +
            //    "OUTPUT INSERTED.ID values " +
            //    "(@nom, @prenom, @telephone)";
            //connection = DataBase.Connection;
            //command = new SqlCommand(request, connection);
            //command.Parameters.Add(new SqlParameter("@nom", Nom));
            //command.Parameters.Add(new SqlParameter("@prenom", Prenom));
            //command.Parameters.Add(new SqlParameter("@telephone", Telephone));
            //connection.Open();
            //Id = (int)command.ExecuteScalar();
            //command.Dispose();
            //connection.Close();
            return Id > 0;
        }

        public static bool ClientExist(string telephone)
        {
            //bool exist = false;
            //request = "SELECT count(*) from client where telephone=@telephone";
            //connection= DataBase.Connection;
            //command= new SqlCommand(request, connection);
            //command.Parameters.Add(new SqlParameter("@telephone", telephone));
            //connection.Open();
            //reader = command.ExecuteReader();
            //if(reader.Read())
            //{
            //    exist = reader.GetInt32(0) > 0;
            //}
            //reader.Close();
            //command.Dispose();
            //connection.Close ();
            //return exist;
            
            return DataContext.Data.Clients.FirstOrDefault(p=> p.Telephone == telephone) != default(Client);
        }

        public static Client GetClient(int id)
        {
            //Client client = default(Client);
            //request = "SELECT nom, prenom, telephone from client where id=@id";
            //connection = DataBase.Connection;
            //command = new SqlCommand (request, connection);
            //command.Parameters.Add(new SqlParameter("@id", id));
            //connection.Open();
            //reader = command.ExecuteReader();
            //if(reader.Read())
            //{
            //    client = new Client(reader.GetString(0), reader.GetString(1), reader.GetString(2))
            //    {
            //        Id = id
            //    };
            //}
            //reader.Close();
            //command.Dispose();
            //connection.Close();
            //return client;
            
            return DataContext.Data.Clients.Find(id);
        }
    }
}
