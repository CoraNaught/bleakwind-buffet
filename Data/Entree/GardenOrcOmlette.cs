/*
 * Author: Corrie Naughton
 * Class name: CardenOrcOmlette.cs
 * Purpose: Class used to represent Garden Orc Omlette Entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds all of the information about the Garden Orc Omlette Entree
    /// </summary>
    public class GardenOrcOmlette : Entree
    {
        private bool broccoli = true, mushrooms = true, tomato = true, cheddar = true;
        /// <summary>
        /// Gets and sets values for broccoli
        /// </summary>
        public bool Broccoli
        {
            get => broccoli;
            set => broccoli = value;
        }
        /// <summary>
        /// Gets and sets values for mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get => mushrooms;
            set => mushrooms = value;
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
        /// Gets and sets values for cheddar
        /// </summary>
        public bool Cheddar
        {
            get => cheddar;
            set => cheddar = value;
        }
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.57;
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 404;
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
                if (Broccoli == false) result.Add("Hold broccoli");
                if (Mushrooms == false) result.Add("Hold mushrooms");
                if (Tomato == false) result.Add("Hold tomato");
                if (Cheddar == false) result.Add("Hold cheddar");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name of this object
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }
}
