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

namespace UAA14_I4_ClaudeMael
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Methodes methodes = new Methodes();
        public MainWindow()
        {
            InitializeComponent();

            // Events

            btnCalculer.Click += new RoutedEventHandler(Calculer); // Event appelé lors du click sur le bouton Calculer
            btnReset.Click += new RoutedEventHandler(Reset); // Event appelé lors du click sur le bouton Reset
            txtNombre1.PreviewTextInput += new TextCompositionEventHandler(VerifInput); // Event appelé lors d'un input dans la zone de texte n°1
            txtNombre2.PreviewTextInput += new TextCompositionEventHandler(VerifInput); // Event appelé lors d'un input dans la zone de texte n°2
        }

        /// <summary>
        /// Vérification de l'input dans la zone de texte 1 et 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VerifInput(object sender, TextCompositionEventArgs e)
        {
            if (!int.TryParse(e.Text, out int value))
            {
                e.Handled = true;
            }
            if(!(value == 0 || value == 1))
            {
                e.Handled = true;
            }
            
        }

        /// <summary>
        /// Vérification des inputs + calcul et affichage du résultat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calculer(object sender, RoutedEventArgs e)
        {
            if (!VerifierCalculInput(txtNombre1.Text)) return;
            if (!VerifierCalculInput(txtNombre2.Text)) return;

            ushort[] input1 = methodes.RemplirTableau(txtNombre1.Text);
            ushort[] input2 = methodes.RemplirTableau(txtNombre2.Text);

            ushort[] result;

            if(optAddition.IsChecked == true)
            {
                methodes.Additionne(input1, input2, out result, out bool ok);
            } else
            {
                methodes.Soustrait(input1, input2, out result);
            }

            resultText.Text = "Résultat : " + methodes.Concatene(result);
        }


        /// <summary>
        /// Vérification de la taille des inputs
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private bool VerifierCalculInput(string input)
        {
            if(input.Length == 0)
            {
                MessageBox.Show("Veuillez remplir le champ de texte avec un nombre binaire.");
                return false;
            }
            if(input.Length > 7)
            {
                MessageBox.Show("Erreur : Input trop grand (max 7 caractères)");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Réinitialisation des champs de texte et du résultat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Reset(object sender, RoutedEventArgs e)
        {
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            resultText.Text = "Résultat : ";
        }
    }
}
