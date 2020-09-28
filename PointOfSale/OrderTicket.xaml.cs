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
    /// Interaction logic for OrderTicket.xaml
    /// </summary>
    public partial class OrderTicket : UserControl
    {
        /// <summary>
        /// Order Ticket menu
        /// </summary>
        public OrderTicket()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Handles canel button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            itemsListView.Items.Clear();
        }
    }
}
