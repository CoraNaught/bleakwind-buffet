using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
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
    /// Interaction logic for OrderTicket.xaml
    /// </summary>
    public partial class OrderTicket : UserControl
    {
        DisplayControler display;
        MenuSelectionComponent menu;
        /// <summary>
        /// Order Ticket menu
        /// </summary>
        public OrderTicket()
        {
            InitializeComponent();
            itemsListView.DataContext = new Order();
            this.display = display;
            this.menu = menu;
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.Items.Remove(itemsListView.SelectedItem);
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var screen = itemsListView.SelectedItem.ToString();
            List<UIElement> list = new List<UIElement> { new ArentinoAppleJuice(display,menu,this), new SailorSoda(display,menu,this), new BriarheartBurger(display,menu,this) };
            foreach(var item in list)
            {
                if(screen == item.ToString())
                {
                    display.containerBorder.Child = item;
                }
            }
            itemsListView.Items.RemoveAt(itemsListView.SelectedIndex);
           
        }
    }
}
