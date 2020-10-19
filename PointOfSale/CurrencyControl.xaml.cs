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
    /// Interaction logic for CurrencyControl.xaml
    /// </summary>
    public partial class CurrencyControl : UserControl
    {
        public CurrencyControl()
        {
            InitializeComponent();
        }
        public static DependencyProperty CustomerQuanityProperty = DependencyProperty.Register("CustomerQuanity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsMeasure, HandleCustomerChange));
     
        public int CustomerQuanity
        {
            get { return (int)GetValue(CustomerQuanityProperty); }
            set { SetValue(CustomerQuanityProperty, value); }
        }
        public static void HandleCustomerChange(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is CurrencyControl control)
            {
                BleakwindBuffet.Data.CashDrawerView cashDrawer = (BleakwindBuffet.Data.CashDrawerView)control.DataContext;
                switch (control.Label)
                {  
                    case "$100":
                        cashDrawer.CustomerHundreds = control.CustomerQuanity;
                        break;
                    case "$50":
                        cashDrawer.CustomerFifties = control.CustomerQuanity;
                        break;
                    case "$20":
                        cashDrawer.CustomerTwenties = control.CustomerQuanity;
                        break;
                    case "$10":
                        cashDrawer.CustomerTens = control.CustomerQuanity;
                        break;
                    case "$5":
                        cashDrawer.CustomerFives = control.CustomerQuanity;
                        break;
                    case "$2":
                        cashDrawer.CustomerTwos = control.CustomerQuanity;
                        break;
                    case "$1":
                        cashDrawer.CustomerOnes = control.CustomerQuanity;
                        break;
                    case "$0.5":
                        cashDrawer.CustomerHalfDollars = control.CustomerQuanity;
                        break;
                    case "$0.25":
                        cashDrawer.CustomerQuarters = control.CustomerQuanity;
                        break;
                    case "$0.1":
                        cashDrawer.CustomerDimes = control.CustomerQuanity;
                        break;
                    case "$0.05":
                        cashDrawer.CustomerNickels = control.CustomerQuanity;
                        break;
                    case "$0.01":
                        cashDrawer.CustomerPennies = control.CustomerQuanity;
                        break;
                }
            }
        }
        public static DependencyProperty ChangeQuanityProperty = DependencyProperty.Register("ChangeQuanity", typeof(int), typeof(CurrencyControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsMeasure, HandleMyChange));
        public int ChangeQuanity
        {
            get { return (int)GetValue(ChangeQuanityProperty); }
            set { SetValue(ChangeQuanityProperty, value); }
        }
        public static void HandleMyChange(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is CurrencyControl control)
            {
                BleakwindBuffet.Data.CashDrawerView cashDrawer = (BleakwindBuffet.Data.CashDrawerView)control.DataContext;
                switch (control.Label)
                {
                    case "$100":
                        cashDrawer.ChangeHundreds = control.CustomerQuanity;
                        break;
                    case "$50":
                        cashDrawer.ChangeFifties = control.CustomerQuanity;
                        break;
                    case "$20":
                        cashDrawer.ChangeTwenties = control.CustomerQuanity;
                        break;
                    case "$10":
                        cashDrawer.ChangeTens = control.CustomerQuanity;
                        break;
                    case "$5":
                        cashDrawer.ChangeFives = control.CustomerQuanity;
                        break;
                    case "$2":
                        cashDrawer.ChangeTwos = control.CustomerQuanity;
                        break;
                    case "$1":
                        cashDrawer.ChangeOnes = control.CustomerQuanity;
                        break;
                    case "$0.5":
                        cashDrawer.ChangeHalfDollars = control.CustomerQuanity;
                        break;
                    case "$0.25":
                        cashDrawer.ChangeQuarters = control.CustomerQuanity;
                        break;
                    case "$0.1":
                        cashDrawer.ChangeDimes = control.CustomerQuanity;
                        break;
                    case "$0.05":
                        cashDrawer.ChangeNickels = control.CustomerQuanity;
                        break;
                    case "$0.01":
                        cashDrawer.ChangePennies = control.CustomerQuanity;
                        break;
                }
            }
        }
        public static DependencyProperty LabelProperty = DependencyProperty.Register("Label", typeof(string), typeof(CurrencyControl));
        public string Label
        {
            get { return (string)GetValue(LabelProperty); }
            set { SetValue(LabelProperty, value); }
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            CustomerQuanity++;
        }
        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            if (CustomerQuanity > 0)
            {
                CustomerQuanity--;
            }
        }
    }
}
