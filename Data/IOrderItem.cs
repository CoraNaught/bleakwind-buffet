﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Interface containing all of the common components of the menu items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the drink
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        double Price { get; }

        /// <summary>
        /// The calories of the drink
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Special instructions for the preperation of the drink
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}