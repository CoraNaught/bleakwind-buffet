/*
 * Author: Corrie Naughton
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent Philly Poacher Entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Entrees
{
    /// <summary>
    /// Holds all of the information about the Philly Poacher Entrees
    /// </summary>
    public class PhillyPoacher
    {

        private bool sirloin, onion, roll = true;
        /// <summary>
        /// Gets and sets values for sirloin
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set => sirloin = value;
        }
        /// <summary>
        /// Gets and sets values for onion
        /// </summary>
        public bool Onion
        {
            get => onion;
            set => onion = value;
        }
        /// <summary>
        /// Gets and sets values for roll
        /// </summary>
        public bool Roll
        {
            get => roll;
            set => roll = value;
        }
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public double Price
        {
            get
            {
                return 7.23;
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public uint Calories
        {
            get
            {
                return 784;
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
                if (Sirloin == false) result.Add("Hold Sirloin");
                if (Onion == false) result.Add("Hold Onion");
                if (Roll == false) result.Add("Hold Roll");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name of this object
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
