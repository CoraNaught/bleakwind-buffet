/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: FriedMiraakTests.cs
 * Purpose: Test the FriedMiraak.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class FriedMiraakTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            Assert.IsAssignableFrom<Side>(friedMiraak);
            Assert.IsAssignableFrom<IOrderItem>(friedMiraak);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            Assert.True(friedMiraak.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            friedMiraak.Size = Size.Large;
            Assert.True(friedMiraak.Size == Size.Large);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            Assert.Equal(friedMiraak.SpecialInstructions, new List<string>());
        }

        [Theory]
        [InlineData(Size.Small, 1.78)]
        [InlineData(Size.Medium, 2.01)]
        [InlineData(Size.Large, 2.88)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            friedMiraak.Size = size;
            Assert.Equal(friedMiraak.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 151)]
        [InlineData(Size.Medium, 236)]
        [InlineData(Size.Large, 306)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            friedMiraak.Size = size;
            Assert.Equal(friedMiraak.Calories, calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Fried Miraak")]
        [InlineData(Size.Medium, "Medium Fried Miraak")]
        [InlineData(Size.Large, "Large Fried Miraak")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            FriedMiraak friedMiraak = new FriedMiraak();
            friedMiraak.Size = size;
            Assert.Equal(friedMiraak.ToString(), name);
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var FM = new FriedMiraak();

            Assert.PropertyChanged(FM, "Size", () =>
            {
                FM.Size = Size.Small;
            });

            Assert.PropertyChanged(FM, "Size", () =>
            {
                FM.Size = Size.Medium;
            });

            Assert.PropertyChanged(FM, "Size", () =>
            {
                FM.Size = Size.Large;
            });
        }
    }
}