/*
 * Author: Corrie Naughton
 * Class name: MadOtarGrits.cs
 * Purpose: Class used to represent Mad Otar Grits Side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// Holds all of the information about the Mad Otar Grits Side
    /// </summary>
    public class MadOtarGrits : Side 
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
                    return 1.22;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 1.58;
                }
                else
                {
                    return 1.93;
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
                    return 105;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 142;
                }
                else
                {
                    return 179;
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
            return $"{Size} Mad Otar Grits";
        }
    }
}
