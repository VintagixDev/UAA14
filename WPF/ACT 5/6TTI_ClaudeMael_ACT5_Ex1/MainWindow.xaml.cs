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

namespace _6TTI_ClaudeMael_ACT5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            bool alternateColor = true;
            CreateObjects(alternateColor);
            
        }


        public void CreateObjects(bool color)
        {
            Button[,] buttons = new Button[10, 10];
            for (int i = 0; i < 10; i++)
            {
                gridMain.RowDefinitions.Add(new RowDefinition());
                gridMain.ColumnDefinitions.Add(new ColumnDefinition());
            }

            int index = 1;
            
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    Button btn = new Button();
                    btn.Content = index.ToString();
                    btn.Background = Brushes.White;
                    if (color)
                    {
                        btn.Background = Brushes.Black;
                    }
                    btn.HorizontalAlignment = HorizontalAlignment.Stretch;
                    btn.VerticalAlignment = VerticalAlignment.Stretch;
                    btn.BorderThickness = new Thickness(0, 0, 0, 0);
                    btn.FontSize = 18;
                    btn.FontWeight = FontWeights.Bold;
                    btn.Foreground = Brushes.Red;
                    btn.Click += onClick;
                    Grid.SetRow(btn, i);
                    Grid.SetColumn(btn, j);
                    buttons[i, j] = btn;
                    gridMain.Children.Add(btn);
                    index++;
                    color = !color;
                }
                color = !color;
            }
        }

        public void onClick(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "";
        }
    }
}
