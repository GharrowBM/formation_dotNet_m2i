
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
using System.Threading;
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

        private ProduitVente selectedProduit;
        public int IdProduit { get; set; }
        public decimal Total { get => Vente.Total; }
        public Vente Vente { get => vente; set => vente = value; }

        public ObservableCollection<ProduitVente> ProduitsVente { get; set; }

        public ICommand AjouterProduitCommand { get; set; }
        public ICommand NouvelleVenteCommand { get; set; }
        public ICommand PayerCommand { get; set; }
        public ICommand ListProduitsCommand { get; set; }

        public ICommand SupprimerProduitCommand { get; set; }
        public ICommand ListVentesCommand { get; set; }
        public ProduitVente SelectedProduit { get => selectedProduit; set => selectedProduit = value; }

        public HomeViewModel()
        {
            caisse = new Caisse();
            Vente = new Vente();
            ProduitsVente = new ObservableCollection<ProduitVente>();
            AjouterProduitCommand = new RelayCommand(ActionAjouterProduit);
            NouvelleVenteCommand = new RelayCommand(ActionNouvelleVente);
            PayerCommand = new RelayCommand(ActionPayer);
            ListProduitsCommand = new RelayCommand(ActionListProduits);
            SupprimerProduitCommand = new RelayCommand(ActionSupprimerCommand);
            ListVentesCommand = new RelayCommand(ActionListVentes);
        }

        private void ActionAjouterProduit()
        {
            Task<Produit> taskProduit = Task.Run(() =>
            {
                Thread.Sleep(3000);
                return caisse.RechercherProduit(IdProduit);
                }
            );
            taskProduit.Wait();
            //produit = caisse.RechercherProduit(IdProduit);
            if (taskProduit.Result != default(Produit))
            {
                if (Vente.AjouterProduit(taskProduit.Result))
                {
                    ProduitsVente.Add(new ProduitVente() { Produit = taskProduit.Result });
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
            if (paiement.Payer(Total))
            {
                if (caisse.AjouterVente(Vente, paiement))
                {
                    MessageBox.Show("Vente effectuée");
                    if (viewModelVenteWindow != default(VentesViewModel))
                    {
                        Vente.TotalFromBase = Vente.Total;
                        viewModelVenteWindow.Ventes.Add(Vente);
                    }
                    ActionNouvelleVente();
                }
                else
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
            if (SelectedProduit != default(ProduitVente))
            {
                if (Vente.SupprimerProduit(selectedProduit.Produit.Id))
                {
                    ProduitsVente.Remove(SelectedProduit);
                    RaisePropertyChanged("Total");
                }
            }
        }
    }
}
