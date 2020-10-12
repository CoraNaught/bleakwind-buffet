/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: MadOtarGritsTests.cs
 * Purpose: Test the MadOtarGrits.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class MadOtarGritsTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            Assert.IsAssignableFrom<Side>(madOtarGrits);
            Assert.IsAssignableFrom<IOrderItem>(madOtarGrits);
        }
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(madOtarGrits);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            Assert.True(madOtarGrits.Size == Size.Small);
        }
                
        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            madOtarGrits.Size = Size.Large;
            Assert.True(madOtarGrits.Size == Size.Large);
        }

        [Fact]
        public void ShouldReturnCorrectStringOnSpecialInstructions()
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            Assert.Equal(madOtarGrits.SpecialInstructions, new List<string>());
        }

        [Theory]
        [InlineData(Size.Small, 1.22)]
        [InlineData(Size.Medium, 1.58)]
        [InlineData(Size.Large, 1.93)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            madOtarGrits.Size = size;
            Assert.Equal(madOtarGrits.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 105)]
        [InlineData(Size.Medium, 142)]
        [InlineData(Size.Large, 179)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            madOtarGrits.Size = size;
            Assert.Equal(madOtarGrits.Calories, calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Mad Otar Grits")]
        [InlineData(Size.Medium, "Medium Mad Otar Grits")]
        [InlineData(Size.Large, "Large Mad Otar Grits")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            MadOtarGrits madOtarGrits = new MadOtarGrits();
            madOtarGrits.Size = size;
            Assert.Equal(madOtarGrits.ToString(), name);
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var MOG = new MadOtarGrits();

            Assert.PropertyChanged(MOG, "Size", () =>
            {
                MOG.Size = Size.Small;
            });

            Assert.PropertyChanged(MOG, "Size", () =>
            {
                MOG.Size = Size.Medium;
            });

            Assert.PropertyChanged(MOG, "Size", () =>
            {
                MOG.Size = Size.Large;
            });
        }
    }
}