/*
 * Author: Corrie Naughton
 * Class name: Combo.cs
 * Purpose: Class used to represent a combo meal
 */
using System;
using System.Collections.Generic;
using System.Text;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Data
{
    /// <summary>
    /// holds information for a combo meal
    /// </summary>
    public class Combo : IOrderItem, INotifyPropertyChanged
    {
        private Entree entree;
        private Drink drink;
        private Side side;
        /// <summary>
        /// an Entree object
        /// </summary>
        public Entree Entree{
            get => entree;
            set
            {
                if(entree != value)
                {
                    entree = value;
                    NotifyPropertyChanged("Entree");
                }
            }
        }
        /// <summary>
        /// a drink object
        /// </summary>
        public Drink Drink
        {
            get => drink;
            set
            {
                if (drink != value)
                {
                    drink = value;
                    NotifyPropertyChanged("Drink");
                }
            }
        }
        /// <summary>
        /// a side object
        /// </summary>
        public Side Side
        {
            get => side;
            set
            {
                if(side != value)
                {
                    side = value;
                    NotifyPropertyChanged("Side");
                }
            }
        }
        /// <summary>
        /// total calories in calories
        /// </summary>
        public uint Calories
        {
            get
            {
                return entree.Calories + drink.Calories + side.Calories;
            }
        }
        /// <summary>
        /// total price in dollars
        /// </summary>
        public double Price
        {
            get
            {
                return entree.Price + drink.Price + side.Price - 1.00;
            }
        }
        /// <summary>
        /// entire combo inluding each items special instructions
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> result = new List<string>();
                result.Add(entree.ToString());
                foreach(var item in entree.SpecialInstructions)
                {
                    result.Add(item);
                }
                result.Add(drink.ToString());
                foreach (var item in drink.SpecialInstructions)
                {
                    result.Add(item);
                }
                result.Add(side.ToString());
                foreach (var item in side.SpecialInstructions)
                {
                    result.Add(item);
                }
                return result;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}