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
    /// Logique d'interaction pour HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        Banque banque;
        public HomeWindow()
        {
            InitializeComponent();
            banque = new Banque();
        }


        public void CreateClick(object sender, RoutedEventArgs eventArgs)
        {
            Client client = banque.CreerClient(nom.Text, prenom.Text, telephone.Text);
            if(client != default(Client))
            {

                if(decimal.TryParse(solde.Text, out decimal sd))
                {
                    Compte compte = banque.CreationCompte(client, sd, "1");
                    if(compte != default(Compte))
                    {
                        createResult.Text = "compte crée avec le numéro "+ compte.Id;
                    }
                    else
                    {
                        createResult.Text = "Erreur création compte";
                    }
                }else
                {
                    createResult.Text = "Merci de saisir un nombre";
                }
            }
            else
            {
                createResult.Text = "Erreur création client";
            }
        }
    }
}
