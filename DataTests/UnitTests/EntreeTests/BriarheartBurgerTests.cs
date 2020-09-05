/*
 * Author: Zachery Brunner
 * Mofified By: Corrie Naughton
 * Class: BriarheartBurgerTests.cs
 * Purpose: Test the BriarheartBurger.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class BriarheartBurgerTests
    {
        
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Bun = false;
            Assert.False(briarheartBurger.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Ketchup = false;
            Assert.False(briarheartBurger.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Mustard = false;
            Assert.False(briarheartBurger.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Pickle = false;
            Assert.False(briarheartBurger.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            briarheartBurger.Cheese = false;
            Assert.False(briarheartBurger.Cheese);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Price == 6.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.True(briarheartBurger.Calories == 743);
        }

        [Theory]
        [InlineData(true, true, true, true, true)]
        [InlineData(false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard, bool includePickle, bool includeCheese)
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            List<string> specialInstructions = new List<string>();
            if (!includeBun)
            {
                briarheartBurger.Bun = false;
                specialInstructions.Add("Hold bun");
            }
            if (!includeKetchup)
            {
                briarheartBurger.Ketchup = false;
                specialInstructions.Add("Hold ketchup");
            }
            if (!includeMustard)
            {
                briarheartBurger.Mustard = false;
                specialInstructions.Add("Hold mustard");
            }
            if (!includePickle)
            {
                briarheartBurger.Pickle = false;
                specialInstructions.Add("Hold pickle");
            }
            if (!includeCheese)
            {
                briarheartBurger.Cheese = false;
                specialInstructions.Add("Hold cheese");
            }
            Assert.Equal(briarheartBurger.SpecialInstructions, specialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            Assert.Equal(briarheartBurger.ToString(), "Briarheart Burger");
        }
    }
}