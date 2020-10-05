﻿/*
 * Author: Corrie Naughton
 * Class name: ThalmorTriple.cs
 * Purpose: Class used to represent Thalmor Triple Entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds all of the information about the Thalmor Triple Entree
    /// </summary>
    public class ThalmorTriple : Entree
    {
        private bool bun = true, ketchup = true, mustard = true, pickle = true, cheese = true,  tomato = true, lettuce = true, mayo = true, bacon = true, egg = true;
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
            }
        }
        /// <summary>
        /// Gets and sets values for tomato
        /// </summary>
        public bool Tomato
        {
            get => tomato;
            set
            {
                tomato = value;
                NotifyPropertyChanged("Tomato");
            }
        }
        /// <summary>
        /// Gets and sets values for lettuce
        /// </summary>
        public bool Lettuce
        {
            get => lettuce;
            set
            {
                lettuce = value;
                NotifyPropertyChanged("Lettuce");
            }
        }
        /// <summary>
        /// Gets and sets values for mayo
        /// </summary>
        public bool Mayo
        {
            get => mayo;
            set
            {
                mayo = value;
                NotifyPropertyChanged("Mayo");
            }
        }
        /// <summary>
        /// Gets and sets values for bacon
        /// </summary>
        public bool Bacon
        {
            get => bacon;
            set
            {
                bacon = value;
                NotifyPropertyChanged("Bacon");
            }
        }
        /// <summary>
        /// Gets and sets values for egg
        /// </summary>
        public bool Egg
        {
            get => egg;
            set
            {
                egg = value;
                NotifyPropertyChanged("Egg");
            }
        }
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public override double Price
        {
            get
            {
                return 8.32;
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 943;
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
                if (Bun == false) result.Add("Hold bun");
                if (Ketchup == false) result.Add("Hold ketchup");
                if (Mustard == false) result.Add("Hold mustard");
                if (Pickle == false) result.Add("Hold pickle");
                if (Cheese == false) result.Add("Hold cheese");
                if (Tomato == false) result.Add("Hold tomato");
                if (Lettuce == false) result.Add("Hold lettuce");
                if (Mayo == false) result.Add("Hold mayo");
                if (Bacon == false) result.Add("Hold bacon");
                if (Egg == false) result.Add("Hold egg");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name of this object
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Thalmor Triple";
        }
    }
}
