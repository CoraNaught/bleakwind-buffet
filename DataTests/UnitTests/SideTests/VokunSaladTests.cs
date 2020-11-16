/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: VokunSaladTests.cs
 * Purpose: Test the VokunSalad.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.SideTests
{
    public class VokunSaladTests
    {
        [Fact]
        public void ShouldBeASide()
        {
            VokunSalad vokunSalad = new VokunSalad();
            Assert.IsAssignableFrom<Side>(vokunSalad);
            Assert.IsAssignableFrom<IOrderItem>(vokunSalad);
        }
        [Fact]
        public void ShouldBeAbleToGetDisciption()
        {
            VokunSalad vokun = new VokunSalad();
            Assert.Equal(vokun.Description, "A seasonal fruit salad of mellons, berries, mango, grape, apple, and oranges.");
        }
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            VokunSalad vokunSalad = new VokunSalad();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(vokunSalad);
        }
        [Fact]
        public void ShouldBeSmallByDefault()
        {
            VokunSalad vokunSalad = new VokunSalad();
            Assert.Equal(vokunSalad.Size, Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            VokunSalad vokunSalad = new VokunSalad();
            vokunSalad.Size = Size.Large;
            Assert.Equal(vokunSalad.Size, Size.Large);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            VokunSalad vokunSalad = new VokunSalad();
            Assert.Equal(vokunSalad.SpecialInstructions, new List<string>());
        }

        [Theory]
        [InlineData(Size.Small, 0.93)]
        [InlineData(Size.Medium, 1.28)]
        [InlineData(Size.Large, 1.82)]
        public void ShouldReturnCorrectPriceBasedOnSize(Size size, double price)
        {
            VokunSalad vokunSalad = new VokunSalad();
            vokunSalad.Size = size;
            Assert.Equal(vokunSalad.Price, price);
        }

        [Theory]
        [InlineData(Size.Small, 41)]
        [InlineData(Size.Medium, 52)]
        [InlineData(Size.Large, 73)]
        public void ShouldReturnCorrectCaloriesBasedOnSize(Size size, uint calories)
        {
            VokunSalad vokunSalad = new VokunSalad();
            vokunSalad.Size = size;
            Assert.Equal(vokunSalad.Calories, calories);
        }

        [Theory]
        [InlineData(Size.Small, "Small Vokun Salad")]
        [InlineData(Size.Medium, "Medium Vokun Salad")]
        [InlineData(Size.Large, "Large Vokun Salad")]
        public void ShouldReturnCorrectToStringBasedOnSize(Size size, string name)
        {
            VokunSalad vokunSalad = new VokunSalad();
            vokunSalad.Size = size;
            Assert.Equal(vokunSalad.ToString(), name);
        }
        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var VS = new VokunSalad();

            Assert.PropertyChanged(VS, "Size", () =>
            {
                VS.Size = Size.Small;
            });

            Assert.PropertyChanged(VS, "Size", () =>
            {
                VS.Size = Size.Medium;
            });

            Assert.PropertyChanged(VS, "Size", () =>
            {
                VS.Size = Size.Large;
            });
        }
    }
}