/*
 * Author: Corrie Naughton
 * Class name: FriedMiraak.cs
 * Purpose: Class used to represent Fried Miraak Side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Holds all of the information about the Fried Miraak Side
    /// </summary>
    public class FriedMiraak : Side
    {
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small)
                {
                    return 1.78;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 2.01;
                }
                else
                {
                    return 2.88;
                }
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Size == Enums.Size.Small)
                {
                    return 151;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 236;
                }
                else
                {
                    return 306;
                }
            }
        }
        /// <summary>
        /// Stores a list of special instructions for this object
        /// </summary>
        public override List<string> SpecialInstructions
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
            return $"{Size} Fried Miraak";
        }
    }
}
