using CaisseEnregistreuse.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.DAO
{
    internal class ProduitDAO : BaseDAO
    {
        public bool Save(Produit produit)
        {
            connection = Connection;
            request = "INSERT INTO produit (titre, prix, stock) " +
                "OUTPUT INSERTED.ID values (@titre, @prix, @stock)";
            command = new  SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@titre", produit.Titre));
            command.Parameters.Add(new SqlParameter("@prix", produit.Prix));
            command.Parameters.Add(new SqlParameter("@stock", produit.Stock));
            connection.Open();
            produit.Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return produit.Id > 0;
        }

        public bool Update(Produit produit, SqlConnection connection, SqlTransaction transaction)
        {
            //connection = Connection;
            request = "UPDATE produit set stock=@stock where id=@id";
            command = new SqlCommand(request, connection);
            command.Transaction = transaction;
            command.Parameters.Add(new SqlParameter("@stock", produit.Stock));
            command.Parameters.Add(new SqlParameter("@id", produit.Id));
            //connection.Open();
            int nbRow = command.ExecuteNonQuery();
            command.Dispose();
            //connection.Close();
            return nbRow == 1;
        }

        public Produit GetProduit(int id)
        {
            Produit produit =default(Produit);
            connection = Connection;
            request = "SELECT titre, prix, stock from produit where id= @id";
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            connection.Open();
            reader = command.ExecuteReader();
            if (reader.Read())
            {
                produit = new Produit(reader.GetString(0), reader.GetDecimal(1), reader.GetInt32(2))
                {
                    Id = id
                };
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return produit;
        }

        public List<Produit> GetProduits()
        {
            List<Produit> produits = new List<Produit>();
            connection = Connection;
            request = "SELECT titre, prix, stock, id from produit";
            command = new SqlCommand(request, connection);
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Produit produit = new Produit(reader.GetString(0), reader.GetDecimal(1), reader.GetInt32(2))
                {
                    Id = reader.GetInt32(3)
                };
                produits.Add(produit);
            }
            reader.Close();
            command.Dispose();
            connection.Close();
            return produits;
        }
    }
}
