/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: GardenOrcOmeletteTests.cs
 * Purpose: Test the GardenOrcOmelette.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class GardenOrcOmeletteTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            Assert.IsAssignableFrom<Entree>(gardenOrcOmlette);
            Assert.IsAssignableFrom<IOrderItem>(gardenOrcOmlette);
        }
        [Fact]
        public void ShouldInlcudeBroccoliByDefault()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            Assert.True(gardenOrcOmlette.Broccoli);
        }

        [Fact]
        public void ShouldInlcudeMushroomsByDefault()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            Assert.True(gardenOrcOmlette.Mushrooms);
        }

        [Fact]
        public void ShouldInlcudeTomatoByDefault()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            Assert.True(gardenOrcOmlette.Tomato);
        }

        [Fact]
        public void ShouldInlcudeCheddarByDefault()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            Assert.True(gardenOrcOmlette.Cheddar);
        }

        [Fact]
        public void ShouldBeAbleToSetBroccoli()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            gardenOrcOmlette.Broccoli = false;
            Assert.False(gardenOrcOmlette.Broccoli);
        }

        [Fact]
        public void ShouldBeAbleToSetMushrooms()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            gardenOrcOmlette.Mushrooms = false;
            Assert.False(gardenOrcOmlette.Mushrooms);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            gardenOrcOmlette.Tomato = false;
            Assert.False(gardenOrcOmlette.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetCheddar()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            gardenOrcOmlette.Cheddar = false;
            Assert.False(gardenOrcOmlette.Cheddar);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            Assert.True(gardenOrcOmlette.Price == 4.57);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            Assert.True(gardenOrcOmlette.Calories == 404);
        }

        [Theory]
        [InlineData(true, true, true, true)]
        [InlineData(false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBroccoli, bool includeMushrooms,
                                                            bool includeTomato, bool includeCheddar)
        {
            GardenOrcOmlette gardenOrcOmelette = new GardenOrcOmlette();
            List<string> specialInstructions = new List<string>();
            if (!includeBroccoli)
            {
                gardenOrcOmelette.Broccoli = false;
                specialInstructions.Add("Hold broccoli");
            }
            if (!includeMushrooms)
            {
                gardenOrcOmelette.Mushrooms = false;
                specialInstructions.Add("Hold mushrooms");
            }
            if (!includeTomato)
            {
                gardenOrcOmelette.Tomato = false;
                specialInstructions.Add("Hold tomato");
            }
            if (!includeCheddar)
            {
                gardenOrcOmelette.Cheddar = false;
                specialInstructions.Add("Hold cheddar");
            }
            Assert.Equal(gardenOrcOmelette.SpecialInstructions, specialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            Assert.Equal(gardenOrcOmlette.ToString(), "Garden Orc Omelette");
        }
    }
}