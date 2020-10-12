using Data;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for GardenOrcOmlette.xaml
    /// </summary>
    public partial class GardenOrcOmlette : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Entrees.GardenOrcOmlette gardenOrcOmlette = new BleakwindBuffet.Data.Entrees.GardenOrcOmlette();
        /// <summary>
        /// Garnden Orc Omlette customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public GardenOrcOmlette(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            this.display = display;
            this.menu = menu;
            this.order = order;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            display.containerBorder.Child = menu;
            if (order.DataContext is Order list)
            {
                var task = gardenOrcOmlette;
                list.Add(task);
            }
            order.itemsListView.Items.Add($"{gardenOrcOmlette.ToString()}\t\t${gardenOrcOmlette.Price}");
            foreach (var item in gardenOrcOmlette.SpecialInstructions)
            {
                order.itemsListView.Items.Add($"-{item}");
            }
            Button button = new Button();
            button.Content = "Remove";
            button.Click += Remove_Click;
            order.itemsListView.Items.Add(button);
        }
        /// <summary>
        /// Handles remove item click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if (order.DataContext is Order list)
            {
                var task = gardenOrcOmlette;
                list.Remove(task);
            }
            order.itemsListView.Items.Remove($"{gardenOrcOmlette.ToString()}\t\t${gardenOrcOmlette.Price}");
            foreach (var item in gardenOrcOmlette.SpecialInstructions)
            {
                order.itemsListView.Items.Remove($"-{item}");
            }
            order.itemsListView.Items.Remove(button);
        }

        private void Broccoli_Checked(object sender, RoutedEventArgs e)
        {
            gardenOrcOmlette.Broccoli = true;
        }

        private void Broccoli_Unchecked(object sender, RoutedEventArgs e)
        {
            gardenOrcOmlette.Broccoli = false;
        }

        private void Mushrooms_Checked(object sender, RoutedEventArgs e)
        {
            gardenOrcOmlette.Mushrooms = true;
        }

        private void Mushrooms_Unchecked(object sender, RoutedEventArgs e)
        {
            gardenOrcOmlette.Mushrooms = false;
        }

        private void Tomato_Checked(object sender, RoutedEventArgs e)
        {
            gardenOrcOmlette.Tomato = true;
        }

        private void Tomato_Unchecked(object sender, RoutedEventArgs e)
        {
            gardenOrcOmlette.Tomato = false;
        }

        private void Cheddar_Checked(object sender, RoutedEventArgs e)
        {
            gardenOrcOmlette.Cheddar = true;
        }

        private void Cheddar_Unchecked(object sender, RoutedEventArgs e)
        {
            gardenOrcOmlette.Cheddar = false;
        }
    }
}
