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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FormationUserControl.UserControls
{
    /// <summary>
    /// Logique d'interaction pour Product.xaml
    /// </summary>
    public partial class Product : UserControl
    {


        public string Title
        {
            get { 
                return (string)GetValue(TitleProperty); }
            set { 
                SetValue(TitleProperty, value); 
            }
        }

        // Using a DependencyProperty as the backing store for string Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(Product), new PropertyMetadata(null, new PropertyChangedCallback(TitleChanged)));


        private static void TitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Product p = (Product)d;
            p.titleLabel.Content= (string)e.NewValue;
        }

        public decimal Price { get; set; }
        public Product()
        {
            InitializeComponent();
            titleLabel.Content = Title;
            priceLabel.Content = Price;
        }
    }
}
