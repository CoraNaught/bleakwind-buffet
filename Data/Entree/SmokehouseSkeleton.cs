/*
 * Author: Corrie Naughton
 * Class name: SmokehouseSkeleton.cs
 * Purpose: Class used to represent Smokehouse Skeleton Entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds all of the information about the Smokehouse Skeleton Entree
    /// </summary>
    public class SmokehouseSkeleton : Entree
    {
        private bool sausageLink = true, egg = true, hashBrowns = true, pancake = true;
        /// <summary>
        /// Gets and sets values for sausage
        /// </summary>
        public bool SausageLink
        {
            get => sausageLink;
            set
            {
                sausageLink = value;
                NotifyPropertyChanged("Sausage Link");
                NotifyPropertyChanged("SpecialInstructions");
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
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Gets and sets values for hash browns
        /// </summary>
        public bool HashBrowns
        {
            get => hashBrowns;
            set
            {
                hashBrowns = value;
                NotifyPropertyChanged("Hash Browns");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Gets and sets values for pan cake
        /// </summary>
        public bool PanCake
        {
            get => pancake;
            set
            {
                pancake = value;
                NotifyPropertyChanged("Pancake");
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
                return 5.62;
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 602;
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
                if (SausageLink == false) result.Add("Hold sausage");
                if (Egg == false) result.Add("Hold eggs");
                if (HashBrowns == false) result.Add("Hold hash browns");
                if (PanCake == false) result.Add("Hold pancakes");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name of this object
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
