using CoursWPFMVVM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursWPFMVVM.ViewModels
{
    internal class PersonnesViewModel : INotifyPropertyChanged
    {
        private Personne personne;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string Nom
        {
            get => personne.Nom;
            set
            {
                personne.Nom = value;
                RaisePropertyChanged("Nom");
                RaisePropertyChanged("Result");
            }
        }

        public string Prenom
        {
            get => personne.Prenom;
            set
            {
                personne.Prenom = value;
                RaisePropertyChanged("Result");

            }
        }

        public string Telephone
        {
            get => personne.Telephone;
            set
            {
                personne.Telephone = value;
                RaisePropertyChanged("Result");

            }
        }

        public string Result
        {
            get => $"{personne.Nom} {personne.Prenom} {personne.Telephone}";
        }

        public PersonnesViewModel()
        {
            personne = new Personne();
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
