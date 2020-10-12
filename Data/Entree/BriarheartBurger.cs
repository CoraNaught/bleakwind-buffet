/*
 * Author: Corrie Naughton
 * Class name: BrairheartBurger.cs
 * Purpose: Class used to represent Briarheart Burger Entree
 */
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds all of the information about the Briarheart Burger Entree
    /// </summary>
    public class BriarheartBurger : Entree
    {
        private bool bun = true, ketchup = true, mustard = true, pickle = true, cheese = true;
        /// <summary>
        /// Gets and sets values for bun
        /// </summary>
        public bool Bun
        {
            get => bun;
            set
            {
                bun = value;
                NotifyPropertyChanged("Bun");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Gets and sets values for ketchup
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set
            {
                ketchup = value;
                NotifyPropertyChanged("Ketchup");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Gets and sets values for mustard
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set
            {
                mustard = value;
                NotifyPropertyChanged("Mustard");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Gets and sets values for pickle
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set
            {
                pickle = value;
                NotifyPropertyChanged("Pickle");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Gets and sets values for cheese
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set
            {
                cheese = value;
                NotifyPropertyChanged("Cheese");
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
                return 6.32;
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 743;
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
                if(!Bun ) result.Add("Hold bun");
                if (!Ketchup) result.Add("Hold ketchup");
                if (!Mustard) result.Add("Hold mustard");
                if (!Pickle) result.Add("Hold pickle");
                if (!Cheese) result.Add("Hold cheese");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name of this object
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Briarheart Burger";
        }
    }
}
