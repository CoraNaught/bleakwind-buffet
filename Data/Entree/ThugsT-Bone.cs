﻿/*
 * Author: Corrie Naughton
 * Class name: ThugsT-Bone.cs
 * Purpose: Class used to represent Thugs T-Bone
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// Holds all of the information about the Thugs T_Bone
    /// </summary>
    public class ThugsT_Bone : Entree
    {
        /// <summary>
        /// Stores the price of this object
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.44;
            }
        }
        /// <summary>
        /// Stores the amount of calories in this object
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 982;
            }
        }
        /// <summary>
        /// Stores a list of special instructions for this object
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }
        /// <summary>
        /// override that prints the name of this object
        /// </summary>
        /// <returns>name of entree</returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }

        /// <summary>
        /// Discription of the item
        /// </summary>
        public override string Description
        {
            get
            {
                return "Juicy T-Bone, not much else to say.";
            }
        }
    }
}
