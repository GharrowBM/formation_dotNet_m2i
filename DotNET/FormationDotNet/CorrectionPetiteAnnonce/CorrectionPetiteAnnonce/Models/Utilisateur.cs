using System;
namespace CorrectionPetiteAnnonce.Models
{
    public class Utilisateur
    {
        private int id;
        private string login;
        private string password;
        public Utilisateur()
        {
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
    }
}
