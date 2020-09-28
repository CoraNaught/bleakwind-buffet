using System;
using System.Collections.Generic;
using System.Data.Odbc;
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
    /// Interaction logic for SailorSoda.xaml
    /// </summary>
    public partial class SailorSoda : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Drinks.SailorSoda sailorSoda = new BleakwindBuffet.Data.Drinks.SailorSoda();
        /// <summary>
        /// Sailor Soda customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public SailorSoda(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            this.display = display;
            this.menu = menu;
            this.order = order;
            Small.IsChecked = true;
            Blackberry.IsChecked = true;
        }
        /// <summary>
        /// Handles done button click event event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            display.containerBorder.Child = menu;
            order.itemsListView.Items.Add(sailorSoda.ToString());
        }
        /// <summary>
        /// Handles ice check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ice_Checked(object sender, RoutedEventArgs e)
        {
            sailorSoda.Ice = true;
        }
        /// <summary>
        /// Handles ice uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Ice_Unchecked(object sender, RoutedEventArgs e)
        {
            sailorSoda.Ice = false;
        }
        /// <summary>
        /// Handles small check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Small_Checked(object sender, RoutedEventArgs e)
        {
            sailorSoda.Size = BleakwindBuffet.Data.Enums.Size.Small;
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
            sailorSoda.Size = BleakwindBuffet.Data.Enums.Size.Medium;
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
            sailorSoda.Size = BleakwindBuffet.Data.Enums.Size.Large;
            Medium.IsChecked = false;
            Small.IsChecked = false;
        }
        /// <summary>
        /// Handles blackberry check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Blackberry_Checked(object sender, RoutedEventArgs e)
        {
            sailorSoda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Blackberry;
            Cherry.IsChecked = false;
            Grapefriut.IsChecked = false;
            Lemon.IsChecked = false;
            Peach.IsChecked = false;
            Watermelon.IsChecked = false;
        }
        /// <summary>
        /// Handles cherry check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cherry_Checked(object sender, RoutedEventArgs e)
        {
            sailorSoda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Cherry;
            Blackberry.IsChecked = false;
            Grapefriut.IsChecked = false;
            Lemon.IsChecked = false;
            Peach.IsChecked = false;
            Watermelon.IsChecked = false;
        }
        /// <summary>
        /// Handles grapefruit check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Grapefriut_Checked(object sender, RoutedEventArgs e)
        {
            sailorSoda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Grapefruit;
            Cherry.IsChecked = false;
            Blackberry.IsChecked = false;
            Lemon.IsChecked = false;
            Peach.IsChecked = false;
            Watermelon.IsChecked = false;
        }
        /// <summary>
        /// Handles lemon check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lemon_Checked(object sender, RoutedEventArgs e)
        {
            sailorSoda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Lemon;
            Cherry.IsChecked = false;
            Grapefriut.IsChecked = false;
            Blackberry.IsChecked = false;
            Peach.IsChecked = false;
            Watermelon.IsChecked = false;
        }
        /// <summary>
        /// Handles peach check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Peach_Checked(object sender, RoutedEventArgs e)
        {
            sailorSoda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Peach;
            Cherry.IsChecked = false;
            Grapefriut.IsChecked = false;
            Lemon.IsChecked = false;
            Blackberry.IsChecked = false;
            Watermelon.IsChecked = false;
        }
        /// <summary>
        /// Handles watermelon check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Watermelon_Checked(object sender, RoutedEventArgs e)
        {
            sailorSoda.Flavor = BleakwindBuffet.Data.Enums.SodaFlavor.Watermelon;
            Cherry.IsChecked = false;
            Grapefriut.IsChecked = false;
            Lemon.IsChecked = false;
            Peach.IsChecked = false;
            Blackberry.IsChecked = false;
        }
    }
}
