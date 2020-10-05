/*
 * Author: Corrie Naughton
 * Class name: PhillyPoacher.cs
 * Purpose: Class used to represent Philly Poacher Entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds all of the information about the Philly Poacher Entrees
    /// </summary>
    public class PhillyPoacher : Entree
    {

        private bool sirloin = true, onion = true, roll = true;
        /// <summary>
        /// Gets and sets values for sirloin
        /// </summary>
        public bool Sirloin
        {
            get => sirloin;
            set
            {
                sirloin = value;
                NotifyPropertyChanged("Sirloin");
            }
        }
        /// <summary>
        /// Gets and sets values for onion
        /// </summary>
        public bool Onion
        {
            get => onion;
            set
            {
                onion = value;
                NotifyPropertyChanged("Onion");
            }
        }
        /// <summary>
        /// Gets and sets values for roll
        /// </summary>
        public bool Roll
        {
            get => roll;
            set
            {
                roll = value;
                NotifyPropertyChanged("Roll");
            }
        }
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.23;
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 784;
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
                if (Sirloin == false) result.Add("Hold sirloin");
                if (Onion == false) result.Add("Hold onion");
                if (Roll == false) result.Add("Hold roll");
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
