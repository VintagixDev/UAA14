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

        Methodes methods = new Methodes();
        PageResultat result = new PageResultat();

        public MainWindow()
        {
            InitializeComponent();
            BtnV.Visibility = Visibility.Hidden;
            BtnCalculer.MouseEnter += new MouseEventHandler(SurvolBoutonE);
            BtnCalculer.MouseLeave += new MouseEventHandler(SurvolBoutonL);

            BtnCalculer.Click += new RoutedEventHandler(BtnCalculer_Click);




            txtA.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            txtB.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
            txtC.PreviewTextInput += new TextCompositionEventHandler(VerifTextInput);
        }


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
            result.resultText.Text = type;
            result.Show();

        }
        private void VerifTextInput(object sender, TextCompositionEventArgs e)
        {
            if(e.Text != "," && !EstEntier(e.Text)){
                e.Handled = true;
            }
            if (((TextBox)sender).Text.IndexOf(e.Text) > -1){
                e.Handled = true;
            }
        }

        private void SurvolBoutonE(object sender, MouseEventArgs e)
        {

            BtnV.Visibility = Visibility.Visible;
            BtnV.Background = Brushes.Red;
        }
        private void SurvolBoutonL(object sender, MouseEventArgs e)
        {

            BtnV.Visibility = Visibility.Hidden;
        }


        public bool EstEntier(string texteUser)
        {

            return int.TryParse(texteUser, out int result);
            
        }
    }
}
