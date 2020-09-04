/*
 * Author: Corrie Naughton
 * Class name: WarriorWater.cs
 * Purpose: Class used to represent Warrior Water Drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds all of the information about the Warrior Water Drink
    /// </summary>
    public class WarriorWater
    {
        private bool ice = true;
        private bool lemon = false;
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
        /// Gets and sets values for lemons
        /// </summary>
        public bool Lemon
        {
            get => lemon;
            set => lemon = value;
        }
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public double Price
        {
            get
            {
                return 0.00;
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public uint Calories
        {
            get
            {
                return 0;
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
                if(Lemon == true) result.Add("Add lemon");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name and size of this object
        /// </summary>
        /// <returns>name and size of the drink</returns>
        public override string ToString()
        {
            return $"{Size} Warrior Water";
        }
    }
}
