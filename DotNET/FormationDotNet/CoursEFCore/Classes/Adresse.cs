using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEFCore.Classes
{
    public class Adresse
    {
        private int id;
        private string street;
        private string city;
        private string postalCode;

        public int Id { get => id; set => id = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string PostalCode { get => postalCode; set => postalCode = value; }
    }
}
