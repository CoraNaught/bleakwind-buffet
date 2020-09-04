﻿/*
 * Author: Corrie Naughton
 * Class name: DoubleDraugr.cs
 * Purpose: Class used to represent Double Draugr Entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds all of the information about the Double Draugr Entree
    /// </summary>
    public class DoubleDraugr
    {
        private bool bun = true, ketchup = true, mustard = true, pickle = true, cheese = true, tomato = true, lettuce = true, mayo = true;
        /// <summary>
        /// Gets and sets values for bun
        /// </summary>
        public bool Bun
        {
            get => bun;
            set => bun = value;
        }
        /// <summary>
        /// Gets and sets values for ketchup
        /// </summary>
        public bool Ketchup
        {
            get => ketchup;
            set => ketchup = value;
        }
        /// <summary>
        /// Gets and sets values for mustard
        /// </summary>
        public bool Mustard
        {
            get => mustard;
            set => mustard = value;
        }
        /// <summary>
        /// Gets and sets values for pickle
        /// </summary>
        public bool Pickle
        {
            get => pickle;
            set => pickle = value;
        }
        /// <summary>
        /// Gets and sets values for cheese
        /// </summary>
        public bool Cheese
        {
            get => cheese;
            set => cheese = value;
        }
        /// <summary>
        /// Gets and sets values for tomato
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set => tomato = value;
        }
        /// <summary>
        /// Gets and sets values for lettuce
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set => lettuce = value;
        }
        /// <summary>
        /// Gets and sets values for mayo
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set => mayo = value;
        }
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public double Price
        {
            get
            {
                return 7.32;
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public uint Calories
        {
            get
            {
                return 843;
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
                if (Bun == false) result.Add("Hold bun");
                if (Ketchup == false) result.Add("Hold ketchup");
                if (Mustard == false) result.Add("Hold mustard");
                if (Pickle == false) result.Add("Hold pickle");
                if (Cheese == false) result.Add("Hold cheese");
                if (Tomato == false) result.Add("Hold tomato");
                if (Lettuce == false) result.Add("Hold lettuce");
                if (Mayo == false) result.Add("Hold mayo");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name of this object
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}