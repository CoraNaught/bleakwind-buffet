/*
 * Author: Corrie Naughton
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class that ArentinoAppleJuice user control
 */
using BleakwindBuffet.Data;
using Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for ArentinoAppleJuice.xaml
    /// </summary>
    public partial class ArentinoAppleJuice : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Drinks.AretinoAppleJuice appleJuice = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();

        /// <summary>
        /// Arentino Apple Juice customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public ArentinoAppleJuice(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            Small.IsChecked = true;
            this.display = display;
            this.menu = menu;
            this.order = order;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            display.containerBorder.Child = menu;
            if (order.DataContext is Order list)
            {
                var task = appleJuice;
                list.Add(task);
            }
            order.itemsListView.Items.Add($"{appleJuice.ToString()}\t\t${appleJuice.Price}");
            foreach (var item in appleJuice.SpecialInstructions)
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
                var task = appleJuice;
                list.Remove(task);
            }
            order.itemsListView.Items.Remove($"{appleJuice.ToString()}\t\t${appleJuice.Price}");
            foreach (var item in appleJuice.SpecialInstructions)
            {
                order.itemsListView.Items.Remove($"-{item}");
            }
            order.itemsListView.Items.Remove(button);
        }

        private void Small_Checked(object sender, RoutedEventArgs e)
        {
            appleJuice.Size = BleakwindBuffet.Data.Enums.Size.Small;
            Medium.IsChecked = false;
            Large.IsChecked = false;
        }

        private void Medium_Checked(object sender, RoutedEventArgs e)
        {
            appleJuice.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            Small.IsChecked = false;
            Large.IsChecked = false;
        }


        private void Large_Checked(object sender, RoutedEventArgs e)
        {
            appleJuice.Size = BleakwindBuffet.Data.Enums.Size.Large;
            Small.IsChecked = false;
            Medium.IsChecked = false;
        }

        private void Ice_Checked(object sender, RoutedEventArgs e)
        {
            appleJuice.Ice = true;
        }

        private void Ice_Unchecked(object sender, RoutedEventArgs e)
        {
            appleJuice.Ice = false;
        }

    
    }
}
