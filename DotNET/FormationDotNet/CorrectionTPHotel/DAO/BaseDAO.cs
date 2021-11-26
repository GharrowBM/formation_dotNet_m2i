using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionTPHotel.DAO
{
    internal abstract class BaseDAO
    {
        private static string connectionString = @"Data Source=(LocalDb)\coursDotNet;Integrated Security=True";
        protected static SqlConnection connection;
        protected static SqlCommand command;
        protected static SqlDataReader reader;
        protected static string request;

        public static SqlConnection Connection
        {
            get => new SqlConnection(connectionString);
        }
    }
}
