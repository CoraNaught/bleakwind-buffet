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
    /// Interaction logic for SmokehouseSkeleton.xaml
    /// </summary>
    public partial class SmokehouseSkeleton : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        OrderTicket order;
        BleakwindBuffet.Data.Entrees.SmokehouseSkeleton smokehouse = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();
        /// <summary>
        /// Smokehouse Skeleton customization menu
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="menu">Menu selection</param>
        /// <param name="order">oder ticket</param>
        public SmokehouseSkeleton(DisplayControler display, MenuSelectionComponent menu, OrderTicket order)
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
                var task = smokehouse;
                list.Add(task);
            }
            listBox.Items.Add($"{smokehouse.ToString()}\t\t${smokehouse.Price}");
            foreach (var item in smokehouse.SpecialInstructions)
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
                var item = smokehouse;
                list.Remove(item);
            }
        }

        private void ListBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            order.itemsListView.Items.Remove(sender);
            if (order.DataContext is Order list)
            {
                var item = smokehouse;
                list.Remove(item);
            }
            display.containerBorder.Child = this;
        }

        private void SausageLink_Checked(object sender, RoutedEventArgs e)
        {
            smokehouse.SausageLink = true;
        }

        private void Egg_Checked(object sender, RoutedEventArgs e)
        {
            smokehouse.Egg = true;
        }

        private void HashBrown_Checked(object sender, RoutedEventArgs e)
        {
            smokehouse.HashBrowns = true;
        }

        private void Pancake_Checked(object sender, RoutedEventArgs e)
        {
            smokehouse.PanCake = true;
        }

        private void SausageLink_Unchecked(object sender, RoutedEventArgs e)
        {
            smokehouse.SausageLink = false;
        }

        private void Egg_Unchecked(object sender, RoutedEventArgs e)
        {
            smokehouse.Egg = false;
        }

        private void HashBrown_Unchecked(object sender, RoutedEventArgs e)
        {
            smokehouse.HashBrowns = false;
        }

        private void Pancake_Unchecked(object sender, RoutedEventArgs e)
        {
            smokehouse.PanCake = false;
        }
    }
}
