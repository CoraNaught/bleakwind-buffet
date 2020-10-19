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
using Data;
using RoundRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for PaymentOptions.xaml
    /// </summary>
    public partial class PaymentOptions : UserControl
    {
        DisplayControler display;
        MainWindow main;
        OrderTicket o;
        public PaymentOptions(MainWindow main, DisplayControler display, OrderTicket order)
        {
            InitializeComponent();
            this.display = display;
            this.main = main;
            o = order;
        }

        private void ReturnToOrder_Click(object sender, RoutedEventArgs e)
        {
            main.containerBorder.Child = display;
            main.order.IsEnabled = true;
            main.cancelButton.IsEnabled = true;
            main.completeButton.IsEnabled = true;
        }

        private void Credit_Debit_Click(object sender, RoutedEventArgs e)
        {
            Order orderItems = (Order)o.DataContext;
            CardTransactionResult result = CardReader.RunCard(orderItems.Total);
            if(result == CardTransactionResult.Approved)
            {
                Print_Reciept();
                o.DataContext = new Order();
                o.itemsListView.Items.Clear();
                main.containerBorder.Child = display;
                main.order.IsEnabled = true;
                main.cancelButton.IsEnabled = true;
                main.completeButton.IsEnabled = true;
            }
        }
        public void EditAmount()
        {

        }
        private void Print_Reciept()
        {
            Order order = (Order)o.DataContext;
            RoundRegister.RecieptPrinter.PrintLine("Order Number# " + order.Number.ToString());
            RoundRegister.RecieptPrinter.PrintLine(DateTime.Now.ToString());
            foreach (var items in o.itemsListView.Items)
            {
                RoundRegister.RecieptPrinter.PrintLine(items.ToString());
            }
            RoundRegister.RecieptPrinter.PrintLine(order.Subtotal.ToString());
            RoundRegister.RecieptPrinter.PrintLine(order.Tax.ToString());
            RoundRegister.RecieptPrinter.PrintLine(order.Total.ToString());
            RoundRegister.RecieptPrinter.PrintLine("Credis/Debit");
            RoundRegister.RecieptPrinter.PrintLine("Amount Owed: $0");
            RoundRegister.RecieptPrinter.CutTape();
        }
        private void Cash_Click(object sender, RoutedEventArgs e)
        {
            main.containerBorder.Child = new CashPayment(main,display,o);
        }
    }
}
