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



namespace _6TTI_ClaudeMael_ACT3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Methodes methods = new Methodes(); // Instanciation de la Class Method

        public MainWindow()
        {
            InitializeComponent();
            BtnV.Visibility = Visibility.Hidden;
            BtnCalculer.MouseEnter += new MouseEventHandler(SurvolBoutonE); // Event de début de survol du bouton Calculer
            BtnCalculer.MouseLeave += new MouseEventHandler(SurvolBoutonL); // Event de fin de survol du bouton Calculer

            BtnCalculer.Click += new RoutedEventHandler(BtnCalculer_Click); // Event Cliquer sur le bouton Calculer




            txtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput); // Event vérification d'input
            txtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput); // Event vérification d'input
            txtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput); // Event vérification d'input
        }


        /// <summary>
        /// Calculer et ouvrir une nouvelle fenêtre contenant le résultat du trinôme du second degré
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculer_Click(object sender, RoutedEventArgs e)
        {
            double a;
            double b;
            double c;
            string type;
            double.TryParse(txtA.Text, out a);
            double.TryParse(txtB.Text, out b);
            double.TryParse(txtC.Text, out c);
            methods.ResoudreTrinome(a, b, c, out type);
            PageResultat result = new PageResultat();  // Instanciation de la page du résultat
            result.resultText.Text = type; // Modifier le texte sur la page du résultat
            result.Show(); // Afficher la page du réusltat

        }

        /// <summary>
        /// Vérification des inputs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if(e.Text != "," && e.Text != "-" && !EstEntier(e.Text)){
                e.Handled = true;
            }
            if (((TextBox)sender).Text.IndexOf(e.Text) > -1){
                e.Handled = true;
            }
        }
        /// <summary>
        /// Survol du Bouton "Calculer)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurvolBoutonE(object sender, MouseEventArgs e)
        {

            BtnV.Visibility = Visibility.Visible;
            BtnV.Background = Brushes.Red;
        }
        /// <summary>
        /// Fin de survol du bouton Calculer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SurvolBoutonL(object sender, MouseEventArgs e)
        {

            BtnV.Visibility = Visibility.Hidden;
        }

        /// <summary>
        /// Vérification de l'input, si c'est un entier
        /// </summary>
        /// <param name="texteUser"></param>
        /// <returns></returns>
        public bool EstEntier(string texteUser)
        {

            return double.TryParse(texteUser, out double result);
            
        }
    }
}
