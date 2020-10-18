using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using Xunit;
using BleakwindBuffet.Data.Sides;
using Data;
using System.ComponentModel;

namespace DataTests.UnitTests
{
    public class ComboTests
    {
        [Fact]
        public void ShouldBeAssignable()
        {
            Combo combo = new Combo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(combo);
            Assert.IsAssignableFrom<IOrderItem>(combo);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            WarriorWater warriorWater = new WarriorWater();
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Combo combo = new Combo();
            combo.Drink = warriorWater;
            combo.Entree = thalmorTriple;
            combo.Side = dragonbornWaffleFries;
            Assert.True(combo.Price == warriorWater.Price+thalmorTriple.Price+dragonbornWaffleFries.Price-1);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            WarriorWater warriorWater = new WarriorWater();
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Combo combo = new Combo();
            combo.Drink = warriorWater;
            combo.Entree = thalmorTriple;
            combo.Side = dragonbornWaffleFries;
            Assert.True(combo.Calories == warriorWater.Calories + thalmorTriple.Calories + dragonbornWaffleFries.Calories);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            DragonbornWaffleFries dragonbornWaffleFries = new DragonbornWaffleFries();
            WarriorWater warriorWater = new WarriorWater();
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Combo combo = new Combo();
            combo.Drink = warriorWater;
            combo.Entree = thalmorTriple;
            combo.Side = dragonbornWaffleFries;
            List<string> instructions = new List<string>();
            instructions.Add(thalmorTriple.ToString());
            foreach (var instruction in thalmorTriple.SpecialInstructions)
            {
                instructions.Add(instruction);
            }
            instructions.Add(warriorWater.ToString());
            foreach (var instruction in warriorWater.SpecialInstructions)
            {
                instructions.Add(instruction);
            }
            instructions.Add(dragonbornWaffleFries.ToString());
            foreach(var instruction in dragonbornWaffleFries.SpecialInstructions)
            {
                instructions.Add(instruction);
            }
            Assert.Equal(combo.SpecialInstructions, instructions);
        }

        [Fact]
        public void ChangingSizeNotifiesDrinkProperty()
        {
            var combo = new Combo();
            var drink = new WarriorWater();
            Combo old = combo;
            combo.Drink = drink;

            Assert.PropertyChanged(combo, "Drink", () =>
            {
                combo.Drink = drink;
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                Assert.True(combo.Price == old.Price + drink.Price);
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                Assert.True(combo.Calories == old.Calories + drink.Calories);
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                old.SpecialInstructions.Add(drink.ToString());
                foreach(var item in drink.SpecialInstructions)
                {
                    old.SpecialInstructions.Add(item);
                }
                Assert.Equal(old.SpecialInstructions, combo.SpecialInstructions);
            });
        }
        [Fact]
        public void ChangingSizeNotifiesEntreeProperty()
        {
            var combo = new Combo();
            var entree = new BriarheartBurger();
            Combo old = combo;
            combo.Entree = entree;

            Assert.PropertyChanged(combo, "Entree", () =>
            {
                combo.Entree = entree;
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                Assert.True(combo.Price == old.Price + entree.Price);
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                Assert.True(combo.Calories == old.Calories + entree.Calories);
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                old.SpecialInstructions.Add(entree.ToString());
                foreach (var item in entree.SpecialInstructions)
                {
                    old.SpecialInstructions.Add(item);
                }
                Assert.Equal(old.SpecialInstructions, combo.SpecialInstructions);
            });
        }
        [Fact]
        public void ChangingSizeNotifiesSideProperty()
        {
            var combo = new Combo();
            var side = new VokunSalad();
            Combo old = combo;
            combo.Side = side;

            Assert.PropertyChanged(combo, "Side", () =>
            {
                combo.Side = side;
            });
            Assert.PropertyChanged(combo, "Price", () =>
            {
                Assert.True(combo.Price == old.Price + side.Price);
            });
            Assert.PropertyChanged(combo, "Calories", () =>
            {
                Assert.True(combo.Calories == old.Calories + side.Calories);
            });
            Assert.PropertyChanged(combo, "SpecialInstructions", () =>
            {
                old.SpecialInstructions.Add(side.ToString());
                foreach (var item in side.SpecialInstructions)
                {
                    old.SpecialInstructions.Add(item);
                }
                Assert.Equal(old.SpecialInstructions, combo.SpecialInstructions);
            });
        }
    }
}
