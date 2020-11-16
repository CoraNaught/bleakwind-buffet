/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: DragonbornWaffleFriesTests.cs
 * Purpose: Test the DragonbornWaffleFries.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class DragonbornWaffleFriesTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<Side>(dragonbornWaffleFries);
            Assert.IsAssignableFrom<IOrderItem>(dragonbornWaffleFries);
        }
        [Fact]
        public void ShouldBeAbleToGetDisciption()
        {
            DragonbornWaffleFries dragonborn = new DragonbornWaffleFries();
            Assert.Equal(dragonborn.Description, "Crispy fried potato waffle fries.");
        }
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dragonbornWaffleFries);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            Assert.True(dragonbornWaffleFries.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            dragonbornWaffleFries.Size = Size.Large;
            Assert.True(dragonbornWaffleFries.Size == Size.Large);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            Assert.Equal(dragonbornWaffleFries.SpecialInstructions, new List<string>());
        }

        [Theory]
        [InlineData(Size.Small, 0.42)]
        [InlineData(Size.Medium, 0.76)]
        [InlineData(Size.Large, 0.96)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            dragonbornWaffleFries.Size = size;
            Assert.True(dragonbornWaffleFries.Price == price);
        }

        [Theory]
        [InlineData(Size.Small, 77)]
        [InlineData(Size.Medium, 89)]
        [InlineData(Size.Large, 100)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            dragonbornWaffleFries.Size = size;
            Assert.True(dragonbornWaffleFries.Calories == calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Dragonborn Waffle Fries")]
        [InlineData(Size.Medium, "Medium Dragonborn Waffle Fries")]
        [InlineData(Size.Large, "Large Dragonborn Waffle Fries")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            dragonbornWaffleFries.Size = size;
            Assert.Equal(dragonbornWaffleFries.ToString(), name);
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var DWF = new DragonbornWaffleFries();

            Assert.PropertyChanged(DWF, "Size", () =>
            {
                DWF.Size = Size.Small;
            });

            Assert.PropertyChanged(DWF, "Size", () =>
            {
                DWF.Size = Size.Medium;
            });

            Assert.PropertyChanged(DWF, "Size", () =>
            {
                DWF.Size = Size.Large;
            });
        }
    }
}