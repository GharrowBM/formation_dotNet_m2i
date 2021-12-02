using CoursWPFMVVM.ViewModels;
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

namespace CoursWPFMVVM.Views
{
    /// <summary>
    /// Logique d'interaction pour PersonnesWindow.xaml
    /// </summary>
    public partial class PersonnesWindow : Window
    {
        public PersonnesWindow()
        {
            InitializeComponent();
            DataContext = new PersonnesViewModel();
        }
    }
}
