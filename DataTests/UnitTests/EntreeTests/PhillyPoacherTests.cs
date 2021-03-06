﻿/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: PhillyPoacherTests.cs
 * Purpose: Test the PhillyPoacher.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class PhillyPoacherTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.IsAssignableFrom<Entree>(phillyPoacher);
            Assert.IsAssignableFrom<IOrderItem>(phillyPoacher);
        }
        [Fact]
        public void ShouldBeAbleToGetDisciption()
        {
            PhillyPoacher p= new PhillyPoacher();
            Assert.Equal(p.Description, "Cheesesteak sandwich made from grilled sirloin, topped with onions on a fried roll.");
        }
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(phillyPoacher);
        }
        [Fact]
        public void ShouldInlcudeSirloinByDefault()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.True(phillyPoacher.Sirloin);
        }

        [Fact]
        public void ShouldInlcudeOnionByDefault()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.True(phillyPoacher.Onion);
        }

        [Fact]
        public void ShouldInlcudeRollByDefault()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.True(phillyPoacher.Roll);
        }

        [Fact]
        public void ShouldBeAbleToSetSirloin()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            phillyPoacher.Sirloin = false;
            Assert.False(phillyPoacher.Sirloin);
        }

        [Fact]
        public void ShouldBeAbleToSetOnions()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            phillyPoacher.Onion = false;
            Assert.False(phillyPoacher.Onion);
        }

        [Fact]
        public void ShouldBeAbleToSetRoll()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            phillyPoacher.Roll = false;
            Assert.False(phillyPoacher.Roll);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.True(phillyPoacher.Price == 7.23);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.True(phillyPoacher.Calories == 784);
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSirloin, bool includeOnion,
                                                            bool includeRoll)
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            List<string> specialInstructions = new List<string>();
            if (!includeSirloin)
            {
                phillyPoacher.Sirloin = false;
                specialInstructions.Add("Hold sirloin");
            }
            if (!includeOnion)
            {
                phillyPoacher.Onion = false;
                specialInstructions.Add("Hold onion");
            }
            if (!includeRoll)
            {
                phillyPoacher.Roll = false;
                specialInstructions.Add("Hold roll");
            }
            Assert.Equal(phillyPoacher.SpecialInstructions, specialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            Assert.Equal(phillyPoacher.ToString(), "Philly Poacher");
        }
        [Fact]
        public void ChangingSirloinNotifiesSirloinProperty()
        {
            var PP = new PhillyPoacher();

            Assert.PropertyChanged(PP, "Sirloin", () =>
            {
                PP.Sirloin = true;
            });

            Assert.PropertyChanged(PP, "Sirloin", () =>
            {
                PP.Sirloin = false;
            });
        }
        [Fact]
        public void ChangingOnionNotifiesOnionProperty()
        {
            var PP = new PhillyPoacher();

            Assert.PropertyChanged(PP, "Onion", () =>
            {
                PP.Onion = true;
            });

            Assert.PropertyChanged(PP, "Onion", () =>
            {
                PP.Onion = false;
            });
        }
        [Fact]
        public void ChangingRollNotifiesRollProperty()
        {
            var PP = new PhillyPoacher();

            Assert.PropertyChanged(PP, "Roll", () =>
            {
                PP.Roll = true;
            });

            Assert.PropertyChanged(PP, "Roll", () =>
            {
                PP.Roll = false;
            });
        }
    }
}