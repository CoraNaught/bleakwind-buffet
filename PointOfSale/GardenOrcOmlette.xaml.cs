﻿using Data;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.MouseLeftButtonUp += ListBox_MouseLeftButtonUp;
            listBox.MouseRightButtonUp += ListBox_MouseRightButtonUp;
            display.containerBorder.Child = menu;
            if (order.DataContext is Order list)
            {
                var task = gardenOrcOmlette;
                list.Add(task);
            }
            listBox.Items.Add($"{gardenOrcOmlette.ToString()}\t\t${gardenOrcOmlette.Price}");
            foreach (var item in gardenOrcOmlette.SpecialInstructions)
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
                var item = gardenOrcOmlette;
                list.Remove(item);
            }
        }

        private void ListBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            order.itemsListView.Items.Remove(sender);
            if (order.DataContext is Order list)
            {
                var item = gardenOrcOmlette;
                list.Remove(item);
            }
            display.containerBorder.Child = this;
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
