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
        Dictionary<string, Plant> plantDict = new Dictionary<string, Plant>();
        Flower flower;
        Tree tree;
        Shrub shrub;
        public MainWindow()
        {
            InitializeComponent();
            LoadPlants();
            

        }
        /// <summary>
        /// loads our list box items and adds a few starter plants to the list box. Sets default selected indexes to the combo box and list box.
        /// </summary>
        private void LoadPlants()
        {
            CmbBoxEnvironment.Items.Add("Forest");
            CmbBoxEnvironment.Items.Add("Desert");
            CmbBoxEnvironment.Items.Add("Jungle");

            Flower defaultFlower = new Flower();
            Flower paramFlower = new Flower("Rose", "Forest");
            Plant plantFlower = new Flower("Sunflower", "Forest");

            PolymorphicAddition(defaultFlower);
            PolymorphicAddition(paramFlower);
            PolymorphicAddition(plantFlower);

            CmbBoxEnvironment.SelectedIndex = 0;
            LstBoxPlants.SelectedIndex = 0;
        }
        /// <summary>
        /// adds a plant to the dictionary and listbox using the plant object as a parameter
        /// </summary>
        /// <param name="plant"></param>
        private void PolymorphicAddition(Plant plant)
        {
            try
            {
                plantDict.Add(plant.Name, plant);
                LstBoxPlants.Items.Add(plant.Name);
            }
            catch
            {
                MessageBox.Show("Plant name taken, use another name.");
                
            }

            
        }
        /// <summary>
        /// adds a plant to the dictionary and  list, checks which radio button is checked and which combo box item is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            string name = TxtBoxPlantName.Text;
            string environment = CmbBoxEnvironment.SelectedItem.ToString();
            if (name != "")
            {

            if (RdBtnFlower.IsChecked == true)
            {
                flower.Name = name;
                flower.Environment = environment;
                PolymorphicAddition(flower);

            }
            else if (RdBtnTree.IsChecked == true)
            {
                tree = new Tree(name, environment, 5);
                PolymorphicAddition(tree);
            }
            else if(RdBtnShrub.IsChecked == true)
            {
                PolymorphicAddition(shrub);
            } else
            {
                MessageBox.Show("Select a plant type please.");
            }
            }
            else
            {
                MessageBox.Show("Please enter a valid plant name.");
            }

        }
        /// <summary>
        /// Shows details of selected plant in a modal window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
        {
            if (plantDict.TryGetValue(LstBoxPlants.SelectedItem.ToString(), out Plant plant))
            {
                DetailsWindow plantDetailsWindow = new DetailsWindow(plant);
                plantDetailsWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("There was an error when displaying the details.");
            }
        }
        /// <summary>
        /// the radio button will change the image source and create a new plant object if possible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdBtnFlower_Checked(object sender, RoutedEventArgs e)
        {
            ImgPlant.Source = new BitmapImage(new Uri("flower.png", UriKind.Relative));
            flower = new Flower();
        }
        /// <summary>
        /// the radio button will change the image source and create a new plant object if possible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdBtnTree_Checked(object sender, RoutedEventArgs e)
        {
            ImgPlant.Source = new BitmapImage(new Uri("tree.png", UriKind.Relative));
            
        }
        /// <summary>
        /// the radio button will change the image source and create a new plant object if possible.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RdBtnShrub_Checked(object sender, RoutedEventArgs e)
        {
            ImgPlant.Source = new BitmapImage(new Uri("shrub.png", UriKind.Relative));
            shrub = new Shrub();
        }
    }
}
