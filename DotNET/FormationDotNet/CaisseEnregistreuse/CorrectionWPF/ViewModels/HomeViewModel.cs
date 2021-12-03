using CaisseEnregistreuse.Classes;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CorrectionWPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private Vente vente;
        private Produit produit;
        private Caisse caisse;
        public int IdProduit { get; set; }
        public decimal Total { get => Vente.Total; }
        public Vente Vente { get => vente; set => vente = value; }

        public ObservableCollection<Produit> ProduitsVente { get; set; }

        public ICommand AjouterProduitCommand { get; set; }
        public ICommand NouvelleVenteCommand { get; set; }
        public ICommand PayerCommand { get; set; }
        public ICommand ListProduitsCommand { get; set; }

        public HomeViewModel()
        {
            Vente = new Vente();
            ProduitsVente = new ObservableCollection<Produit>();
        }
    }
}
