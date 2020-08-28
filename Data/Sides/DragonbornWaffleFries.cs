/*
 * Author: Corrie Naughton
 * Class name: DragonbornWaffleFries.cs
 * Purpose: Class used to represent Dragonborn Waffle Fries Side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Sides
{
    /// <summary>
    /// Holds all of the information about the Dragonborn Waffle Fries Side
    /// </summary>
    public class DragonbornWaffleFries
    {
        private Enums.Size size = Enums.Size.Small;

        /// <summary>
        /// Gets and sets values for side size
        /// </summary>
        public Enums.Size Size
        {
            get => size;
            set => size = value;
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
                    return 0.42;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 0.76;
                }
                else
                {
                    return 0.96;
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
                    return 77;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 89;
                }
                else
                {
                    return 100;
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
                return new List<string>();
            }
        }
        /// <summary>
        /// override that prints the name and size of this object
        /// </summary>
        /// <returns>name and size of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Dragonborn Waffle Fries";
        }
    }
}
