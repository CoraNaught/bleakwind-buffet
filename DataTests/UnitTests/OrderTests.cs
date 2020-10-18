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
    public class OrderTests
    {
        [Fact]
        public void AddToOrder()
        {
            Order order = new Order();
            BriarheartBurger briarheart = new BriarheartBurger();
            order.Add(briarheart);
            Assert.Contains(briarheart, order);
        }
        [Fact]
        public void RemoveFromOrder()
        {
            Order order = new Order();

            CandlehearthCoffee coffee = new CandlehearthCoffee();
            order.Add(coffee);
            order.Remove(coffee);
            Assert.Empty(order);
        }
        [Fact]
        public void CorrectProprties()
        {
            Order order = new Order();
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            order.Add(coffee);
            coffee.Decaf = true;
            coffee.RoomForCream = true;
            Assert.Contains(coffee, order);
        }
        [Fact]
        public void CorrectSizeChange()
        {
            Order order = new Order();
            CandlehearthCoffee coffee = new CandlehearthCoffee();
            order.Add(coffee);
            coffee.Decaf = true;
            coffee.Size = Size.Large;
            Assert.Contains(coffee, order);
        }
        [Fact]
        public void OrderPropertiesChange()
        {
            var order = new Order();
            var drink = new WarriorWater();
            double tax = .1;
            order.SalesTaxRate = tax;
            order.Add(drink);
            drink.Size = Size.Large;

            Assert.Equal(order.Subtotal, drink.Price);
            Assert.True(order.Tax == drink.Price*order.SalesTaxRate);
            Assert.True(order.Total == drink.Price+drink.Price*order.SalesTaxRate);
            Assert.True(drink.Calories == 0);
        }
    }
}
