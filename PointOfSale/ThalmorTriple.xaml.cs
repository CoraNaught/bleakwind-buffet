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
    /// Interaction logic for ThalmorTriple.xaml
    /// </summary>
    public partial class ThalmorTriple : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Entrees.ThalmorTriple thalmorTriple = new BleakwindBuffet.Data.Entrees.ThalmorTriple();
        /// <summary>
        /// Thalmor Triple customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public ThalmorTriple(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
        {
            InitializeComponent();
            this.display = display;
            this.menu = menu;
            this.order = order;
        }
        /// <summary>
        /// Handles done button chick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.MouseLeftButtonUp += ListBox_MouseLeftButtonUp;
            listBox.MouseRightButtonUp += ListBox_MouseRightButtonUp;
            display.containerBorder.Child = menu;
            if (order.DataContext is Order list)
            {
                var task = thalmorTriple;
                list.Add(task);
            }
            listBox.Items.Add($"{thalmorTriple.ToString()}\t\t${thalmorTriple.Price}");
            foreach (var item in thalmorTriple.SpecialInstructions)
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
                var item = thalmorTriple;
                list.Remove(item);
            }
        }

        private void ListBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            order.itemsListView.Items.Remove(sender);
            if (order.DataContext is Order list)
            {
                var item = thalmorTriple;
                list.Remove(item);
            }
            display.containerBorder.Child = this;
        }
        /// <summary>
        /// Handles bun check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bun_Checked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Bun = true;
        }
        /// <summary>
        /// Handles mustard check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mustard_Checked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Mustard = true;
        }
        /// <summary>
        /// Handles pickle check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pickle_Checked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Pickle = true;
        }
        /// <summary>
        /// Handles cheese check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cheese_Checked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Cheese = true;
        }
        /// <summary>
        /// Handles tomato check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tomato_Checked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Tomato = true;
        }
        /// <summary>
        /// Handles lettuce check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lettuce_Checked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Lettuce = true;
        }
        /// <summary>
        /// Handles mayo check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mayo_Checked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Mayo = true;
        }
        /// <summary>
        /// Handles bacon check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bacon_Checked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Bacon = true;
        }
        /// <summary>
        /// Handles egg check event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Egg_Checked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Egg = true;
        }
        /// <summary>
        /// Handles bun uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bun_Unchecked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Bun = false;
        }
        /// <summary>
        /// Handles mustard uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mustard_Unchecked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Mustard = false;
        }
        /// <summary>
        /// Handles pickle uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pickle_Unchecked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Pickle = false;
        }
        /// <summary>
        /// Handles cheese uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cheese_Unchecked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Cheese = false;
        }
        /// <summary>
        /// Handles tomato uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Tomato_Unchecked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Tomato = false;
        }
        /// <summary>
        /// Handles lettuce uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Lettuce_Unchecked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Lettuce = false;
        }
        /// <summary>
        /// Handles mayo uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Mayo_Unchecked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Mayo = false;
        }
        /// <summary>
        /// Handles bacon uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Bacon_Unchecked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Bacon = false;
        }
        /// <summary>
        /// Handles egg uncheck event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Egg_Unchecked(object sender, RoutedEventArgs e)
        {
            thalmorTriple.Egg = false;
        }
    }
}
