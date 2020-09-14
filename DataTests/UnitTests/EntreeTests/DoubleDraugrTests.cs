/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: DoubleDraugrTests.cs
 * Purpose: Test the DoubleDraugr.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class DoubleDraugrTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.IsAssignableFrom<Entree>(doubleDraugr);
            Assert.IsAssignableFrom<IOrderItem>(doubleDraugr);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Bun = false;
            Assert.False(doubleDraugr.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Ketchup = false;
            Assert.False(doubleDraugr.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Mustard = false;
            Assert.False(doubleDraugr.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Pickle = false;
            Assert.False(doubleDraugr.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Cheese = false;
            Assert.False(doubleDraugr.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Tomato = false;
            Assert.False(doubleDraugr.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Lettuce = false;
            Assert.False(doubleDraugr.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            doubleDraugr.Mayo = false;
            Assert.False(doubleDraugr.Mayo);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Price == 7.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.True(doubleDraugr.Calories == 843);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo)
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            List<string> specialInstructions = new List<string>();
            if (!includeBun)
            {
                doubleDraugr.Bun = false;
                specialInstructions.Add("Hold bun");
            }
            if (!includeKetchup)
            {
                doubleDraugr.Ketchup = false;
                specialInstructions.Add("Hold ketchup");
            }
            if (!includeMustard)
            {
                doubleDraugr.Mustard = false;
                specialInstructions.Add("Hold mustard");
            }
            if (!includePickle)
            {
                doubleDraugr.Pickle = false;
                specialInstructions.Add("Hold pickle");
            }
            if (!includeCheese)
            {
                doubleDraugr.Cheese = false;
                specialInstructions.Add("Hold cheese");
            }
            if (!includeTomato)
            {
                doubleDraugr.Tomato = false;
                specialInstructions.Add("Hold tomato");
            }
            if (!includeLettuce)
            {
                doubleDraugr.Lettuce = false;
                specialInstructions.Add("Hold lettuce");
            }
            if (!includeMayo)
            {
                doubleDraugr.Mayo = false;
                specialInstructions.Add("Hold mayo");
            }
            Assert.Equal(doubleDraugr.SpecialInstructions, specialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            Assert.Equal(doubleDraugr.ToString(), "Double Draugr");
        }
    }
}