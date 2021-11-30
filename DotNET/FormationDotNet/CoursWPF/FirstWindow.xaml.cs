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

namespace CoursWPF
{
    /// <summary>
    /// Logique d'interaction pour FirstWindow.xaml
    /// </summary>
    public partial class FirstWindow : Window
    {
        public FirstWindow()
        {
            InitializeComponent();
            //Grid grid = new Grid();
           
            for(int i = 1; i <= 3; i++)
            {
                maGrille.RowDefinitions.Add(new RowDefinition() { Height =new GridLength(i, GridUnitType.Star)});
                maGrille.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(i, GridUnitType.Star)}); 
            }
            for(int i = 0;i < 3;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Button button = new Button()
                    {
                        Content = $"{i} X {j}",
                        Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#cd2127")),
                    };
                    maGrille.Children.Add(button);
                    Grid.SetColumn(button, j);
                    Grid.SetRow(button, i);
                }
            }
           //Content = maGrille;
           
        }
    }
}
