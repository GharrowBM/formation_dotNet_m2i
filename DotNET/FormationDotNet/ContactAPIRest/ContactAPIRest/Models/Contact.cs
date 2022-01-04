using System;
namespace ContactAPIRest.Models
{
    public class Contact
    {
        private int id;
        private string firstName;
        private string lastName;
        private string phone;
        private string email;
        private string avatar;
        public Contact()
        {
        }

        public int Id { get => id; set => id = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string Avatar { get => avatar; set => avatar = value; }
    }
}
