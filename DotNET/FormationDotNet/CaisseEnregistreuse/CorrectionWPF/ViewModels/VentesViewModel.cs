using CaisseEnregistreuse.Classes;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CorrectionWPF.ViewModels
{
    public class VentesViewModel : ViewModelBase
    {
        private Caisse caisse;
        public ObservableCollection<Vente> Ventes { get; set; }
        public VentesViewModel(Caisse caisse)
        {
            this.caisse = caisse;
            Task.Run(() =>
            {
                List<Vente> ventes = this.caisse.RecupererVentes();
                Application.Current.Dispatcher.Invoke(() =>
                {
                    Ventes = new ObservableCollection<Vente>(ventes);
                    RaisePropertyChanged("Ventes");
                });
            });
        }
    }
}
