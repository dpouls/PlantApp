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

namespace PlantApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /* 
         Grab user's input
        add the users input to a plant object
        add the plant object to a dictionary and the listbox
        pass the plant object into the details window.
         */
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            string name = TxtBoxPlantName.Text;
            string environment = CmbBoxEnvironment.SelectedItem.ToString();

        }

        private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RdBtnFlower_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RdBtnTree_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RdBtnShrub_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
