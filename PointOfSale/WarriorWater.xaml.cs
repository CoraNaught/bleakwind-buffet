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
    /// Interaction logic for WarriorWater.xaml
    /// </summary>
    public partial class WarriorWater : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Drinks.WarriorWater warriorWater = new BleakwindBuffet.Data.Drinks.WarriorWater();
        /// <summary>
        /// Warrior water customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public WarriorWater(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            this.display = display;
            this.menu = menu;
            this.order = order;
        }
        /// <summary>
        /// Handles done button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            display.containerBorder.Child = menu;
            if (order.DataContext is Order list)
            {
                var task = warriorWater;
                list.Add(task);
            }
            order.itemsListView.Items.Add($"{warriorWater.ToString()}\t\t${warriorWater.Price}");
            foreach (var item in warriorWater.SpecialInstructions)
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
                var task = warriorWater;
                list.Remove(task);
            }
            order.itemsListView.Items.Remove($"{warriorWater.ToString()}\t\t${warriorWater.Price}");
            foreach (var item in warriorWater.SpecialInstructions)
            {
                order.itemsListView.Items.Remove($"-{item}");
            }
            order.itemsListView.Items.Remove(button);
        }
            /// <summary>
            /// Handles ice check event
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
        private void Ice_Checked(object sender, RoutedEventArgs e)
        {
            warriorWater.Ice = true;
        }
        /// <summary>
        /// Handles ice uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ice_Unchecked(object sender, RoutedEventArgs e)
        {
            warriorWater.Ice = false;
        }
        /// <summary>
        /// Handles lemon check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lemon_Checked(object sender, RoutedEventArgs e)
        {
            warriorWater.Lemon = true;
        }
        /// <summary>
        /// Handles lemon uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lemon_Unchecked(object sender, RoutedEventArgs e)
        {
            warriorWater.Lemon = false;
        }
        /// <summary>
        /// Handles small check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Small_Checked(object sender, RoutedEventArgs e)
        {
            warriorWater.Size = BleakwindBuffet.Data.Enums.Size.Small;
            Medium.IsChecked = false;
            Large.IsChecked = false;
        }
        /// <summary>
        /// Handles medium check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Medium_Checked(object sender, RoutedEventArgs e)
        {
            warriorWater.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            Small.IsChecked = false;
            Large.IsChecked = false;
        }
        /// <summary>
        /// Handles large check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Large_Checked(object sender, RoutedEventArgs e)
        {
            warriorWater.Size = BleakwindBuffet.Data.Enums.Size.Large;
            Medium.IsChecked = false;
            Small.IsChecked = false;
        }
    }
}
