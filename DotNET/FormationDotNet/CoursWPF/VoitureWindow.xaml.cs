using CoursWPF.Classes;
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
using System.Windows.Shapes;

namespace CoursWPF
{
    /// <summary>
    /// Logique d'interaction pour Voiture.xaml
    /// </summary>
    public partial class VoitureWindow : Window
    {
        Voiture voiture;
        ObservableCollection<Voiture> voitureList;
        public VoitureWindow()
        {
            InitializeComponent();
            voitureList = new ObservableCollection<Voiture>();
            maListeVoiture.ItemsSource = voitureList;
        }

        public void ValidClick(object sender, RoutedEventArgs eventArgs)
        {
            MessageBox.Show(marque.Text + " " + model.Text);
            voiture = new Voiture()
            {
                Marque = marque.Text,
                Model = model.Text,
            };

            voitureList.Add(voiture);
            marque.Text = "";
            model.Text = "";

        }
    }
}
