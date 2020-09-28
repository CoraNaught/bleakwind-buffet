﻿using System;
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
    /// Interaction logic for FriedMiraak.xaml
    /// </summary>
    public partial class FriedMiraak : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Sides.FriedMiraak friedMiraak = new BleakwindBuffet.Data.Sides.FriedMiraak();
        /// <summary>
        /// Fired Miraak customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public FriedMiraak(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            this.display = display;
            this.menu = menu;
            this.order = order;
            Small.IsChecked = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            display.containerBorder.Child = menu;
            order.itemsListView.Items.Add(friedMiraak.ToString());
        }

        private void Small_Checked(object sender, RoutedEventArgs e)
        {
            friedMiraak.Size = BleakwindBuffet.Data.Enums.Size.Small;
            Medium.IsChecked = false;
            Large.IsChecked = false;
        }

        private void Medium_Checked(object sender, RoutedEventArgs e)
        {
            friedMiraak.Size = BleakwindBuffet.Data.Enums.Size.Medium;
            Small.IsChecked = false;
            Large.IsChecked = false;
        }

        private void Large_Checked(object sender, RoutedEventArgs e)
        {
            friedMiraak.Size = BleakwindBuffet.Data.Enums.Size.Large;
            Medium.IsChecked = false;
            Small.IsChecked = false;
        }
    }
}
