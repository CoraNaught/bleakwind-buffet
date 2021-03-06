﻿/*
 * Author: Corrie Naughton
 * Class name: CandlehearthCoffee.cs
 * Purpose: Class used to represent Candlehearth Coffee Drink.
 */
using System;
using System.Collections.Generic;
using System.Text;
namespace BleakwindBuffet.Data.Drinks
{
    /// <summary>
    /// Holds all of the information about the Candlehearth Coffee Drink
    /// </summary>
    public class CandlehearthCoffee : Drink
    {
        private bool ice = false, decaf = false, roomForCream = false;
        /// <summary>
        /// Gets and sets values for ice
        /// </summary>
        public bool Ice
        {
            get => ice;
            set {
                ice = value;
                NotifyPropertyChanged("Ice");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Gets and sets values for decaf or not
        /// </summary>
        public bool Decaf
        {
            get => decaf;
            set
            {
                decaf = value;
                NotifyPropertyChanged("Decaf");
                NotifyPropertyChanged("SpecialInstructions");
            }
        }
        /// <summary>
        /// Gets and sets values for room for cream or not
        /// </summary>
        public bool RoomForCream
        {
            get => roomForCream;
            set
            {
                roomForCream = value;
                NotifyPropertyChanged("Room for Cream");
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
                    return 0.75;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 1.25;
                }
                else
                {
                    return 1.75;
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
                    return 7;
                }
                else if (Size == Enums.Size.Medium)
                {
                    return 10;
                }
                else
                {
                    return 20;
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
                if(RoomForCream == true) result.Add("Add cream");
                return result;
            }
        }
        /// <summary>
        /// override that prints the name and size of this object
        /// </summary>
        /// <returns>name and size of the drink</returns>
        public override string ToString()
        {
            if(Decaf == false)
            {
                return $"{Size} Candlehearth Coffee";
            }
            else
            {
                return $"{Size} Decaf Candlehearth Coffee";
            }
           
        }

        /// <summary>
        /// Discription of the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Fair trade, fresh ground dark roast coffee.";
            }
        }
    }
}
