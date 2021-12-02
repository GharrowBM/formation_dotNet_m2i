using CoursWPFMVVM.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private Personne selectedPersonne;
        //public event PropertyChangedEventHandler? PropertyChanged;
        private ObservableCollection<Personne> personnes;
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

        public Personne SelectedPersonne
        {
            get => selectedPersonne;
            set
            {
                selectedPersonne = value;
                //Nom = SelectedPersonne.Nom;
                //Prenom = SelectedPersonne.Prenom;
                //Telephone = SelectedPersonne.Telephone;
                personne = selectedPersonne;
                RaisePropertyChanged("Nom");
                RaisePropertyChanged("Prenom");
                RaisePropertyChanged("Telephone");
                RaisePropertyChanged("Result");
            }
        }

        public string Prenom
        {
            get => personne.Prenom;
            set
            {
                personne.Prenom = value;
                RaisePropertyChanged("Prenom");
                RaisePropertyChanged("Result");

            }
        }

        public string Telephone
        {
            get => personne.Telephone;
            set
            {
                personne.Telephone = value;
                RaisePropertyChanged("Telephone");
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
        public ObservableCollection<Personne> Personnes { get => personnes; set => personnes = value; }

        public PersonnesViewModel()
        {
            personne = new Personne();
            Personnes = new ObservableCollection<Personne>();
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
            Personnes.Add(personne);
            personne = new Personne();
            RaisePropertyChanged("Nom");
            RaisePropertyChanged("Prenom");
            RaisePropertyChanged("Telephone");
            RaisePropertyChanged("Result");
            MessageBox.Show("Je viens de cliquer sur valider avec une commande");
        }
    }
}
