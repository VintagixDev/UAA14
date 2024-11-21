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

namespace _6TTI_ClaudeMael_ACT4_Matching
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Button[,] buttons = new Button[4, 4];
        public MainWindow()
        {
            InitializeComponent();

            InitializeObjects();
            
        }

        public void btnClick(object sender, RoutedEventArgs e)
        {
            ((Button)sender).Content = "X";
        }
        public void InitializeObjects()
        {

           

            for(int i = 0;i < 4;i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                RowDefinition row = new RowDefinition();
                gridMain.ColumnDefinitions.Add(col);
                gridMain.RowDefinitions.Add(row);
                for(int j = 0;j < 4; j++)
                {
                    Button button = new Button();
                    button.Content = "?";
                    button.HorizontalAlignment = HorizontalAlignment.Stretch;
                    button.VerticalAlignment = VerticalAlignment.Stretch;
           
                    button.FontSize = 24;
                    button.Click += new RoutedEventHandler(btnClick);
                    Grid.SetRow(button, i);
                    Grid.SetColumn(button, j);
                    gridMain.Children.Add(button);
                    buttons[i, j] = button;
                    
                }
            }


        }
    }
}
