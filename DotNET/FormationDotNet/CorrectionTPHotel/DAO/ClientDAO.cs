using CorrectionTPHotel.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHotel.DAO
{
    internal class ClientDAO : BaseDAO
    {

        public Client Save(Client client, SqlConnection _connection = null, SqlTransaction _transaction = null)
        {
            request = "INSERT INTO client (nom, prenom, telephone) " +
                " OUPTUT INSERTED.ID values (@nom, @prenom, @telephone)";
            connection = (_connection == null) ? Connection : _connection;
            command = new SqlCommand(request, connection);
            if(_transaction != null)
            {
                command.Transaction = _transaction;
            }
            command.Parameters.Add(new SqlParameter("@nom", client.Nom));
            command.Parameters.Add(new SqlParameter("@prenom", client.Prenom));
            command.Parameters.Add(new SqlParameter("@telephone", client.Telephone));
            if(_connection == null)
            {
                connection.Open();
            }
            client.Id = (int)command.ExecuteScalar();
            if(_connection == null)
            {
                connection.Close();
            }
            command.Dispose();
            return client;
        } 

        public Client GetClientById(int id, SqlConnection _connection = null)
        {
            Client client = default(Client);

            request = "SELECT nom, prenom, telephone from client where id=@id";
            connection = (_connection == null) ? Connection : _connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            if(_connection == null) 
                connection.Open();
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                client = new Client(id, reader.GetString(0), reader.GetString(1), reader.GetString(2));
            }
            reader.Close();
            command.Dispose();
            if(_connection == null)
                connection.Close();
            return client;
        }
    }
}
