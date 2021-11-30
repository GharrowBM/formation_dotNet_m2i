using PersonneAdresse.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PersonneWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Personne personne;
        ObservableCollection<Personne> personneList;
        public MainWindow()
        {
            InitializeComponent();
            personneList = new ObservableCollection<Personne>(Personne.GetPersonnes());
            listBoxPersonne.ItemsSource = personneList;
        }

        public void AjouterPersonne(object sender, RoutedEventArgs eventArgs)
        {
            personne = new Personne();
            personne.Nom = nom.Text;
            personne.Titre = titre.Text;
            personne.Prenom = prenom.Text;
            personne.Email = email.Text;
            personne.Telephone = telephone.Text;
            if(personne.Save())
            {
                personneList.Add(personne);
            }
        }
    }
}
