using CaisseEnregistreuse.Classes;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace CorrectionWPF.ViewModels
{
    public class ProductViewModel : ViewModelBase
    {
        private Produit produit;
        private Caisse caisse;
        private Dispatcher dispatcher;
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

        public ProductViewModel(Caisse _caisse, Dispatcher _dispatcher)
        {
            produit = new Produit();
            caisse = _caisse;
            dispatcher = _dispatcher;

            Task.Run(() =>
            {
                List<Produit> produits = caisse.RecupererProduits();
                Thread.Sleep(3000);
                dispatcher.Invoke(() =>
                {
                    Produits = new ObservableCollection<Produit>(produits);
                    RaisePropertyChanged("Produits");
                });

            });
            AjouterProduitCommand = new RelayCommand(ActionAjouterProduit);
        }

        private void ActionAjouterProduit()
        {
            Task.Run(() =>
            {
                bool result = caisse.AjouterProduit(produit);
                dispatcher.Invoke(() =>
                {
                    if (result)
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
                });
            });
            //if(caisse.AjouterProduit(produit))
            //{
            //    Produits.Add(produit);
            //    MessageBox.Show("Produit ajouté");
            //    produit = new Produit();
            //    RaisePropertyChanged("Titre");
            //    RaisePropertyChanged("Prix");
            //    RaisePropertyChanged("Stock");
            //}
            //else
            //{
            //    MessageBox.Show("Erreur ajout prduit");
            //}
        }

    }
}
