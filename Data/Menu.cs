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
        public static IEnumerable<IOrderItem> Search(string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            ///null check
            if (terms == null) return FullMenu();

            foreach (IOrderItem item in FullMenu())
            {
                //add movie if the title is a match
                if (item.ToString() != null && item.ToString().ToLower().Contains(terms.ToLower()))
                {
                    results.Add(item);
                }
            }
            return results;
        }
        public static string[] ItemType
        {
            get => new string[]
            {
            "Entree",
            "Drink",
            "Side"
            };
        }
        /// <summary>
        /// Filters the provided collection of movies
        /// </summary>
        /// <param name="movies">The collection of movies to filter</param>
        /// <param name="ratings">The ratings to include</param>
        /// <returns>A collection containing only movies that match the filter</returns>
        public static IEnumerable<IOrderItem> FilterByItemType(IEnumerable<IOrderItem> movies, IEnumerable<string> ratings)
        {
            // If no filter is specified, just return the provided collection
            if (ratings == null || ratings.Count() == 0) return movies;
            List<IOrderItem> results = new List<IOrderItem>();
            if (ratings.Contains("Entree"))
            {
                foreach (IOrderItem item in movies)
                {
                    foreach (IOrderItem entree in Entrees())
                    {
                        if (entree.ToString().Equals(item.ToString(), StringComparison.CurrentCultureIgnoreCase))
                        {
                            results.Add(item);
                        }
                    }
                }
            }
            if (ratings.Contains("Drink"))
            {
                foreach (IOrderItem item in movies)
                {
                    foreach (IOrderItem drink in Drinks())
                    {
                        if (drink.ToString().Equals(item.ToString(), StringComparison.CurrentCultureIgnoreCase))
                        {
                            results.Add(item);
                        }
                    }
                }
            }
            if (ratings.Contains("Side"))
            {
                foreach (IOrderItem item in movies)
                {
                    foreach (IOrderItem side in Sides())
                    {
                        if (side.ToString().Equals(item.ToString(), StringComparison.CurrentCultureIgnoreCase))
                        {
                            results.Add(item);
                        }
                    }
                }
            }

            return results;
        }

        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> movies, double? min, double? max)
        {
            if (min == null && max == null) return movies;
            var results = new List<IOrderItem>();
            // Both minimum and maximum specified
            foreach (IOrderItem movie in movies)
            {
                if (movie.Calories >= min && movie.Calories <= max)
                {
                    results.Add(movie);
                }
            }
            return results;
        }

        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> movies, double? min, double? max)
        {
            if (min == null && max == null) return movies;
            var results = new List<IOrderItem>();
            // Both minimum and maximum specified
            foreach (IOrderItem movie in movies)
            {
                if (movie.Price >= min && movie.Price <= max)
                {
                    results.Add(movie);
                }
            }
            return results;
        }
    }
}

 