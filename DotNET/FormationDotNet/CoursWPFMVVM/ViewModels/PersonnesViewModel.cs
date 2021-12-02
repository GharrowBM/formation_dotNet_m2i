using CoursWPFMVVM.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CoursWPFMVVM.ViewModels
{
    internal class PersonnesViewModel : ViewModelBase
    {
        private Personne personne;

        //public event PropertyChangedEventHandler? PropertyChanged;

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

        public ICommand ValidCommand
        {
            get; set;
        }

        public PersonnesViewModel()
        {
            personne = new Personne();
            ValidCommand = new RelayCommand(ActionValid);
        }

        //private void RaisePropertyChanged(string propertyName)
        //{
        //    if (PropertyChanged != null)
        //    {
        //        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        //    }
        //}

        private void ActionValid()
        {
            MessageBox.Show("Je viens de cliquer sur valider avec une commande");
        }
    }
}
