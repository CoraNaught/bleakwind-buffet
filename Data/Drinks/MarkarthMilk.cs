/*
 * Author: Corrie Naughton
 * Class name: MarkarthMilk.cs
 * Purpose: Class used to represent Markarth Milk Drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds all of the information about the Markarth Milk Drink
    /// </summary>
    public class MarkarthMilk : Drink
    {
        private bool ice = false;
        /// <summary>
        /// Gets and sets values for ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set
            {
                ice = value;
                NotifyPropertyChanged("Ice");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public override double Price
        {
            get
            {
                if (Size == Enums.Size.Small)
                {
                    return 1.05;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 1.11;
                }
                else
                {
                    return 1.22;
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
                    return 56;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 72;
                }
                else
                {
                    return 93;
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
            return $"{Size} Markarth Milk";
        }
    }
}
