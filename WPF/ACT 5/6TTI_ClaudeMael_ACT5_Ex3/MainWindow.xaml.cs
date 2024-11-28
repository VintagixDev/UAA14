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

namespace _6TTI_ClaudeMael_ACT5_3
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
            Button[,] buttons = new Button[8, 8];
            for (int i = 0; i < 8; i++)
            {
                gridMain.RowDefinitions.Add(new RowDefinition());
                gridMain.ColumnDefinitions.Add(new ColumnDefinition());
            }

            

            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {


                    // Création du Button
                    Button btn = new Button();
                    
                    btn.Background = Brushes.White;
                    if (color)
                    {
                        btn.Background = Brushes.Black;
                    }
                    btn.HorizontalAlignment = HorizontalAlignment.Stretch;
                    btn.VerticalAlignment = VerticalAlignment.Stretch;
                    btn.BorderThickness = new Thickness(0, 0, 0, 0);               
                    Grid.SetRow(btn, i);
                    Grid.SetColumn(btn, j);
                    buttons[i, j] = btn;
                    gridMain.Children.Add(btn);
                   
                    color = !color;

                    // Vérification de la Row
                    if (i == 0 || i == 1 || i == buttons.GetLength(0)-1 || i == buttons.GetLength(0) - 2)
                    {

                        Image image = new Image();
                        BitmapImage bitmap = new BitmapImage();
                        bitmap.BeginInit();
                        
                        bitmap.UriSource = new Uri("Images/p.png", UriKind.Relative);

                        if(i == 0 || i == buttons.GetLength(0) - 1)
                        {
                            switch (j)
                            {
                                case 0 or 8:
                                    bitmap.UriSource = new Uri("Images/k.png", UriKind.Relative);
                                    break;
                                case 1 or 7:
                                    bitmap.UriSource = new Uri("Images/kn.png", UriKind.Relative);
                                    break;
                                case 2 or 6:
                                    bitmap.UriSource = new Uri("Images/b.png", UriKind.Relative);
                                    break;
                                case 3:
                                    bitmap.UriSource = new Uri("Images/k.png", UriKind.Relative);
                                    break;
                                case 4:
                                    bitmap.UriSource = new Uri("Images/q.png", UriKind.Relative);
                                    break;
                            }
                        }
                        bitmap.EndInit();
                        image.Source = bitmap;
                        btn.Content = image;
                    }
                }
                color = !color;
            }
        }
    }
}
