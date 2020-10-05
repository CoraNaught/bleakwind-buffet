/*
 * Author: Corrie Naughton
 * Class name: DisplayControler.cs
 * Purpose: Class that DisplayControler user control
 */
using BleakwindBuffet.Data.Entrees;
using System;
using System.Collections.Generic;
using System.Dynamic;
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
    /// Interaction logic for DisplayControler.xaml
    /// </summary>
    public partial class DisplayControler : UserControl
    {
        List<UIElement> lists = new List<UIElement>();
        OrderTicket order;
        public DisplayControler(OrderTicket order)
        {
            InitializeComponent();
            this.order = order;
            MenuSelectionComponent ms = new MenuSelectionComponent(this, order);
            containerBorder.Child = ms;
        }
    }
}
