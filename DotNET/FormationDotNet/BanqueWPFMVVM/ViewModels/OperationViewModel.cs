using CompteBancaireVersion1.Classes;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BanqueWPFMVVM.ViewModels
{
    internal class OperationViewModel
    {
        public string Type { get; set; }
        public Compte Compte { get; set; }
        
        public decimal Montant { get; set; }
        
        public ICommand OperationCommand { get; set; } 

        private HomeViewModel _homeViewModel;
        
        public OperationViewModel(string type, Compte compte, HomeViewModel homeViewModel)
        {
            Type = type;
            Compte = compte;
            OperationCommand = new RelayCommand(ActionOperation);
            _homeViewModel = homeViewModel;
        }

        private void ActionOperation()
        {
            bool ok = false;
            if (Type == "retrait")
            {
                ok = Compte.Retrait(new Operation(Montant * -1));
            }
            else if (Type == "depot")
            {
                ok = Compte.Depot(new Operation(Montant));
            }
            if(ok)
            {
                //_homeViewModel.Operations = Operation.GetOperations(Compte.Id);
                _homeViewModel.RaisePropertyChanged("Operations");
                _homeViewModel.SoldeResult = Compte.Solde;
                _homeViewModel.RaisePropertyChanged("SoldeResult");
            }
            
        }
    }
}
