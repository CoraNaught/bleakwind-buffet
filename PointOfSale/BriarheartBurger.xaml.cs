/*
 * Author: Corrie Naughton
 * Class name: BriarheartBurger.cs
 * Purpose: Class that BriarheartBurger user control
 */
using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for BriarheartBurger.xaml
    /// </summary>
    public partial class BriarheartBurger : UserControl
    {
        DisplayControler parent;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Entrees.BriarheartBurger briarheartBurger = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
        /// <summary>
        /// Brairheart burger customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public BriarheartBurger(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            this.parent = display;
            this.menu = menu;
            this.order = order;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            parent.containerBorder.Child = menu;
            if (order.DataContext is Order list)
            {
                var task = briarheartBurger;
                list.Add(task);
            }
            order.itemsListView.Items.Add($"{briarheartBurger.ToString()}\t\t${briarheartBurger.Price}");
            foreach (var item in briarheartBurger.SpecialInstructions)
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
                var task = briarheartBurger;
                list.Remove(task);
            }
            order.itemsListView.Items.Remove($"{briarheartBurger.ToString()}\t\t${briarheartBurger.Price}");
            foreach (var item in briarheartBurger.SpecialInstructions)
            {
                order.itemsListView.Items.Remove($"-{item}");
            }
            order.itemsListView.Items.Remove(button);
        }

        private void Bun_Checked(object sender, RoutedEventArgs e)
        {
            briarheartBurger.Bun = true;
        }

        private void Mustard_Checked(object sender, RoutedEventArgs e)
        {
            briarheartBurger.Mustard = true;
        }

        private void Pickle_Checked(object sender, RoutedEventArgs e)
        {
            briarheartBurger.Pickle = true;
        }

        private void Cheeese_Checked(object sender, RoutedEventArgs e)
        {
            briarheartBurger.Cheese = true;
        }

        private void Bun_Unchecked(object sender, RoutedEventArgs e)
        {
            briarheartBurger.Bun = false;
        }

        private void Mustard_Unchecked(object sender, RoutedEventArgs e)
        {
            briarheartBurger.Mustard = false;
        }

        private void Pickle_Unchecked(object sender, RoutedEventArgs e)
        {
            briarheartBurger.Pickle = false;
        }

        private void Cheeese_Unchecked(object sender, RoutedEventArgs e)
        {
            briarheartBurger.Cheese = false;
        }
    }
}
