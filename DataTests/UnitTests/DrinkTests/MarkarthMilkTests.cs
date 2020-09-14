/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: MarkarthMilkTests.cs
 * Purpose: Test the MarkarthMilk.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class MarkarthMilkTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            Assert.IsAssignableFrom<Drink>(markarthMilk);
            Assert.IsAssignableFrom<IOrderItem>(markarthMilk);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            Assert.False(markarthMilk.Ice);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            Assert.True(markarthMilk.Size == Size.Small);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Ice = true;
            Assert.True(markarthMilk.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Size = Size.Medium;
            Assert.True(markarthMilk.Size == Size.Medium);
        }

        [Theory]
        [InlineData(Size.Small, 1.05)]
        [InlineData(Size.Medium, 1.11)]
        [InlineData(Size.Large, 1.22)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Size = size;
            Assert.True(markarthMilk.Price == price);
        }

        [Theory]
        [InlineData(Size.Small, 56)]
        [InlineData(Size.Medium, 72)]
        [InlineData(Size.Large, 93)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Size = size;
            Assert.True(markarthMilk.Calories == cal);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce)
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            if (includeIce)
            {
                markarthMilk.Ice = true;
                Assert.Equal(markarthMilk.SpecialInstructions, new List<string> { "Add ice" });
            }
        }

        [Theory]
        [InlineData(Size.Small, "Small Markarth Milk")]
        [InlineData(Size.Medium, "Medium Markarth Milk")]
        [InlineData(Size.Large, "Large Markarth Milk")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MarkarthMilk markarthMilk = new MarkarthMilk();
            markarthMilk.Size = size;
            Assert.Equal(markarthMilk.ToString(), name);
        }
    }
}