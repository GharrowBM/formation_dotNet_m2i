﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompteBancaireVersion1.Classes
{
    internal class Client
    {
        private string nom;
        private string prenom;
        private string telephone;

        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public Client(string nom, string prenom, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Telephone = telephone;
        }

        public override string ToString()
        {
            return $"Client : {Nom} {Prenom}, Tel : {Telephone}";
        }
    }
}
