using CorrectionTPHotel.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHotel.DAO
{
    internal class ChambreDAO : BaseDAO
    {

        public Chambre Save(Chambre chambre, SqlConnection _connection = null, SqlTransaction _transaction = null)
        {
            request = "INSERT INTO chambre (statut, prix, nb_max) " +
                " OUTPUT INSERTED.ID values (@statut, @prix, @nb_max)";
            connection = (_connection == null) ? Connection : _connection;
            command = new SqlCommand(request, connection);
            if (_transaction != null)
            {
                command.Transaction = _transaction;
            }
            command.Parameters.Add(new SqlParameter("@statut", chambre.Statut));
            command.Parameters.Add(new SqlParameter("@prix", chambre.Prix));
            command.Parameters.Add(new SqlParameter("@nb_max", chambre.NbMax));
            if (_connection == null)
            {
                connection.Open();
            }
            chambre.Id = (int)command.ExecuteScalar();
            if (_connection == null)
            {
                connection.Close();
            }
            command.Dispose();
            return chambre;

        }
        public Chambre Get(int id, SqlConnection _connection = null)
        {
            Chambre chambre = default(Chambre);
            request = "SELECT statut, prix, nb_max from chambre where id=@id";
            connection = _connection == null ? Connection : _connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            if(_connection == null) 
                connection.Open();
            reader = command.ExecuteReader();
            if(reader.Read())
            {
                chambre = new Chambre(id, reader.GetDecimal(1), reader.GetInt32(2), (ChambreStatut)reader.GetInt32(0));
            }
            reader.Close();
            command.Dispose();
            if(_connection == null)
                connection.Close ();
            return chambre;
        }

        public List<Chambre> GetByStatut(ChambreStatut statut, SqlConnection _connection = null)
        {
            List<Chambre> chambres = new List<Chambre>();
            request = "SELECT id, prix, nb_max from chambre where statut=@statut";
            connection = _connection == null ? Connection : _connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@statut", statut));
            if (_connection == null)
                connection.Open();
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Chambre chambre = new Chambre(reader.GetInt32(0), reader.GetDecimal(1), reader.GetInt32(2), statut);
                chambres.Add(chambre);
            }
            reader.Close();
            command.Dispose();
            if (_connection == null)
                connection.Close();
            return chambres;
        }

        public List<Chambre> GetByReservationId(int id, SqlConnection _connection = null)
        {
            List<Chambre> chambres = new List<Chambre>();
            request = "SELECT c.statut, c.prix, c.nb_max, c.id from chambre as c " +
                "inner join reservation_chambre as rc on c.id = rc.chambre_id " +
                "where rc.reservation_id=@id";
            connection = _connection == null ? Connection : _connection;
            command = new SqlCommand(request, connection);
            command.Parameters.Add(new SqlParameter("@id", id));
            if (_connection == null)
                connection.Open();
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                Chambre chambre = new Chambre(reader.GetInt32(3), reader.GetDecimal(1), reader.GetInt32(2), (ChambreStatut)reader.GetInt32(0));
                chambres.Add(chambre);
            }
            reader.Close();
            command.Dispose();
            if (_connection == null)
                connection.Close();
            return chambres;
        }

        public bool Update(Chambre chambre, SqlConnection _connection = null, SqlTransaction _transaction = null)
        {
            request = "UPDATE chambre set statut = @statut, prix =@prix, nb_max=@nb_max " +
                "where id=@id";
            connection = (_connection == null) ? Connection : _connection;
            command = new SqlCommand(request, connection);
            if (_transaction != null)
            {
                command.Transaction = _transaction;
            }
            command.Parameters.Add(new SqlParameter("@statut", chambre.Statut));
            command.Parameters.Add(new SqlParameter("@prix", chambre.Prix));
            command.Parameters.Add(new SqlParameter("@nb_max", chambre.NbMax));
            command.Parameters.Add(new SqlParameter("@id", chambre.Id));
            if (_connection == null)
            {
                connection.Open();
            }
            int nbRow = command.ExecuteNonQuery();
            if (_connection == null)
            {
                connection.Close();
            }
            command.Dispose();
            return nbRow == 1;
        }
    }
}
