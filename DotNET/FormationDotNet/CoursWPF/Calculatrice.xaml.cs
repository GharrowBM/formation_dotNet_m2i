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
    /// Logique d'interaction pour Calculatrice.xaml
    /// </summary>
    public partial class Calculatrice : Window
    {
        private string[] valTab = { "AC", "+/-", "%", "/", "7", "8", "9", "*", "4", "5", "6", "-", "1", "2", "3", "+", "0", ",", "=" };
        public Calculatrice()
        {
            InitializeComponent();
            CreateRowsAndCols();
            CreateButton();
            CreateLabel();
        }


        private void CreateRowsAndCols()
        {
            for(int i=1; i<= 6; i++)
            {
                if(i <= 4)
                {
                    maGrille.ColumnDefinitions.Add(new ColumnDefinition());
                }           
                GridLength length = new GridLength((i==1) ? 2 : 1, GridUnitType.Star);
                maGrille.RowDefinitions.Add(new RowDefinition() { Height = length});
            }
        }

        private void CreateButton()
        {
            int ligne = 1;
            int col = 0;
            for(int i=0; i <  valTab.Length; i++)
            {
                Button button = new Button()
                {
                    Content = valTab[i],
                };
                Grid.SetRow(button, ligne);
                Grid.SetColumn(button, col);

                SolidColorBrush background;
                if(ligne == 1 && col != 3)
                {
                    background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#ccc"));
                }
                else if(col == 3)
                {
                    background = new SolidColorBrush(Colors.Orange);
                }
                else
                {
                    background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#666"));
                }
                button.Background = background;
                if (valTab[i] == "0")
                {
                    Grid.SetColumnSpan(button, 2);
                    col++;
                }
                if((i+1)%4 == 0)
                {
                    col = 0;
                    ligne++;
                }
                else
                {
                    col++;
                }
                maGrille.Children.Add(button);
            }
        }

        private void CreateLabel()
        {
            Label label = new Label()
            {
                Content = "0",
                FontSize = 60,
                VerticalAlignment = VerticalAlignment.Stretch,
                HorizontalAlignment = HorizontalAlignment.Stretch,
                Background = new SolidColorBrush(Colors.Black),
                Foreground = new SolidColorBrush (Colors.White),  
                HorizontalContentAlignment = HorizontalAlignment.Right,
                VerticalContentAlignment = VerticalAlignment.Bottom,
            };
            maGrille.Children.Add(label);
            Grid.SetRow(label, 0);
            Grid.SetColumn(label, 0);
            Grid.SetColumnSpan(label, 4);
            //maGrille.Background = new SolidColorBrush(Colors.Black);
        }
    }
}
