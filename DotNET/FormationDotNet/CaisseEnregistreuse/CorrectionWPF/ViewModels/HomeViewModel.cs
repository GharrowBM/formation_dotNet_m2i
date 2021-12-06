
using CaisseEnregistreuse.Classes;
using CaisseEnregistreuse.Interfaces;
using CorrectionWPF.Views;
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
    public class HomeViewModel : ViewModelBase
    {
        private Vente vente;
        private Produit produit;
        private Caisse caisse;
        private VentesViewModel viewModelVenteWindow;

        private Produit selectedProduit;
        public int IdProduit { get; set; }
        public decimal Total { get => Vente.Total; }
        public Vente Vente { get => vente; set => vente = value; }

        public ObservableCollection<Produit> ProduitsVente { get; set; }

        public ICommand AjouterProduitCommand { get; set; }
        public ICommand NouvelleVenteCommand { get; set; }
        public ICommand PayerCommand { get; set; }
        public ICommand ListProduitsCommand { get; set; }

        public ICommand SupprimerProduitCommand { get; set; }
        public ICommand ListVentesCommand { get; set; }
        public Produit SelectedProduit { get => selectedProduit; set => selectedProduit = value; }

        public HomeViewModel()
        {
            caisse = new Caisse();
            Vente = new Vente();
            ProduitsVente = new ObservableCollection<Produit>();
            AjouterProduitCommand = new RelayCommand(ActionAjouterProduit);
            NouvelleVenteCommand = new RelayCommand(ActionNouvelleVente);
            PayerCommand = new RelayCommand(ActionPayer);
            ListProduitsCommand = new RelayCommand(ActionListProduits);
            SupprimerProduitCommand = new RelayCommand(ActionSupprimerCommand);
            ListVentesCommand = new RelayCommand(ActionListVentes);
        }

        private void ActionAjouterProduit()
        {
            produit = caisse.RechercherProduit(IdProduit);
            if(produit != default(Produit))
            {
                if(Vente.AjouterProduit(produit))
                {
                    ProduitsVente.Add(produit);
                    RaisePropertyChanged("Total");
                }
                else
                {
                    MessageBox.Show("erreur d'ajout produit dans la vente");

                }
            }
            else
            {
                MessageBox.Show("Aucun produit avec ce numéro");
            }
        }

        private void ActionNouvelleVente()
        {
            ProduitsVente.Clear();
            Vente = new Vente();
            RaisePropertyChanged("Total");
            IdProduit = 0;
            RaisePropertyChanged("IdProduit");
        }

        private void ActionListVentes()
        {
            viewModelVenteWindow = new VentesViewModel(caisse);
            VentesWindow w = new VentesWindow(viewModelVenteWindow);
            w.Show();
        }
        private void ActionPayer()
        {
            IPaiement paiement = new PaiementCB();
            if(paiement.Payer(Total))
            {
                if(caisse.AjouterVente(Vente, paiement))
                {
                    MessageBox.Show("Vente effectuée");
                    if(viewModelVenteWindow != default(VentesViewModel))
                    {
                        Vente.TotalFromBase = Vente.Total;
                        viewModelVenteWindow.Ventes.Add(Vente);
                    }
                    ActionNouvelleVente();
                }else
                {
                    MessageBox.Show("Erreur vente");
                }
            }
            else
            {
                MessageBox.Show("Paiement refusé");
            }
        }

        private void ActionListProduits()
        {
            ProductWindow w = new ProductWindow(caisse);
            w.Show();
        }

        private void ActionSupprimerCommand()
        {
            if(SelectedProduit != default(Produit))
            {
                if(Vente.SupprimerProduit(selectedProduit.Id))
                {
                    ProduitsVente.Remove(SelectedProduit);
                    RaisePropertyChanged("Total");
                }
            }
        }
    }
}
