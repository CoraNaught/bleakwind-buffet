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
    /// Interaction logic for CashPayment.xaml
    /// </summary>
    public partial class CashPayment : UserControl
    {
        public static DependencyProperty TotalProperty = DependencyProperty.Register("Total", typeof(double), typeof(CashPayment));
        public double Total
        {
            get { return (double)GetValue(TotalProperty); }
            set { SetValue(TotalProperty, value); }
        }
        public static DependencyProperty AmountdueProperty = DependencyProperty.Register("Amountdue", typeof(double), typeof(CashPayment));
        public double Amountdue
        {
            get { return (double)GetValue(AmountdueProperty); }
            set { SetValue(AmountdueProperty, value); }
        }
        public static DependencyProperty ChangeOwedProperty = DependencyProperty.Register("ChangeOwed", typeof(double), typeof(CashPayment));
        public double ChangeOwed
        {
            get { return (double)GetValue(ChangeOwedProperty); }
            set { SetValue(ChangeOwedProperty, value); }
        }
        MainWindow m;
        DisplayControler d;
        OrderTicket o;
        BleakwindBuffet.Data.CashDrawerView cashDrawer;
        Order order;
        public CashPayment(MainWindow main, DisplayControler display, OrderTicket orderTicket)
        {
            InitializeComponent();
            o = orderTicket;
            d = display;
            m = main;
            hundreds.Label = "$100";
            fifties.Label = "$50";
            twenties.Label = "$20";
            tens.Label = "$10";
            fives.Label = "$5";
            twos.Label = "$2";
            ones.Label = "$1";
            halfDollars.Label = "$0.5";
            quarters.Label = "$0.25";
            dimes.Label = "$0.1";
            nickles.Label = "$0.05";
            pennies.Label = "$0.01";
            order = (Order)o.DataContext;
            Total = order.Total;
            cashDrawer = new BleakwindBuffet.Data.CashDrawerView();
            this.DataContext = cashDrawer;
            Amountdue = cashDrawer.UpdateAmount(Total);
            ChangeOwed = cashDrawer.UpdateChange(Total);
        }
        private void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {
            m.containerBorder.Child = d;
            m.order.IsEnabled = true;
            m.cancelButton.IsEnabled = true;
            m.completeButton.IsEnabled = true;
        }

        private void FinalizeSale_Click(object sender, RoutedEventArgs e)
        {
            cashDrawer.FinalizeSale();
            Print_Reciept();
            o.DataContext = new Order();
            o.itemsListView.Items.Clear();
            m.containerBorder.Child = d;
        }
        private void Print_Reciept()
        {
            RoundRegister.RecieptPrinter.PrintLine("Order Number# "+order.Number.ToString());
            RoundRegister.RecieptPrinter.PrintLine(DateTime.Now.ToString());
            foreach(var items in o.itemsListView.Items)
            {
                RoundRegister.RecieptPrinter.PrintLine(items.ToString());
            }
            RoundRegister.RecieptPrinter.PrintLine(order.Subtotal.ToString());
            RoundRegister.RecieptPrinter.PrintLine(order.Tax.ToString());
            RoundRegister.RecieptPrinter.PrintLine(order.Total.ToString());
            RoundRegister.RecieptPrinter.PrintLine("Cash");
            RoundRegister.RecieptPrinter.PrintLine(ChangeOwed.ToString());
            RoundRegister.RecieptPrinter.CutTape();
        }
    }
}
