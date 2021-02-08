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
using System.Windows.Shapes;

namespace PlantApp
{
    /// <summary>
    /// Interaction logic for DetailsWindow.xaml
    /// </summary>
    public partial class DetailsWindow : Window
    {
        Plant plant;
        public DetailsWindow(Plant paramPlant)
        {
            InitializeComponent();

            plant = paramPlant;

            LblName.Content = plant.Name;
            LblEnvironment.Content = plant.Environment;
            LblPick.Content = plant.Pick();
            LblType.Content = plant.GetType().Name;
        }
        /// <summary>
        /// closes the modal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Shows the sniff message of the specific plant.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSniff_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(plant.Sniff());
        }
    }
}
