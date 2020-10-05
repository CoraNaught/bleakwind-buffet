/*
 * Author: Corrie Naughton
 * Class name: Menu.cs
 * Purpose: Class that represents the restraunt menu
 */
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Class representing the restraunt menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Finds all of the entree options
        /// </summary>
        /// <returns>Ienumerable containing all of the entree options</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new BriarheartBurger());
            entrees.Add(new DoubleDraugr());
            entrees.Add(new GardenOrcOmlette());
            entrees.Add(new PhillyPoacher());
            entrees.Add(new SmokehouseSkeleton());
            entrees.Add(new ThalmorTriple());
            entrees.Add(new ThugsT_Bone());
            return entrees;
        }
        /// <summary>
        /// Finds all of the sides options
        /// </summary>
        /// <returns>IEnumerable containing all of the side options including sizes</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();
            foreach(Size size in Enum.GetValues(typeof(Size)))
            {
                DragonbornWaffleFries dragonBorn = new DragonbornWaffleFries();
                FriedMiraak friedMiraak = new FriedMiraak();
                MadOtarGrits madOtarGrits = new MadOtarGrits();
                VokunSalad vokunSalad = new VokunSalad();
                dragonBorn.Size = friedMiraak.Size = madOtarGrits.Size = vokunSalad.Size = size;
                sides.Add(dragonBorn);
                sides.Add(friedMiraak);
                sides.Add(madOtarGrits);
                sides.Add(vokunSalad);
            }
            return sides;
        }
        /// <summary>
        /// Finds all of the drink options
        /// </summary>
        /// <returns>IEnumerable containing all of the drink options including sizes and flavors</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
                CandlehearthCoffee candlehearth = new CandlehearthCoffee();
                MarkarthMilk markarth = new MarkarthMilk();
                WarriorWater warriorWater = new WarriorWater();
                aretinoAppleJuice.Size = candlehearth.Size = markarth.Size = warriorWater.Size = size;
                drinks.Add(aretinoAppleJuice);
                drinks.Add(candlehearth);
                drinks.Add(markarth);
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda sailorSoda = new SailorSoda();
                    sailorSoda.Size = size;
                    sailorSoda.Flavor = flavor;
                    drinks.Add(sailorSoda);
                }
                drinks.Add(warriorWater);
            }
            return drinks;
        }
        /// <summary>
        /// Finds all of the options in the menu
        /// </summary>
        /// <returns>IEnumerable containing the entire menu</returns>
        public static IEnumerable<IOrderItem> FullMenu()
        {
            List<IOrderItem> orderItems = new List<IOrderItem>();
            orderItems.Add(new BriarheartBurger());
            orderItems.Add(new DoubleDraugr());
            orderItems.Add(new GardenOrcOmlette());
            orderItems.Add(new PhillyPoacher());
            orderItems.Add(new SmokehouseSkeleton());
            orderItems.Add(new ThalmorTriple());
            orderItems.Add(new ThugsT_Bone());
            foreach (Size size in Enum.GetValues(typeof(Size)))
            {
                AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
                CandlehearthCoffee candlehearth = new CandlehearthCoffee();
                MarkarthMilk markarth = new MarkarthMilk();
                WarriorWater warriorWater = new WarriorWater();
                aretinoAppleJuice.Size = candlehearth.Size = markarth.Size = warriorWater.Size = size;
                orderItems.Add(aretinoAppleJuice);
                orderItems.Add(candlehearth);
                orderItems.Add(markarth);
                DragonbornWaffleFries dragonBorn = new DragonbornWaffleFries();
                FriedMiraak friedMiraak = new FriedMiraak();
                MadOtarGrits madOtarGrits = new MadOtarGrits();
                VokunSalad vokunSalad = new VokunSalad();
                dragonBorn.Size = friedMiraak.Size = madOtarGrits.Size = vokunSalad.Size = size;
                orderItems.Add(dragonBorn);
                orderItems.Add(friedMiraak);
                orderItems.Add(madOtarGrits);
                orderItems.Add(vokunSalad);
                foreach (SodaFlavor flavor in Enum.GetValues(typeof(SodaFlavor)))
                {
                    SailorSoda sailorSoda = new SailorSoda();
                    sailorSoda.Size = size;
                    sailorSoda.Flavor = flavor;
                    orderItems.Add(sailorSoda);
                }
                orderItems.Add(warriorWater);
            }
            return orderItems;
        }
    }
}

 