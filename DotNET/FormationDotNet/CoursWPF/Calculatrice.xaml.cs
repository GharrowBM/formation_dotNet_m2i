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
        private Label label;
        private string[] valTab = { "AC", "+/-", "%", "/", "7", "8", "9", "*", "4", "5", "6", "-", "1", "2", "3", "+", "0", ",", "=" };
        bool newNumber = true;
        bool isFirstOperation = true;
        decimal firstNumber;
        string lastOperation = "";
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
                button.Click += ClickButtonCalculatrice;
                maGrille.Children.Add(button);
            }
        }

        private void CreateLabel()
        {
            label = new Label()
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

        public void ClickButtonCalculatrice(object sender, RoutedEventArgs eventArgs)
        {          
            if (sender is Button b)
            {
                string contentButton = b.Content.ToString();
                string oldContent = label.Content.ToString();
                if (Int32.TryParse(contentButton, out int nombre) || (contentButton == "," && !oldContent.Contains(",")))
                {
                    if(newNumber)
                    {
                        label.Content = (contentButton == ",") ? "0," : nombre.ToString();
                        newNumber = false;
                    }else
                    {
                        label.Content = oldContent + contentButton;
                    }
                }
                else
                {
                    newNumber = true;
                    decimal currentNumber;
                    switch (contentButton)
                    {
                        case "AC":
                            label.Content = 0;
                            
                            isFirstOperation = true;
                            lastOperation = "";
                            break;
                        case "+":
                            if(isFirstOperation)
                            {
                                isFirstOperation = false;   
                                decimal.TryParse(label.Content.ToString(),out firstNumber);
                            }
                            else
                            {
                                switch(lastOperation)
                                {
                                    case "+":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = currentNumber + firstNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "-":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber - currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "*":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber * currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "/":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber / currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                }
                            }
                            lastOperation = "+";
                            break;
                        case "-":
                            if (isFirstOperation)
                            {
                                isFirstOperation = false;
                                decimal.TryParse(label.Content.ToString(), out firstNumber);
                            }
                            else
                            {
                                switch (lastOperation)
                                {
                                    case "+":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = currentNumber + firstNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "-":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber - currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "*":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber * currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "/":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber / currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                }
                            }
                            lastOperation = "-";
                            break;
                        case "*":
                            if (isFirstOperation)
                            {
                                isFirstOperation = false;
                                decimal.TryParse(label.Content.ToString(), out firstNumber);
                            }
                            else
                            {
                                switch (lastOperation)
                                {
                                    case "+":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = currentNumber + firstNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "-":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber - currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "*":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber *currentNumber ;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "/":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber /  currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                }
                            }
                            lastOperation = "*";
                            break;
                        case "/":
                            if (isFirstOperation)
                            {
                                isFirstOperation = false;
                                decimal.TryParse(label.Content.ToString(), out firstNumber);
                            }
                            else
                            {
                                switch (lastOperation)
                                {
                                    case "+":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = currentNumber + firstNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "-":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber - currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "*":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber * currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                    case "/":
                                        if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                        {
                                            firstNumber = firstNumber / currentNumber;
                                            label.Content = firstNumber;
                                        }
                                        break;
                                }
                            }
                            lastOperation = "/";
                            break;
                        case "=":
                            switch (lastOperation)
                            {
                                case "+":
                                    if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                    {
                                        firstNumber = currentNumber + firstNumber;
                                        label.Content = firstNumber;
                                    }
                                    break;
                                case "-":
                                    if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                    {
                                        firstNumber = firstNumber - currentNumber;
                                        label.Content = firstNumber;
                                    }
                                    break;
                                case "*":
                                    if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                    {
                                        firstNumber = firstNumber * currentNumber;
                                        label.Content = firstNumber;
                                    }
                                    break;
                                case "/":
                                    if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                                    {
                                        firstNumber = firstNumber / currentNumber;
                                        label.Content = firstNumber;
                                    }
                                    break;
                            }
                            lastOperation = "";
                            isFirstOperation = true;
                            newNumber = true;
                            break;
                        case "+/-":
                            newNumber = false;
                            if(Decimal.TryParse(label.Content.ToString(),out currentNumber))
                            {
                                label.Content = currentNumber*-1;
                            }
                            break;
                        case "%":
                            newNumber = false;
                            if (Decimal.TryParse(label.Content.ToString(), out currentNumber))
                            {
                                label.Content = currentNumber / 100;
                            }
                            break;
                            break;
                    }
                }

            }
        }
    }
}
