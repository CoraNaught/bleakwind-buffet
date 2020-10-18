/*
 * Author: Corrie Naughton
 * Class name: DoubleDraugr.cs
 * Purpose: Class that DoubleDraugr user control
 */
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
    /// Interaction logic for DoubleDraugr.xaml
    /// </summary>
    public partial class DoubleDraugr : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Entrees.DoubleDraugr doubleDraugr = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
        /// <summary>
        /// Double Draugr customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public DoubleDraugr(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            this.display = display;
            this.menu = menu;
            this.order = order;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.MouseLeftButtonUp += ListBox_MouseLeftButtonUp;
            listBox.MouseRightButtonUp += ListBox_MouseRightButtonUp;
            display.containerBorder.Child = menu;
            if (order.DataContext is Order list)
            {
                var task = doubleDraugr;
                list.Add(task);
            }
            listBox.Items.Add($"{doubleDraugr.ToString()}\t\t${doubleDraugr.Price}");
            foreach (var item in doubleDraugr.SpecialInstructions)
            {
                listBox.Items.Add($"-{item}");
            }
            order.itemsListView.Items.Add(listBox);
        }
        private void ListBox_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            order.itemsListView.Items.Remove(sender);
            if (order.DataContext is Order list)
            {
                var item = doubleDraugr;
                list.Remove(item);
            }
        }

        private void ListBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            order.itemsListView.Items.Remove(sender);
            if (order.DataContext is Order list)
            {
                var item = doubleDraugr;
                list.Remove(item);
            }
            display.containerBorder.Child = this;
        }

        private void Bun_Checked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Bun = true;
        }

        private void Bun_Unchecked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Bun = false;
        }

        private void Mustard_Checked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Mustard = true;
        }

        private void Mustard_Unchecked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Mustard = false;
        }

        private void Pickle_Checked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Pickle = true;
        }

        private void Pickle_Unchecked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Pickle = false;
        }

        private void Cheese_Checked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Cheese = true;
        }

        private void Cheese_Unchecked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Cheese = false;
        }

        private void Tomato_Checked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Tomato = true;
        }

        private void Tomato_Unchecked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Tomato = false;
        }

        private void Lettuce_Checked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Lettuce = true;
        }

        private void Lettuce_Unchecked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Lettuce = false;
        }

        private void Mayo_Checked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Mayo = true;
        }

        private void Mayo_Unchecked(object sender, RoutedEventArgs e)
        {
            doubleDraugr.Mayo = false;
        }
    }
}
