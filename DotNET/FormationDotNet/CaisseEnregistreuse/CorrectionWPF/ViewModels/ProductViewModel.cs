using CaisseEnregistreuse.Classes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CorrectionWPF.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        private Produit produit;
        private Caisse caisse;

        public string Titre
        {
            get => produit.Titre;
            set => produit.Titre = value;
        }
        public decimal Prix
        {
            get => produit.Prix;
            set => produit.Prix = value;
        }

        public int Stock
        {
            get => produit.Stock;
            set => produit.Stock = value;
        }

        public ObservableCollection<Produit> Produits { get; set; }

        public ICommand AjouterProduitCommand { get; set; }

        public ProductViewModel(Caisse _caisse)
        {
            produit = new Produit();
            caisse = _caisse;
            Produits = new ObservableCollection<Produit>(caisse.RecupererProduits());
            AjouterProduitCommand = new RelayCommand(ActionAjouterProduit);
        }

        private void ActionAjouterProduit()
        {
            if(caisse.AjouterProduit(produit))
            {
                Produits.Add(produit);
                MessageBox.Show("Produit ajouté");
                produit = new Produit();
                RaisePropertyChanged("Titre");
                RaisePropertyChanged("Prix");
                RaisePropertyChanged("Stock");
            }
            else
            {
                MessageBox.Show("Erreur ajout prduit");
            }
        }

    }
}
