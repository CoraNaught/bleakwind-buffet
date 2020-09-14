/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: SmokehouseSkeletonTests.cs
 * Purpose: Test the SmokehouseSkeleton.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class SmokehouseSkeletonTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.IsAssignableFrom<Entree>(smokehouseSkeleton);
            Assert.IsAssignableFrom<IOrderItem>(smokehouseSkeleton);
        }
        [Fact]
        public void ShouldInlcudeSausageByDefault()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.SausageLink);
        }

        [Fact]
        public void ShouldInlcudeEggByDefault()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.Egg);
        }

        [Fact]
        public void ShouldInlcudeHashbrownsByDefault()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.HashBrowns);
        }

        [Fact]
        public void ShouldInlcudePancakeByDefault()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.PanCake);
        }

        [Fact]
        public void ShouldBeAbleToSetSausage()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            smokehouseSkeleton.SausageLink = false;
            Assert.False(smokehouseSkeleton.SausageLink);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            smokehouseSkeleton.Egg = false;
            Assert.False(smokehouseSkeleton.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetHashbrowns()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            smokehouseSkeleton.HashBrowns = false;
            Assert.False(smokehouseSkeleton.HashBrowns);
        }

        [Fact]
        public void ShouldBeAbleToSetPancake()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            smokehouseSkeleton.PanCake = false;
            Assert.False(smokehouseSkeleton.PanCake);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.Price == 5.62);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.True(smokehouseSkeleton.Calories == 602);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeSausage, bool includeEgg,
                                                            bool includeHashbrowns, bool includePancake)
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            List<string> specialInstructions = new List<string>();
            if (!includeSausage)
            {
                smokehouseSkeleton.SausageLink = false;
                specialInstructions.Add("Hold sausage");
            }
            if (!includeEgg)
            {
                smokehouseSkeleton.Egg = false;
                specialInstructions.Add("Hold eggs");
            }
            if (!includeHashbrowns)
            {
                smokehouseSkeleton.HashBrowns = false;
                specialInstructions.Add("Hold hash browns");
            }
            if (!includePancake)
            {
                smokehouseSkeleton.PanCake = false;
                specialInstructions.Add("Hold pancakes");
            }
            Assert.Equal(smokehouseSkeleton.SpecialInstructions, specialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            Assert.Equal(smokehouseSkeleton.ToString(), "Smokehouse Skeleton");
        }
    }
}