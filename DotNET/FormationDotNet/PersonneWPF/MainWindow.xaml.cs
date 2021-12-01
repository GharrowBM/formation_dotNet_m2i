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
        Personne SelectedPersonne;
        public MainWindow()
        {
            InitializeComponent();
            personneList = new ObservableCollection<Personne>(Personne.GetPersonnes());
            listBoxPersonne.ItemsSource = personneList;
            listViewPersonne.ItemsSource = personneList;
        }

        public void ValidClick(object sender, RoutedEventArgs eventArgs)
        {
            if(SelectedPersonne != default(Personne))
            {
                SelectedPersonne.Titre = titre.Text;
                SelectedPersonne.Nom = nom.Text;
                SelectedPersonne.Prenom = prenom.Text;
                SelectedPersonne.Telephone = telephone.Text;
                SelectedPersonne.Email = email.Text;
                if(SelectedPersonne.Update())
                {
                    SelectedPersonne = default(Personne);
                    personneList = new ObservableCollection<Personne>(Personne.GetPersonnes());
                    listViewPersonne.ItemsSource=personneList;
                }
            }
            else
            {
                personne = new Personne();
                personne.Nom = nom.Text;
                personne.Titre = titre.Text;
                personne.Prenom = prenom.Text;
                personne.Email = email.Text;
                personne.Telephone = telephone.Text;
                if (personne.Save())
                {
                    personneList.Add(personne);
                }
            }
            nom.Text = "";
            prenom.Text = "";
            titre.Text = "";
            telephone.Text = "";
            email.Text = "";
        }
        public void DeleteClick(object sender, RoutedEventArgs eventArgs)
        {
            SelectedPersonne = (Personne)listViewPersonne.SelectedItem;
            if(SelectedPersonne != default(Personne) && SelectedPersonne.Delete())
            {
                personneList.Remove(SelectedPersonne);  
                SelectedPersonne = default(Personne);
            }
        }
        public void EditClick(object sender, RoutedEventArgs eventArgs)
        {
            SelectedPersonne = (Personne)listViewPersonne.SelectedItem;
            if(SelectedPersonne != default(Personne))
            {
                titre.Text = SelectedPersonne.Titre;
                nom.Text = SelectedPersonne.Nom;
                prenom.Text = SelectedPersonne.Prenom;
                email.Text = SelectedPersonne.Email;
                telephone.Text = SelectedPersonne.Telephone;
            }
        }
    }
}
