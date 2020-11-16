/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: CandlehearthCoffeeTests.cs
 * Purpose: Test the CandlehearthCoffee.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.DrinkTests
{
    public class CandlehearthCoffeeTests
    {
        [Fact]
        public void ShouldBeADrink()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.IsAssignableFrom<Drink>(candlehearthCoffee);
            Assert.IsAssignableFrom<IOrderItem>(candlehearthCoffee);
        }
        [Fact]
        public void ShouldBeAbleToGetDisciption()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.Equal(candlehearthCoffee.Description, "Fair trade, fresh ground dark roast coffee.");
        }
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(candlehearthCoffee);
        }
        [Fact]
        public void ShouldNotIncludeIceByDefault()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.False(candlehearthCoffee.Ice);
        }

        [Fact]
        public void ShouldNotBeDecafByDefault()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.False(candlehearthCoffee.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.False(candlehearthCoffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            Assert.True(candlehearthCoffee.Size == Size.Small);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Ice = true;
            Assert.True(candlehearthCoffee.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Decaf = true;
            Assert.True(candlehearthCoffee.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.RoomForCream = true;
            Assert.True(candlehearthCoffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Size = Size.Medium;
            Assert.True(candlehearthCoffee.Size == Size.Medium);
        }

        [Theory]
        [InlineData(Size.Small, 0.75)]
        [InlineData(Size.Medium, 1.25)]
        [InlineData(Size.Large, 1.75)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Size = size;
            Assert.True(candlehearthCoffee.Price == price);
        }

        [Theory]
        [InlineData(Size.Small, 7)]
        [InlineData(Size.Medium, 10)]
        [InlineData(Size.Large, 20)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint cal)
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Size = size;
            Assert.True(candlehearthCoffee.Calories == cal);
        }

        [Theory]
        [InlineData(true, true)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(false, false)]
        public void ShouldHaveCorrectSpecialInstructions(bool includeIce, bool includeCream)
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            if (includeIce && includeCream)
            {
                candlehearthCoffee.Ice = true;
                candlehearthCoffee.RoomForCream = true;
                Assert.Equal(candlehearthCoffee.SpecialInstructions, new List<string> { "Add ice","Add cream" });
            }
            else if (includeIce)
            {
                candlehearthCoffee.Ice = true;
                Assert.Equal(candlehearthCoffee.SpecialInstructions, new List<string> { "Add ice" });
            }
            else if(includeCream)
            {
                candlehearthCoffee.RoomForCream = true;
                Assert.Equal(candlehearthCoffee.SpecialInstructions, new List<string> { "Add cream" });
            }
            else
            {
                Assert.Equal(candlehearthCoffee.SpecialInstructions, new List<string>());
            }
        }

        [Theory]
        [InlineData(true, Size.Small, "Small Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Medium, "Medium Decaf Candlehearth Coffee")]
        [InlineData(true, Size.Large, "Large Decaf Candlehearth Coffee")]
        [InlineData(false, Size.Small, "Small Candlehearth Coffee")]
        [InlineData(false, Size.Medium, "Medium Candlehearth Coffee")]
        [InlineData(false, Size.Large, "Large Candlehearth Coffee")]
        public void ShouldReturnCorrectToStringBasedOnSize(bool decaf, Size size, string name)
        {
            CandlehearthCoffee candlehearthCoffee = new CandlehearthCoffee();
            candlehearthCoffee.Size = size;
            candlehearthCoffee.Decaf = decaf;
            Assert.Equal(candlehearthCoffee.ToString(), name);
        }

        [Fact]
        public void ChangingIceNotifiesIceProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "Ice", () =>
            {
                CC.Ice = true;
            });

            Assert.PropertyChanged(CC, "Ice", () =>
            {
                CC.Ice = false;
            });
        }

        [Fact]
        public void ChangingDecafNotifiesDecafProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "Decaf", () =>
            {
                CC.Decaf = true;
            });

            Assert.PropertyChanged(CC, "Decaf", () =>
            {
                CC.Decaf = false;
            });
        }

        [Fact]
        public void ChangingRoomForCreamNotifiesRoomForCreamProperty()
        {
            var CC = new CandlehearthCoffee();

            Assert.PropertyChanged(CC, "Room for Cream", () =>
            {
                CC.RoomForCream = true;
            });

            Assert.PropertyChanged(CC, "Room for Cream", () =>
            {
                CC.RoomForCream = false;
            });
        }

        [Fact]
        public void ChangingSizeNotifiesSizeProperty()
        {
            var AJ = new AretinoAppleJuice();

            Assert.PropertyChanged(AJ, "Size", () =>
            {
                AJ.Size = Size.Small;
            });

            Assert.PropertyChanged(AJ, "Size", () =>
            {
                AJ.Size = Size.Medium;
            });

            Assert.PropertyChanged(AJ, "Size", () =>
            {
                AJ.Size = Size.Large;
            });
        }
    }
}
