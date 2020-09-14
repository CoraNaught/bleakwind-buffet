/*
 * Author: Corrie Naughton
 * Class: WarriorWaterTests.cs
 * Purpose: Test the WarriorWater.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;

namespace DataTests.UnitTests.DrinkTests
{
    public class WarriorWaterTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            WarriorWater warriorWater = new WarriorWater();
            Assert.IsAssignableFrom<Drink>(warriorWater);
            Assert.IsAssignableFrom<IOrderItem>(warriorWater);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            WarriorWater warriorWater = new WarriorWater();
            Assert.True(warriorWater.Ice);
        }
        [Fact]
        public void ShouldNotIncludeLemonByDefault()
        {
            WarriorWater warriorWater = new WarriorWater();
            Assert.False(warriorWater.Lemon);
        }

        [Fact]
        public void ShouldBySmallByDefault()
        {
            WarriorWater warriorWater = new WarriorWater();
            Assert.True(warriorWater.Size == Size.Small);
        }

        [Fact]
        public void ShouldByAbleToSetIce()
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Ice = false;
            Assert.False(warriorWater.Ice);
        }

        [Fact]
        public void ShouldByAbleToSetLemon()
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Ice = true;
            Assert.True(warriorWater.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Size = Size.Medium;
            Assert.True(warriorWater.Size == Size.Medium);
        }

        [Theory]
        [InlineData(Size.Small, 0.00)]
        [InlineData(Size.Medium, 0.00)]
        [InlineData(Size.Large, 0.00)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Size = size;
            Assert.True(warriorWater.Price == price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Size = size;
            Assert.True(warriorWater.Calories == cal);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeLemon)
        {
            WarriorWater warriorWater = new WarriorWater();
            List<string> specialInstructions = new List<string>();
            if (!includeIce)
            {
                warriorWater.Ice = false;
                specialInstructions.Add("Hold ice");
            }
            if (includeLemon)
            {
                warriorWater.Lemon = true;
                specialInstructions.Add("Add lemon");
            }
            Assert.Equal(warriorWater.SpecialInstructions, specialInstructions);
        }

        [Theory]
        [InlineData(Size.Small, "Small Warrior Water")]
        [InlineData(Size.Medium, "Medium Warrior Water")]
        [InlineData(Size.Large, "Large Warrior Water")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            WarriorWater warriorWater = new WarriorWater();
            warriorWater.Size = size;
            Assert.Equal(warriorWater.ToString(), name);
        }
    }
}
