/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: AretinoAppleJuiceTests.cs
 * Purpose: Test the AretinoAppleJuice.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class AretinoAppleJuiceTests
    {
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            Assert.False(aretinoAppleJuice.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            Assert.True(aretinoAppleJuice.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Ice = true;
            Assert.True(aretinoAppleJuice.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Size = Size.Large;
            Assert.True(aretinoAppleJuice.Size == Size.Large);
        }

        [Theory]
        [InlineData(Size.Small, 0.62)]
        [InlineData(Size.Medium, 0.87)]
        [InlineData(Size.Large, 1.01)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Size = size;
            Assert.True(aretinoAppleJuice.Price == price);
        }

        [Theory]
        [InlineData(Size.Small, 44)]
        [InlineData(Size.Medium, 88)]
        [InlineData(Size.Large, 132)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            aretinoAppleJuice.Size = size;
            Assert.True(aretinoAppleJuice.Calories == cal);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            if (includeIce)
            {
                aretinoAppleJuice.Ice = true;
                Assert.Equal(aretinoAppleJuice.SpecialInstructions, new List<string> { "Add ice" });
            }
            else
            {
                Assert.Equal(aretinoAppleJuice.SpecialInstructions, new List<string>());
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Aretino Apple Juice")]
        [InlineData(Size.Medium, "Medium Aretino Apple Juice")]
        [InlineData(Size.Large, "Large Aretino Apple Juice")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            AretinoAppleJuice aretinoAppleJuice = new AretinoAppleJuice();
            if(size == Size.Medium)
            {
                aretinoAppleJuice.Size = Size.Medium;             
            }
            else if(size == Size.Large)
            {
                aretinoAppleJuice.Size = Size.Large;
            }
            Assert.Equal(aretinoAppleJuice.ToString(), name);
        }
    }
}