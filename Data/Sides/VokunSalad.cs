/*
 * Author: Corrie Naughton
 * Class name: VokunSalad.cs
 * Purpose: Class used to represent Vokun Salad Side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Holds all of the information about the Vokun Salad Side
    /// </summary>
    public class VokunSalad
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
                    return 0.93;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 1.28;
                }
                else
                {
                    return 1.82;
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
                    return 41;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 52;
                }
                else
                {
                    return 73;
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
            return $"{Size} Vokun Salad";
        }
    }
}
