/*
 * Author: Corrie Naughton
 * Class name: AretinoAppleJuice.cs
 * Purpose: Class used to represent Aretino Apple Juice Drink
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Data.Enums;
namespace Data.Drinks
{
    /// <summary>
    /// Holds all of the information about the Aretino Apple Juice Drink
    /// </summary>
    public class AretinoAppleJuice
    {
        private bool ice = true;
        private Enums.Size size = Enums.Size.Small;
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
        /// Stores the price of this object
        /// </summary>
        public double Price
        {
            get
            {
                if(Size == Enums.Size.Small)
                {
                    return 0.62;
                }
                else if(Size == Enums.Size.Medium)
                {
                    return 0.87;
                }
                else
                {
                    return 1.01;
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
                    return 44;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 88;
                }
                else
                {
                    return 132;
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
                if (Ice == true) result.Add("Add ice");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name and size of this object
        /// </summary>
        /// <returns>name and size of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Arentino Apple Juice";
        }
    }
}
