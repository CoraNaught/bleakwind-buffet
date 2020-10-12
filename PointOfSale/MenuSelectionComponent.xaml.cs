using BleakwindBuffet.Data.Entrees;
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
    /// Interaction logic for MenuSelectionComponent.xaml
    /// </summary>
    public partial class MenuSelectionComponent : UserControl
    {
        DisplayControler parent;
        OrderTicket order;
        /// <summary>
        /// Menu Selection window
        /// </summary>
        /// <param name="display">Display controller</param>
        /// <param name="order">oder ticket</param>
        public MenuSelectionComponent(DisplayControler display, OrderTicket order)
        {
            InitializeComponent();
         
            this.parent = display;
            this.order = order;
        }
        /// <summary>
        /// Handles briarheart burger button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void briarheartBurger_Click(object sender, RoutedEventArgs e)
        { 
            BriarheartBurger b = new BriarheartBurger(parent, this, order);
            parent.containerBorder.Child = b;
        }
        /// <summary>
        /// Handles double draugr button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void doubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            DoubleDraugr d = new DoubleDraugr(parent, this, order);
            parent.containerBorder.Child = d;
        }
        /// <summary>
        /// Handles thalmor triple button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            ThalmorTriple t = new ThalmorTriple(parent, this, order);
            parent.containerBorder.Child = t;
        }
        /// <summary>
        /// Handles smokehouse skeleton button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void smokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            SmokehouseSkeleton s = new SmokehouseSkeleton(parent, this, order);
            parent.containerBorder.Child = s;
        }
        /// <summary>
        /// Handles garden orc omlette button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gardenOrcOmlette_Click(object sender, RoutedEventArgs e)
        {
            GardenOrcOmlette g = new GardenOrcOmlette(parent, this, order);
            parent.containerBorder.Child = g;
        }
        /// <summary>
        /// Handles thugs t-bone button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void thugsTBone_Click(object sender, RoutedEventArgs e)
        {
            ThugsTbone t = new ThugsTbone(parent, this, order);
            parent.containerBorder.Child = t;
        }
        /// <summary>
        /// Handles sailor soda button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sailorSoda_Click(object sender, RoutedEventArgs e)
        {
            SailorSoda s = new SailorSoda(parent, this, order);
            parent.containerBorder.Child = s;
        }
        /// <summary>
        /// Handles markarth milk button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void markathMilk_Click(object sender, RoutedEventArgs e)
        {
            MarkarthMilk m = new MarkarthMilk(parent, this, order);
            parent.containerBorder.Child = m;
        }
        /// <summary>
        /// Handles arentino apple juice button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void arentinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            ArentinoAppleJuice a = new ArentinoAppleJuice(parent, this, order);
            parent.containerBorder.Child = a;
        }
        /// <summary>
        /// Handles candlehearth coffee button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void candlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            CandlehearthCoffee c = new CandlehearthCoffee(parent, this, order);
            parent.containerBorder.Child = c;
        }
        /// <summary>
        /// Handles warrior water button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void warriorWater_Click(object sender, RoutedEventArgs e)
        {
            WarriorWater w = new WarriorWater(parent, this, order);
            parent.containerBorder.Child = w;
        }
        /// <summary>
        /// Handles vokun salad button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vokunSalad_Click(object sender, RoutedEventArgs e)
        {
            VokunSalad v = new VokunSalad(parent, this, order);
            parent.containerBorder.Child = v;
        }
        /// <summary>
        /// Handles fried miraak button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void friedMiraak_Click(object sender, RoutedEventArgs e)
        {
            FriedMiraak f = new FriedMiraak(parent, this, order);
            parent.containerBorder.Child = f;
        }
        /// <summary>
        /// Handles briarheart burger button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void madOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            MadOtarGrits m = new MadOtarGrits(parent, this, order);
            parent.containerBorder.Child = m;
        }
        /// <summary>
        /// Handles dragonborn Waffle fries button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            DragonbornWaffleFries d = new DragonbornWaffleFries(parent, this, order);
            parent.containerBorder.Child = d;
        }
    }
}
