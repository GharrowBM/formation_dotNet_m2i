using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    internal class DataBase
    {
        private static string connectionString = @"Data Source=(LocalDb)\coursDotNet;Integrated Security=True";
        public static SqlConnection Connection
        {
            get => new SqlConnection(connectionString);
        }
    }
}
