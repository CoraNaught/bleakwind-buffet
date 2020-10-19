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
    /// Interaction logic for Combo.xaml
    /// </summary>
    public partial class Combo : UserControl
    {

        Data.Combo comboDeal;
        DisplayControler d;
        MenuSelectionComponent m;
        OrderTicket o;
        public Combo(DisplayControler d, MenuSelectionComponent m, OrderTicket o)
        {
            InitializeComponent();
            comboDeal = new Data.Combo();
            this.d = d;
            this.m = m;
            this.o = o;
        }

        private void briarheartBurger_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Entree = new BleakwindBuffet.Data.Entrees.BriarheartBurger();
            doubleDraugr.IsEnabled = false;
            thalmorTriple.IsEnabled = false;
            smokehouseSkeleton.IsEnabled = false;
            gardenOrcOmlette.IsEnabled = false;
            thugsTBone.IsEnabled = false;
        }

        private void doubleDraugr_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Entree = new BleakwindBuffet.Data.Entrees.DoubleDraugr();
            briarheartBurger.IsEnabled = false;
            thalmorTriple.IsEnabled = false;
            smokehouseSkeleton.IsEnabled = false;
            gardenOrcOmlette.IsEnabled = false;
            thugsTBone.IsEnabled = false;
        }

        private void thalmorTriple_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Entree = new BleakwindBuffet.Data.Entrees.ThalmorTriple();
            briarheartBurger.IsEnabled = false;
            doubleDraugr.IsEnabled = false;
            smokehouseSkeleton.IsEnabled = false;
            gardenOrcOmlette.IsEnabled = false;
            thugsTBone.IsEnabled = false;
        }

        private void smokehouseSkeleton_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Entree = new BleakwindBuffet.Data.Entrees.SmokehouseSkeleton();
            briarheartBurger.IsEnabled = false;
            thalmorTriple.IsEnabled = false;
            doubleDraugr.IsEnabled = false;
            gardenOrcOmlette.IsEnabled = false;
            thugsTBone.IsEnabled = false;
        }

        private void gardenOrcOmlette_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Entree = new BleakwindBuffet.Data.Entrees.GardenOrcOmlette();
            briarheartBurger.IsEnabled = false;
            thalmorTriple.IsEnabled = false;
            smokehouseSkeleton.IsEnabled = false;
            doubleDraugr.IsEnabled = false;
            thugsTBone.IsEnabled = false;
        }

        private void thugsTBone_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Entree = new BleakwindBuffet.Data.Entrees.ThugsT_Bone();
            briarheartBurger.IsEnabled = false;
            thalmorTriple.IsEnabled = false;
            smokehouseSkeleton.IsEnabled = false;
            gardenOrcOmlette.IsEnabled = false;
            doubleDraugr.IsEnabled = false;
        }

        private void sailorSoda_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Drink = new BleakwindBuffet.Data.Drinks.SailorSoda();
            candlehearthCoffee.IsEnabled = false;
            markathMilk.IsEnabled = false;
            arentinoAppleJuice.IsEnabled = false;
            warriorWater.IsEnabled = false;
        }

        private void markathMilk_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Drink = new BleakwindBuffet.Data.Drinks.MarkarthMilk();
            candlehearthCoffee.IsEnabled = false;
            sailorSoda.IsEnabled = false;
            arentinoAppleJuice.IsEnabled = false;
            warriorWater.IsEnabled = false;
        }

        private void arentinoAppleJuice_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Drink = new BleakwindBuffet.Data.Drinks.AretinoAppleJuice();
            candlehearthCoffee.IsEnabled = false;
            markathMilk.IsEnabled = false;
            sailorSoda.IsEnabled = false;
            warriorWater.IsEnabled = false;
        }

        private void candlehearthCoffee_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Drink = new BleakwindBuffet.Data.Drinks.CandlehearthCoffee();
            sailorSoda.IsEnabled = false;
            markathMilk.IsEnabled = false;
            arentinoAppleJuice.IsEnabled = false;
            warriorWater.IsEnabled = false;
        }

        private void warriorWater_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Drink = new BleakwindBuffet.Data.Drinks.WarriorWater();
            candlehearthCoffee.IsEnabled = false;
            markathMilk.IsEnabled = false;
            arentinoAppleJuice.IsEnabled = false;
            sailorSoda.IsEnabled = false;
        }

        private void vokunSalad_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Side = new BleakwindBuffet.Data.Sides.VokunSalad();
            dragonbornWaffleFries.IsEnabled = false;
            friedMiraak.IsEnabled = false;
            madOtarGrits.IsEnabled = false;
        }

        private void friedMiraak_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Side = new BleakwindBuffet.Data.Sides.FriedMiraak();
            vokunSalad.IsEnabled = false;
            dragonbornWaffleFries.IsEnabled = false;
            madOtarGrits.IsEnabled = false;
        }

        private void madOtarGrits_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Side = new BleakwindBuffet.Data.Sides.MadOtarGrits();
            vokunSalad.IsEnabled = false;
            friedMiraak.IsEnabled = false;
            dragonbornWaffleFries.IsEnabled = false;
        }

        private void dragonbornWaffleFries_Click(object sender, RoutedEventArgs e)
        {
            comboDeal.Side = new BleakwindBuffet.Data.Sides.DragonbornWaffleFries();
            vokunSalad.IsEnabled = false;
            friedMiraak.IsEnabled = false;
            madOtarGrits.IsEnabled = false;
        }

        private void combo_Click(object sender, RoutedEventArgs e)
        {
            briarheartBurger.IsEnabled = true;
            doubleDraugr.IsEnabled = true;
            thalmorTriple.IsEnabled = true;
            smokehouseSkeleton.IsEnabled = true;
            doubleDraugr.IsEnabled = true;
            thugsTBone.IsEnabled = true;
            candlehearthCoffee.IsEnabled = true;
            markathMilk.IsEnabled = true;
            arentinoAppleJuice.IsEnabled = true;
            sailorSoda.IsEnabled = true;
            warriorWater.IsEnabled = true;
            dragonbornWaffleFries.IsEnabled = true;
            vokunSalad.IsEnabled = true;
            friedMiraak.IsEnabled = true;
            madOtarGrits.IsEnabled = true;
            ListBox listBox = new ListBox();
            listBox.MouseLeftButtonUp += ListBox_MouseLeftButtonUp;
            listBox.MouseRightButtonUp += ListBox_MouseRightButtonUp;
            d.containerBorder.Child = m;
            if (o.DataContext is Order list)
            {
                list.Add(comboDeal.Drink);
                list.Add(comboDeal.Side);
                list.Add(comboDeal.Entree);
            }
            listBox.Items.Add($"Combo\t\t${comboDeal.Price}");
            foreach (var item in comboDeal.SpecialInstructions)
            {
                listBox.Items.Add($"-{item}");
            }
            o.itemsListView.Items.Add(listBox);
        }
        private void ListBox_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            o.itemsListView.Items.Remove(sender);
            if (o.DataContext is Order list)
            {
                list.Remove(comboDeal.Drink);
                list.Remove(comboDeal.Side);
                list.Remove(comboDeal.Entree);
            }
        }

        private void ListBox_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            o.itemsListView.Items.Remove(sender);
            if (o.DataContext is Order list)
            {
                list.Remove(comboDeal.Drink);
                list.Remove(comboDeal.Side);
                list.Remove(comboDeal.Entree);
            }
            d.containerBorder.Child = this;
        }
       
    }
}
