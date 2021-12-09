using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaisseEnregistreuse.DAO
{
    public abstract class BaseDAO
    {
        protected static SqlConnection connection;
        protected static string request;
        protected static SqlCommand command;
        protected static SqlDataReader reader;


        public static SqlConnection Connection
        {
            get => new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ihab\source\repos\CoursAP2019\basededonnees.mdf;Integrated Security=True;Connect Timeout=30");
        }
    }
}
