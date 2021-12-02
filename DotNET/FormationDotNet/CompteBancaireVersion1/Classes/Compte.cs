using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    public class Compte
    {
        private int id;
        private decimal solde;
        private Client client;
        private List<Operation> operations;
       // private static int compteur = 0;

        private static string request;
        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataReader reader;
        public int Id { get => id; set => id = value; }
        public decimal Solde { get => solde; set => solde = value; }
        public Client Client { get => client; set => client = value; }
        public List<Operation> Operations { get => operations; set => operations = value; }

        public event Action<int, decimal> ADecouvert;
        public Compte()
        {
            operations = new List<Operation>();
            solde = 0;
            //id = ++compteur;
        }

        public Compte(decimal solde)
        {
            this.solde = solde;
            operations = new List<Operation>();

        }

        public virtual bool Depot(Operation operation)
        {
            if(operation.Montant >= 0)
            {
                //operations.Add(operation);
                if(operation.Save(Id))
                {
                    solde += operation.Montant;

                    return Update();
                }
                return false;
            }
            return false;
        }

        public virtual bool Retrait(Operation operation)
        {
            //operations.Add(operation);
            if(operation.Save(Id))
            {
                solde += operation.Montant;
                if (solde < 0)
                {
                    if (ADecouvert != null)
                        ADecouvert(id, Solde);
                }
                return Update();
            }
            return false;
            

        }

        public bool Save()
        {
            request = "INSERT INTO compte (solde, client_id) " +
                "OUTPUT INSERTED.ID values (@solde, @client_id)";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@solde", Solde));
            command.Parameters.Add(new SqlParameter("@client_id", Client.Id));
            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public bool Update()
        {
            request = "UPDATE compte set solde=@solde where id=@id";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@solde", Solde));
            command.Parameters.Add(new SqlParameter("@id", Id));
            connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return nbRow == 1;
        }

        public static Compte GetCompte(int id)
        {
            Compte compte = default(Compte);
            int clientId=0;
            request = "SELECT solde, client_id from compte where id=@id";
            connection= DataBase.Connection;
            command= new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                compte = new Compte(reader.GetDecimal(0))
                {
                    Id = id
                };
                clientId = reader.GetInt32(1);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            if(compte != default(Compte))
            {
                compte.Client = Client.GetClient(clientId);
                compte.Operations = Operation.GetOperations(compte.id);
            }
            return compte;
        }
    }
}
