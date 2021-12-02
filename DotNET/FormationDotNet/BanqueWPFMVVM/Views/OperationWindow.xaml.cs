using BanqueWPFMVVM.ViewModels;
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

namespace BanqueWPFMVVM.Views
{
    /// <summary>
    /// Logique d'interaction pour OperationWindow.xaml
    /// </summary>
    public partial class OperationWindow : Window
    {
        public OperationWindow()
        {
            InitializeComponent();
        }

        public OperationWindow(string type, Compte compte, HomeViewModel homeViewModel) : this()
        {
            DataContext = new OperationViewModel(type, compte, homeViewModel);
        }
    }
}
