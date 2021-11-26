using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.DAO
{
    abstract class BaseDAO
    {
        protected static SqlConnection connection;
        protected static string request;
        protected static SqlCommand command;
        protected static SqlDataReader reader;


        public static SqlConnection Connection
        {
            get => new SqlConnection(@"Data Source=(LocalDb)\coursDotNet;Integrated Security=True");
        }
    }
}
