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
        private Banque banque;
        public HomeViewModel()
        {
            compte = new Compte();
            compte.Client = new Client();
            CreateCommand = new RelayCommand(ActionCreate);
            banque = new Banque();
            Operations = new List<Operation>();
            SearchCommand = new RelayCommand(ActionSearch);
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
        public int CompteId { get; set; }
        public Compte SearchCompte { get; set; }
        public string SearchClient { get; set; }

        public decimal SoldeResult { get; set; }
        public List<Operation> Operations { get; set; }
        public ICommand CreateCommand { get; set; } 
        public ICommand SearchCommand { get; set; }
        

        public void ActionSearch()
        {
            SearchCompte = banque.RechercherCompte(CompteId);
            if(SearchCompte != default(Compte))
            {
                SearchClient = SearchCompte.Client.ToString();
                RaisePropertyChanged("SearchClient");
                Operations = SearchCompte.Operations;
                RaisePropertyChanged("Operations");
                SoldeResult = SearchCompte.Solde;
                RaisePropertyChanged("SoldeResult");
            }
        }

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
