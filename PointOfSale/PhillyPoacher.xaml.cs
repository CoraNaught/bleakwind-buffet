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
    /// Interaction logic for PhillyPoacher.xaml
    /// </summary>
    public partial class PhillyPoacher : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Entrees.PhillyPoacher phillyPoacher = new BleakwindBuffet.Data.Entrees.PhillyPoacher();
        /// <summary>
        /// Philly Poacher customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public PhillyPoacher(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
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
            order.itemsListView.Items.Add(phillyPoacher.ToString());
        }
        /// <summary>
        /// Handles sirloin check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sirloin_Checked(object sender, RoutedEventArgs e)
        {
            phillyPoacher.Sirloin = true;
        }
        /// <summary>
        /// Handles sirloin uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sirloin_Unchecked(object sender, RoutedEventArgs e)
        {
            phillyPoacher.Sirloin = false;
        }
        /// <summary>
        /// Handles Onion check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Onion_Checked(object sender, RoutedEventArgs e)
        {
            phillyPoacher.Onion = true;
        }
        /// <summary>
        /// Handles onion uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Onion_Unchecked(object sender, RoutedEventArgs e)
        {
            phillyPoacher.Onion = false;
        }
        /// <summary>
        /// Handles roll check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Roll_Checked(object sender, RoutedEventArgs e)
        {
            phillyPoacher.Roll = true;
        }
        /// <summary>
        /// Handles roll uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Roll_Unchecked(object sender, RoutedEventArgs e)
        {
            phillyPoacher.Roll = false;
        }
    }
}
