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
            CalendarDateRange blackoutDays = new CalendarDateRange(new DateTime(0001,01,01), DateTime.Now.AddDays(-1));
            date_arrivee.BlackoutDates.Add(blackoutDays);
            date_arrivee.SelectedDate = DateTime.Now;
            date_arrivee.CalendarClosed += new RoutedEventHandler(SelectDateChangeEvent);
            date_sortie.BlackoutDates.Add(blackoutDays);
        }


        public void SelectDateChangeEvent(object sender, RoutedEventArgs e)
        {
            CalendarDateRange blackoutDays = new CalendarDateRange(new DateTime(0001, 01, 01), date_arrivee.SelectedDate.Value.Date);
            date_sortie.BlackoutDates.Clear();
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
            }
        }

        
    }
}
