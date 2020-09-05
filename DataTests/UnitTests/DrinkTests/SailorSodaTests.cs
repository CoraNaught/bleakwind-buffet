/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: SailorSodaTests.cs
 * Purpose: Test the SailorSoda.cs class in the Data library
 */
using System;

using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class SailorSodaTests
    {
        [Fact]
        public void ShouldIncludeIceByDefault()
        {
            SailorSode sailorSode = new SailorSode();
            Assert.True(sailorSode.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            SailorSode sailorSode = new SailorSode();
            Assert.True(sailorSode.Size == Size.Small);
        }

        [Fact]
        public void FlavorShouldBeCherryByDefault()
        {
            SailorSode sailorSode = new SailorSode();
            Assert.True(sailorSode.Flavor == SodaFlavor.Cherry);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            SailorSode sailorSode = new SailorSode();
            sailorSode.Ice = false;
            Assert.False(sailorSode.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            SailorSode sailorSode = new SailorSode();
            sailorSode.Size = Size.Large;
            Assert.True(sailorSode.Size == Size.Large);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavor()
        {
            SailorSode sailorSode = new SailorSode();
            sailorSode.Flavor = SodaFlavor.Blackberry;
            Assert.True(sailorSode.Flavor == SodaFlavor.Blackberry);
        }

        [Theory]
        [InlineData(Size.Small, 1.42)]
        [InlineData(Size.Medium, 1.74)]
        [InlineData(Size.Large, 2.07)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            SailorSode sailorSode = new SailorSode();
            sailorSode.Size = size;
            Assert.True(sailorSode.Price == price);
        }

        [Theory]
        [InlineData(Size.Small, 117)]
        [InlineData(Size.Medium, 153)]
        [InlineData(Size.Large, 205)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            SailorSode sailorSode = new SailorSode();
            sailorSode.Size = size;
            Assert.True(sailorSode.Calories == cal);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            SailorSode sailorSode = new SailorSode();
            if (!includeIce)
            {
                sailorSode.Ice = false;
                Assert.Equal(sailorSode.SpecialInstructions, new List<string> { "Hold ice" });
            }
            else
            {
                Assert.Equal(sailorSode.SpecialInstructions, new List<string>());
            }
        }
        [Theory]
        [InlineData(SodaFlavor.Cherry, Size.Small, "Small Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Medium, "Medium Cherry Sailor Soda")]
        [InlineData(SodaFlavor.Cherry, Size.Large, "Large Cherry Sailor Soda")]

        [InlineData(SodaFlavor.Blackberry, Size.Small, "Small Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Medium, "Medium Blackberry Sailor Soda")]
        [InlineData(SodaFlavor.Blackberry, Size.Large, "Large Blackberry Sailor Soda")]

        [InlineData(SodaFlavor.Grapefruit, Size.Small, "Small Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Medium, "Medium Grapefruit Sailor Soda")]
        [InlineData(SodaFlavor.Grapefruit, Size.Large, "Large Grapefruit Sailor Soda")]

        [InlineData(SodaFlavor.Lemon, Size.Small, "Small Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Medium, "Medium Lemon Sailor Soda")]
        [InlineData(SodaFlavor.Lemon, Size.Large, "Large Lemon Sailor Soda")]

        [InlineData(SodaFlavor.Peach, Size.Small, "Small Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Medium, "Medium Peach Sailor Soda")]
        [InlineData(SodaFlavor.Peach, Size.Large, "Large Peach Sailor Soda")]

        [InlineData(SodaFlavor.Watermelon, Size.Small, "Small Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Medium, "Medium Watermelon Sailor Soda")]
        [InlineData(SodaFlavor.Watermelon, Size.Large, "Large Watermelon Sailor Soda")]
        public void ShouldHaveCorrectToStringBasedOnSizeAndFlavor(SodaFlavor flavor, Size size, string name)
        {
            SailorSode sailorSode = new SailorSode();
            sailorSode.Flavor = flavor;
            sailorSode.Size = size;
            Assert.Equal(sailorSode.ToString(), name);
        }
    }
}
