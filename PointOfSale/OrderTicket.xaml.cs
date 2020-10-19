using Data;
using System.Windows.Controls;

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
            itemsListView.DataContext = new Order();
        }
    }
}
