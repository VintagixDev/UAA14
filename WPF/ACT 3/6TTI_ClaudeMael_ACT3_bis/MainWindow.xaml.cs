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

namespace _6TTI_ClaudeMael_ACT3_bis
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtbox_personnes.PreviewTextInput += new TextCompositionEventHandler(VerifIntInput);




            date_arrivee.DisplayDateStart = DateTime.Now.AddDays(-14);
            date_arrivee.DisplayDateEnd = DateTime.Now.AddYears(1);
            date_sortie.DisplayDateStart = DateTime.Now.AddDays(-14);
            date_sortie.DisplayDateEnd = DateTime.Now.AddYears(1);

            BlackoutDays();
            
            date_arrivee.CalendarClosed += new RoutedEventHandler(SelectDateChangeEvent);
            btn_duree.Click += new RoutedEventHandler(btn_duree_Click);

            btn_calculer.Click += new RoutedEventHandler(btn_calculer_Click);
            btn_calculer.Visibility = Visibility.Hidden;

        }

        /// <summary>
        /// Vérification des champs + Traitement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_calculer_Click(object sender, RoutedEventArgs e)
        {
            if (!date_arrivee.SelectedDate.HasValue ||
                !date_sortie.SelectedDate.HasValue ||
                txtbox_personnes.Text == "")
            {
                txt_verif.Text = "Veuillez remplir tous les champs.";
                return;
            }
            txt_verif.Text = "";
          

        }
        
        /// <summary>
        /// Afficher le nombre de semaines sélectionnés
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void btn_duree_Click(object sender, RoutedEventArgs e)
        {
            if(date_sortie.SelectedDate != null)
            {
                TimeSpan semaines = date_sortie.SelectedDate.Value - date_arrivee.SelectedDate.Value;
                semaine.Text = (semaines.Days/7).ToString();
                if(txtbox_personnes.Text != "")
                {
                    btn_calculer.Visibility = Visibility.Visible;
                }
            }

        }

        /// <summary>
        /// 
        /// </summary>
        public void BlackoutDays()
        {

            CalendarDateRange[] blackoutDays = new CalendarDateRange[7];

            blackoutDays[0] = new CalendarDateRange(new DateTime(0001, 01, 01), DateTime.Now.AddDays(-1));
            blackoutDays[1] = new CalendarDateRange(new DateTime(DateTime.Now.Year + 1, 02, 01), new DateTime(DateTime.Now.Year + 1, 03, 31));
            blackoutDays[2] = new CalendarDateRange(new DateTime(DateTime.Now.Year, 02, 01), new DateTime(DateTime.Now.Year, 03, 31));
            blackoutDays[3] = new CalendarDateRange(new DateTime(DateTime.Now.Year + 1, 05, 01), new DateTime(DateTime.Now.Year + 1, 06, 30));
            blackoutDays[4] = new CalendarDateRange(new DateTime(DateTime.Now.Year, 05, 01), new DateTime(DateTime.Now.Year, 06, 30));
            blackoutDays[5] = new CalendarDateRange(new DateTime(DateTime.Now.Year + 1, 09, 01), new DateTime(DateTime.Now.Year + 1, 12, 30));
            blackoutDays[6] = new CalendarDateRange(new DateTime(DateTime.Now.Year, 09, 01), new DateTime(DateTime.Now.Year, 12, 30));


            for (int i = 0; i < blackoutDays.Length; i++)
            {
                date_arrivee.BlackoutDates.Add(blackoutDays[i]);
                date_sortie.BlackoutDates.Add(blackoutDays[i]);

            }
        }

        /// <summary>
        /// Faire en sorte qu'on ne puisse pas choisir de date avant le jour d'arrivée pour le jour de sortie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void SelectDateChangeEvent(object sender, RoutedEventArgs e)
        {
            CalendarDateRange blackoutDays = new CalendarDateRange(new DateTime(0001, 01, 01), date_arrivee.SelectedDate.Value.Date);
            date_sortie.BlackoutDates.Clear();
            BlackoutDays();
            date_sortie.BlackoutDates.Add(blackoutDays);
        }

        /// <summary>
        /// Vérifier si l'input est entre 1 et 6
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void VerifIntInput(object sender, TextCompositionEventArgs e) { 
            if(!int.TryParse(e.Text, out int value))
            {
                e.Handled = true;
            }
            if (txtbox_personnes.Text.Length > 0)
            {
                e.Handled = true;
            }
            if(!(value >= 1 && value <= 6))
            {
                e.Handled = true;
                if(date_sortie.SelectedDate != null)
                {
                    btn_calculer.Visibility = Visibility.Visible;
                }
            }
        }

        
    }
}
