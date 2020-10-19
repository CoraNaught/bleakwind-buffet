using Data;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OrderTicket o;
        PaymentOptions p;
        /// <summary>
        /// Main Window application
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            o = new OrderTicket();
            order.Child = o;
            o.DataContext = new Order();
            DisplayControler d = new DisplayControler(o);
            containerBorder.Child = d;
            p = new PaymentOptions(this, d, o);

        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            o.DataContext = new Order();
            o.itemsListView.Items.Clear();
        }

        private void completeButton_Click(object sender, RoutedEventArgs e)
        {
            containerBorder.Child = p;
            cancelButton.IsEnabled = false;
            completeButton.IsEnabled = false;
            order.IsEnabled = false;
        }
    }
}
