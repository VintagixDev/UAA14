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

namespace _6TTI_ClaudeMael_ACT4_Interfaces
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            InitializeObjects();
            
            


        }

        public void InitializeObjects()
        {
            for (int i = 0; i < 3; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                RowDefinition row = new RowDefinition();
                gridMain.ColumnDefinitions.Add(col);
                gridMain.RowDefinitions.Add(row);
            }


            TextBlock txtBlock = new TextBlock();
            txtBlock.Text = "TextBlock créé dynamiquement";
            txtBlock.Background = Brushes.Yellow;
            txtBlock.Foreground = Brushes.Red;
            txtBlock.FontWeight = FontWeights.Bold;
            txtBlock.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock.VerticalAlignment = VerticalAlignment.Center;
            txtBlock.Height = 50;

            Grid.SetColumnSpan(txtBlock, 3);

            gridMain.Children.Add(txtBlock);



            for (int i = 0; i < 3; i++)
            {
                Button btn = new Button();
                btn.Content = "BOUTON " + (i + 1);
                btn.Width = 125;
                btn.Height = 125;

                Grid.SetColumn(btn, i);
                Grid.SetRow(btn, 1);
                gridMain.Children.Add(btn);

            }





            StackPanel stkPanel = new StackPanel();

            TextBlock txtBlock2 = new TextBlock();
            txtBlock2.Text = "Infos :";
            txtBlock2.Background = Brushes.Yellow;
            txtBlock2.FontWeight = FontWeights.Bold;
            txtBlock2.HorizontalAlignment = HorizontalAlignment.Stretch;
            txtBlock2.Height = 50;
            TextBox txtBox = new TextBox();
            txtBox.Text = "J'attends vos infos";

            stkPanel.Children.Add(txtBlock2);
            stkPanel.Children.Add(txtBox);
            stkPanel.VerticalAlignment = VerticalAlignment.Center;
            gridMain.Children.Add(stkPanel);
            Grid.SetRow(stkPanel, 2);
            Grid.SetColumnSpan(stkPanel, 2);

            ComboBox comboBox = new ComboBox();
            comboBox.Items.Add("Jean");
            comboBox.Items.Add("Andras");
            comboBox.Width = 100;
            comboBox.Height = 75;
            comboBox.VerticalAlignment = VerticalAlignment.Center;
            comboBox.HorizontalAlignment = HorizontalAlignment.Center;
            Grid.SetRow(comboBox, 2);
            Grid.SetColumn(comboBox, 2);
            gridMain.Children.Add(comboBox);
        }
    }
}
