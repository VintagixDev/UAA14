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

namespace CE_UAA14WPF_Dec24_ClaudeMael
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtBox_col.PreviewTextInput += VerifIntInput; // Vérifier l'input de l'utilisateur
            txtBox_lignes.PreviewTextInput += VerifIntInput; // Vérifier l'input de l'utilisateur

            btn_valider.Click += btnValiderClick; // Cliquer sur le bouton "VALIDER"
            taille.Visibility = Visibility.Hidden; // Cacher le GroupBox "Taille"
            radio_bande.Click += ShowTaille; // Afficher le GroupBox "Taille"
            radio_marelle.Click += HideTaille; // Cacher le GroupBox "Taille"
            radio_solitaire.Click += HideTaille;// Cacher le GroupBox "Taille"
            gridMain.Height = 760; // Définir taille grille (sinon NaN lors du calcul pour la taille des boutons)
            gridMain.Width = 785; // Définir taille grille (sinon NaN lors du calcul pour la taille des boutons)
        }
        private void btnValiderClick(object sender, RoutedEventArgs e)
        {

            
            // Si le Radio Solitaire est coché
            if ((bool)radio_solitaire.IsChecked)
            {
                ResetGrid();
                Solitaire();
                error.Text = "Text WPF 6T 2024";
            }
            // Si le Radio Marelle est coché
            if ((bool)radio_marelle.IsChecked)
            {
                ResetGrid();
                Marelle();
                error.Text = "Text WPF 6T 2024";
            }
            // Si le Radio Bande Latérale est coché
            if((bool)radio_bande.IsChecked)
            {
                int lignes;
                int col;
                int.TryParse(txtBox_lignes.Text, out lignes);
                int.TryParse(txtBox_col.Text, out col);

                // Vérifier si l'input n'est pas vide
                if (txtBox_col.Text == "" || txtBox_lignes.Text == "")
                {
                    error.Text = "Veuillez encoder des dimensions valides comprises entre 2 et 12.";
                    return;
                }
                // Vérifier si l'input est min 2x2 max 12x12
                if((lignes > 12 || col > 12) || (lignes < 2 || col < 2))
                {
                    error.Text = "Veuillez encoder des dimensions valides comprises entre 2 et 12.";
                    return;
                }
                ResetGrid();
                BandeLaterale(lignes, col);
                error.Text = "Text WPF 6T 2024";
            }

            
        }



        /// <summary>
        /// échanger les couleurs entre le Background et le Foreground
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeColor(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            Brush brush = btn.Background;
            btn.Background = btn.Foreground;
            btn.Foreground = brush;

        }

        /// <summary>
        /// Créer le bouton pour la Bande Latérale
        /// </summary>
        /// <param name="lignes">nombre utilisé pour définir la taille du bouton</param>
        /// <param name="col">nombre utilisé pour définir la taille du bouton</param>
        /// <returns></returns>
        public Button BandeLaterale_Button( int lignes, int col)
        {
            
            Button btn = new Button();
            btn.Background = Brushes.Khaki;
            btn.Content = "X";
            btn.Foreground = Brushes.Red;
            btn.FontWeight = FontWeights.Bold;
            btn.FontSize = 22;
            btn.Width = gridMain.Width / col;
            btn.Height = gridMain.Height / lignes;
            btn.Click += ChangeColor;
            return btn;

            
        }
        
        /// <summary>
        /// Créer la grid de la Bande Latérale
        /// </summary>
        /// <param name="lignes">nombre de lignes</param>
        /// <param name="col">nombre de colonnes</param>
        public void BandeLaterale(int lignes, int col)
        {
           
            
            
            for(int i = 0;i < lignes; i++)
            {
                gridMain.RowDefinitions.Add(new RowDefinition());
                
                
            }
            for(int i = 0;i < col; i++)
            {
                gridMain.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for(int i = 0; i < lignes; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    if(i == 0 || i == lignes-1 || j == 0 || j == col-1)
                    {
                        Button btn = BandeLaterale_Button(lignes, col);
                        gridMain.Children.Add(btn);
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);
                    }
                }
            }


            

            


        }

        /// <summary>
        /// Cacher le GroupBox "Taille"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HideTaille(object sender, RoutedEventArgs e)
        {
            taille.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Afficher le GroupBox "Taille"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowTaille(object sender, RoutedEventArgs e)
        {
            taille.Visibility= Visibility.Visible;
        }

        /// <summary>
        /// Réinitialiser la grille
        /// </summary>
        public void ResetGrid()
        {
            gridMain.Children.Clear();
            gridMain.RowDefinitions.Clear();
            gridMain.ColumnDefinitions.Clear();
        }

        /// <summary>
        /// Ajouter les colonnes et lignes nécessaire à la grille
        /// </summary>
        /// <param name="nbr">Dimensions (carré)</param>
        /// <param name="grid">Grille dans laquelle il faut ajouter les dimensions</param>
        /// <param name="btns">Bool utilisé pour savoir si on ajoute des boutons aux emplacements ou non</param>
        public void addColAndRow(int nbr, Grid grid, bool btns)
        {
            for(int i = 0; i < nbr; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            if (btns)
            {
                for(int i = 0; i < 3; i++)
                {
                    for(int j = 0; j < 3; j++)
                    {

                        Button btn = createButton();
                        grid.Children.Add(btn);
                        
                        Grid.SetRow(btn, i);
                        Grid.SetColumn(btn, j);
                    }
                }
            }
        }

        /// <summary>
        /// Créer les boutons pour le Solitaire et la Marelle
        /// </summary>
        /// <returns></returns>
        public Button createButton()
        {
            Button btn = new Button();

            btn.Background = Brushes.Khaki;
            Image image = new Image();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("Assets/petitCercleRouge.png", UriKind.Relative);

            bitmap.EndInit();
            image.Source = bitmap;
            btn.Content = image;

            btn.Click += btnClick;
            return btn;
        }

        /// <summary>
        /// évenement appelé lorsqu'on clique sur les boutons du solitaire ou de la marelle
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClick(object sender, RoutedEventArgs e)
        {

            Image image = new Image();
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri("Assets/golfBall60.png", UriKind.Relative);

            bitmap.EndInit();
            image.Source = bitmap;
            ((Button)sender).Content = image;
        }

        /// <summary>
        /// Générer la Marelle
        /// </summary>
        public void Marelle()
        {
            addColAndRow(7, gridMain, false);
            for(int i = 0; i < 7; i++) { 
                for(int j = 0; j < 7; j++)
                {
                    if(i != 3 || j != 3)
                    {

                        if(i == j) 
                        {
                            Button btn = createButton();
                            Grid.SetRow(btn, i);
                            Grid.SetColumn(btn, j);
                            gridMain.Children.Add(btn);
                        }

                        if((i == 0 && j == 6) ||
                            (i == 1 && j == 5) ||
                            (i == 2 && j == 4) ||
                            (i == 4 && j == 2) ||
                            (i == 5 && j == 1) ||
                            (i == 6 && j == 0)
                            )
                        {
                            Button btn = createButton();
                            Grid.SetRow(btn, i);
                            Grid.SetColumn(btn, j);
                            gridMain.Children.Add(btn);
                        }

                        if(i == 3 || j == 3) {
                            Button btn = createButton();
                            Grid.SetRow(btn, i);
                            Grid.SetColumn(btn, j);
                            gridMain.Children.Add(btn);
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Générer le Solitaire
        /// </summary>
        public void Solitaire()
        {
            addColAndRow(3, gridMain, false);

            for(int i = 0;i < 3;i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    
                    // Si aucune des positions n'est un des coins
                    if (!(i == 0 && j == 0) && !(i == 0 && j == 2) && !(i == 2 && j == 0) && !(i == 2 && j == 2))
                    {

                        Grid grid = new Grid();
                        addColAndRow(3, grid, true);
                        gridMain.Children.Add(grid);
                        Grid.SetRow(grid, i);
                        Grid.SetColumn(grid, j);

                    }
                }
            }

            
        }

        /// <summary>
        /// Vérifier si l'input de l'utilisateur est bien un nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerifIntInput(object sender, TextCompositionEventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (!int.TryParse(e.Text, out int value))
            {
                e.Handled = true;
            }
            if (txtBox.Text.Length > 1)
            {
                e.Handled = true;
            }
            if (!(value >= 1 && value <= 9))
            {
                e.Handled = true;
                
            }
            


           
        }

        

    }
}
