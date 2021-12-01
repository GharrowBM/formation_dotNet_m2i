using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    public class Operation
    {
        private int id;
        private decimal montant;
        private DateTime dateEtheureOperation;
        private static string request;
        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataReader reader;
        public decimal Montant { get => montant;  }
        public DateTime DateEtheureOperation { get => dateEtheureOperation; set => dateEtheureOperation = value; }
        public int Id { get => id; set => id = value; }

        public Operation(decimal montant)
        {
            this.montant = montant;
            this.dateEtheureOperation = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Montant : {Montant}, Date de l'opération : {DateEtheureOperation}";
        }

        public bool Save(int compteId)
        {
            request = "INSERT INTO operation (montant, date_operation, compte_id) " +
                "OUTPUT INSERTED.ID values (@montant, @date_operation, @compte_id)";
            connection = DataBase.Connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@montant", Montant));
            command.Parameters.Add(new SqlParameter("@compte_id", compteId));
            command.Parameters.Add(new SqlParameter("@date_operation", DateEtheureOperation));
            connection.Open();
            Id = (int)command.ExecuteScalar();
            command.Dispose();
            connection.Close();
            return Id > 0;
        }

        public static List<Operation> GetOperations(int compteId)
        {
            List<Operation> operations = new List<Operation>();
            request = "SELECT id, montant, date_operation from operation where " +
                "compte_id = @compteId";
            connection = DataBase.Connection;
            command = new SqlCommand(request,connection);
            command.Parameters.Add(new SqlParameter("@compteId", compteId));
            connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Operation o = new Operation(reader.GetDecimal(1))
                {
                    Id = reader.GetInt32(0),
                    DateEtheureOperation = reader.GetDateTime(2),
                };
                operations.Add(o);
            }
            return operations;
        }
    }
}
