﻿
/*
 * Author: Corrie Naughton
 * Class name: SailorSoda.cs
 * Purpose: Class used to represent Sailor Soda Drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds all of the information about the Sailor Soda Drink
    /// </summary>
    public class SailorSode
    {
        private bool ice = true;
        private Enums.Size size = Enums.Size.Small;
        private Enums.SodaFlavor flavor = Enums.SodaFlavor.Cherry;
        /// <summary>
        /// Gets and sets values for ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set => ice = value;
        }
        /// <summary>
        /// Gets and sets values for drink size
        /// </summary>
        public Enums.Size Size
        {
            get => size;
            set => size = value;
        }
        /// <summary>
        /// Gets and sets values for drink flavor
        /// </summary>
        public Enums.SodaFlavor Flavor
        {
            get => flavor;
            set => flavor = value;
        }
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public double Price
        {
            get
            {
                if (Size == Enums.Size.Small)
                {
                    return 1.42;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 1.74;
                }
                else
                {
                    return 2.07;
                }
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small)
                {
                    return 117;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 153;
                }
                else
                {
                    return 205;
                }
            }
        }
        /// <summary>
        /// Stores a list of special instructions for this object
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> result = new List<string>();
                if (Ice == false) result.Add("Hold ice");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name flavor and size of this object
        /// </summary>
        /// <returns>name and size of the drink</returns>
        public override string ToString()
        {
            return $"{Size} {Flavor} Sailor Soda";
        }
    }
}
