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
    }
}
