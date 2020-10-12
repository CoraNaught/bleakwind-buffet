/*
 * Author: Corrie Naughton
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class that CandlehearthCoffee user control
 */
using BleakwindBuffet.Data;
using Data;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    /// Interaction logic for CandlehearthCoffee.xaml
    /// </summary>
    public partial class CandlehearthCoffee : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Drinks.CandlehearthCoffee coffee = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
        /// <summary>
        /// Candlehearth coffee customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public CandlehearthCoffee(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            this.display = display;
            this.menu = menu;
            this.order = order;
            Small.IsChecked = true;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            display.containerBorder.Child = menu;
            if (order.DataContext is Order list)
            {
                var task = coffee;
                list.Add(task);
            }
            order.itemsListView.Items.Add($"{coffee.ToString()}\t\t${coffee.Price}");
            foreach (var item in coffee.SpecialInstructions)
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
                var task = coffee;
                list.Remove(task);
            }
            order.itemsListView.Items.Remove($"{coffee.ToString()}\t\t${coffee.Price}");
            foreach (var item in coffee.SpecialInstructions)
            {
                order.itemsListView.Items.Remove($"-{item}");
            }
            order.itemsListView.Items.Remove(button);
        }

        private void Ice_Checked(object sender, RoutedEventArgs e)
        {
            coffee.Ice = true;
        }

        private void Ice_Unchecked(object sender, RoutedEventArgs e)
        {
            coffee.Ice = false;
        }

        private void RoomForCream_Checked(object sender, RoutedEventArgs e)
        {
            coffee.RoomForCream = true;
        }

        private void RoomForCream_Unchecked(object sender, RoutedEventArgs e)
        {
            coffee.RoomForCream = false;
        }

        private void Decaf_Checked(object sender, RoutedEventArgs e)
        {
            coffee.Decaf = true;
        }

        private void Decaf_Unchecked(object sender, RoutedEventArgs e)
        {
            coffee.Decaf = false;
        }

        private void Small_Checked(object sender, RoutedEventArgs e)
        {
            coffee.Size = BleakwindBuffet.Data.Enums.Size.Small;
            Medium.IsChecked = false;
            Large.IsChecked = false;
        }

        private void Medium_Checked(object sender, RoutedEventArgs e)
        {
            coffee.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            Small.IsChecked = false;
            Large.IsChecked = false;
        }

        private void Large_Checked(object sender, RoutedEventArgs e)
        {
            coffee.Size = BleakwindBuffet.Data.Enums.Size.Large;
            Small.IsChecked = false;
            Medium.IsChecked = false;
        }
    }
}
