/*
 * Author: Corrie Naughton
 * Class name: ArentinoAppleJuice.cs
 * Purpose: Class that ArentinoAppleJuice user control
 */
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
            order.itemsListView.Items.Add(appleJuice.ToString());
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
