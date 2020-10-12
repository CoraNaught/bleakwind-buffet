using Data;
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
    /// Interaction logic for VokunSalad.xaml
    /// </summary>
    public partial class VokunSalad : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Sides.VokunSalad vokunSalad = new BleakwindBuffet.Data.Sides.VokunSalad();
        /// <summary>
        /// Vokun Salad customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public VokunSalad(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            this.display = display;
            this.menu = menu;
            this.order = order;
            Small.IsChecked = true;
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
                var task = vokunSalad;
                list.Add(task);
            }
            order.itemsListView.Items.Add($"{vokunSalad.ToString()}\t\t${vokunSalad.Price}");
            foreach (var item in vokunSalad.SpecialInstructions)
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
                var task = vokunSalad;
                list.Remove(task);
            }
            order.itemsListView.Items.Remove($"{vokunSalad.ToString()}\t\t${vokunSalad.Price}");
            foreach (var item in vokunSalad.SpecialInstructions)
            {
                order.itemsListView.Items.Remove($"-{item}");
            }
            order.itemsListView.Items.Remove(button);
        }
        /// <summary>
        /// Handles small check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Small_Checked(object sender, RoutedEventArgs e)
        {
            vokunSalad.Size = BleakwindBuffet.Data.Enums.Size.Small;
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
            vokunSalad.Size = BleakwindBuffet.Data.Enums.Size.Medium;
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
            vokunSalad.Size = BleakwindBuffet.Data.Enums.Size.Large;
            Medium.IsChecked = false;
            Small.IsChecked = false;
        }
    }
}
