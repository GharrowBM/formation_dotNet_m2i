using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursEFCore.Classes
{
    [Table(name: "personne")]
    public class Personne
    {
        private int id;
        private string firstName;
        private string lastName;

        [Key]
        public int Id { get => id; set => id = value; }
        
        [Required, Column(name: "prenom", TypeName = "varchar"), MaxLength(200)]
        public string FirstName { get => firstName; set => firstName = value; }

        [Required, Column(name: "nom", TypeName = "varchar"), MaxLength(200)]
        public string LastName { get => lastName; set => lastName = value; }

        [Required]
        public string Email { get; set; }


        public int AdresseId { get; set; }

        [ForeignKey("AdresseId")]
        public virtual Adresse Adresse { get; set; }
    }
}
