using CorrectionTPHotel.Classes;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHotel.DAO
{
    internal class ReservationDAO : BaseDAO
    {
        public Reservation Save(Reservation reservation)
        {
            request = "INSERT INTO reservation (client_id, statut) " +
                "OUTPUT INSERTED.ID values(@client_id, @statut)";
            connection = Connection;
            SqlTransaction _transaction = null;
            connection.Open();
            try
            {
                _transaction = connection.BeginTransaction();
                command = new SqlCommand(request, connection);
                command.Transaction = _transaction;
                command.Parameters.Add(new SqlParameter("@client_id", reservation.Client.Id));
                command.Parameters.Add(new SqlParameter("@statut", reservation.Statut));
                reservation.Id = (int)command.ExecuteScalar();
                command.Dispose();
                reservation.ChambreList.ForEach(chambre => SaveReservationChambre(reservation.Id, chambre.Id, connection, _transaction));                            
                _transaction.Commit();
            }
            catch(Exception ex)
            {
                _transaction.Rollback();
            }finally
            {
                connection.Close();          
            }
            return reservation;
        }


        public void SaveReservationChambre(int reservationId, int chambreId, SqlConnection _connection, SqlTransaction _transaction)
        {
            request = "INSERT INTO reservation_chambre (chambre_id, reservation_id) " +
                "values (@chambre_id, @reservation_id)";
            command = new SqlCommand(request, _connection);
            command.Transaction = _transaction;
            command.Parameters.Add(new SqlParameter("chambre_id", chambreId));
            command.Parameters.Add(new SqlParameter("reservation_id", reservationId));
            command.ExecuteNonQuery();
            command.Dispose();
        }

        public Reservation Get(int id)
        {
            Reservation reservation = default(Reservation);
            return reservation;
        }

        public bool Update(Reservation reservation)
        {
            return false;
        }
    }
}
