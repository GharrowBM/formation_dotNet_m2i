using CompteBancaireVersion1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CorrectionBanqueWPF.Windows
{
    /// <summary>
    /// Logique d'interaction pour OperationWindow.xaml
    /// </summary>
    public partial class OperationWindow : Window
    {
        private Compte compte;
        private string type;
        private ListView listViewOperations;
        private TextBlock textBlockSolde;

        public OperationWindow()
        {
            InitializeComponent();
        }

        public OperationWindow(Compte compte, string type, ListView listViewOperation, TextBlock textBlockSolde) : this()
        {
            this.compte = compte;
            this.type = type;
            this.listViewOperations = listViewOperation;
            this.textBlockSolde = textBlockSolde;
            typeOperation.Text = type;
            numeroCompte.Text = compte.Id.ToString();
        }


        private void ValidClick(object sender, RoutedEventArgs eventArgs)
        {
            if(decimal.TryParse(montant.Text, out decimal valMontant))
            {
                if(type == "retrait")
                {
                    if(compte.Retrait(new Operation(valMontant * -1)))
                    {
                        //listViewOperations.ItemsSource =Operation.GetOperations(compte.Id);
                        textBlockSolde.Text = compte.Solde.ToString();
                    }
                }
                else if(type == "depot")
                {
                    if (compte.Depot(new Operation(valMontant)))
                    {
                       //listViewOperations.ItemsSource = Operation.GetOperations(compte.Id);

                        textBlockSolde.Text = compte.Solde.ToString();
                    }
                }
                Close();
            }
        }
    }
}
