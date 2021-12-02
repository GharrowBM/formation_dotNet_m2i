using CompteBancaireVersion1.Classes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BanqueWPFMVVM.ViewModels
{
    internal class HomeViewModel : ViewModelBase
    {
        private Compte compte;

        public HomeViewModel()
        {
            compte = new Compte();
            compte.Client = new Client();
            CreateCommand = new RelayCommand(ActionCreate);
        }

        public string Nom
        {
            get => compte.Client.Nom;
            set => compte.Client.Nom = value;
        }
        public string Prenom
        {
            get => compte.Client.Prenom;
            set => compte.Client.Prenom = value;
        }
        public string Telephone
        {
            get => compte.Client.Telephone;
            set => compte.Client.Telephone = value;
        }

        public decimal Solde
        {
            get => compte.Solde;
            set => compte.Solde = value;
        }

        public string CreateResult { get; set; }

        public ICommand CreateCommand { get; set; } 

        public void ActionCreate()
        {
            if(compte.Client.Save())
            {
                if (compte.Save())
                {
                    CreateResult = "Compte crée avec l'id " + compte.Id;
                    RaisePropertyChanged("CreateResult");
                    compte = new Compte();
                    compte.Client=new Client();
                    RaisePropertyChanged("Nom");
                    RaisePropertyChanged("Prenom");
                    RaisePropertyChanged("Telephone");
                    RaisePropertyChanged("Solde");
                }
            }
        }
    }
}
