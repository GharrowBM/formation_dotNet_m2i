using CaisseEnregistreuse.Classes;
using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CorrectionWPF.ViewModels
{
    public class VentesViewModel : ViewModelBase
    {
        private Caisse caisse;
        public ObservableCollection<Vente> Ventes { get; set; }
        public VentesViewModel(Caisse caisse)
        {
            this.caisse = caisse;
            Ventes = new ObservableCollection<Vente>(this.caisse.RecupererVentes());
        }
    }
}
