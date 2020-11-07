using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using Xunit;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class MenuTests
    {
        [Fact]
        public void ShouldIncludeAllEntrees()
        {
            IEnumerable<IOrderItem> Entrees = Menu.Entrees();
            Assert.Contains(Entrees, item => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(Entrees, item => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(Entrees, item => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(Entrees, item => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(Entrees, item => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(Entrees, item => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(Entrees, item => { return item.ToString().Equals("Thugs T-Bone"); });
        }

        [Fact]
        public void ShouldIncludeAllDrinks()
        {
            IEnumerable<IOrderItem> Drinks = Menu.Drinks();
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Aretino Apple Juice"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Peach Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Markarth Milk"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(Drinks, item => { return item.ToString().Equals("Large Warrior Water"); });
        }

        [Fact]
        public void ShouldIncludeAllSides()
        {
            IEnumerable<IOrderItem> Sides = Menu.Sides();
            Assert.Contains(Sides, item => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Large Mad Otar Grits"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(Sides, item => { return item.ToString().Equals("Large Vokun Salad"); });
        }
        [Fact]
        public void ShouldIncludeAllMenuItems()
        {
            IEnumerable<IOrderItem> orderItems = Menu.FullMenu();
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Mad Otar Grits"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Vokun Salad"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Thugs T-Bone"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Aretino Apple Juice"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Peach Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Markarth Milk"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Warrior Water"); });
        }
        [Fact]
        public void SearchFunctionShouldReturnCorrectList()
        {
            IEnumerable<IOrderItem> orderItems = Menu.Search("burger");
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Briarheart Burger"); });

        }
        [Fact]
        public void ShouldBeAbleToSetItemType()
        {
            IEnumerable<string> type = new string[] { "Drink" };
            Assert.True(type.Contains( "Drink"));

        }
        [Fact]
        public void SearchFunctionShouldReturnCorrectListNull()
        {
            string term = null;
            IEnumerable<IOrderItem> orderItems = Menu.Search(term);
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Aretino Apple Juice"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Peach Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Watermelon Sailor Soda"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Markarth Milk"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(orderItems, item => { return item.ToString().Equals("Large Warrior Water"); });
        }
        [Fact]
        public void FilterByItemTypeFunctionShouldReturnCorrectListEntree()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<string> type = new string[] { "Entree" };
            IEnumerable<IOrderItem> thing = Menu.FilterByItemType(items, type);
            Assert.Contains(thing, item => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thugs T-Bone"); });
        }
        [Fact]
        public void FilterByItemTypeFunctionShouldReturnCorrectListDrink()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<string> type = new string[] { "Drink" };
            IEnumerable<IOrderItem> thing = Menu.FilterByItemType(items, type);
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Markarth Milk"); });
        }
        [Fact]
        public void FilterByItemTypeFunctionShouldReturnCorrectListSide()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<string> type = new string[] { "Side" };
            IEnumerable<IOrderItem> thing = Menu.FilterByItemType(items, type);
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Fried Miraak"); });
        }
        [Fact]
        public void FilterByItemTypeFunctionShouldReturnCorrectListSideAndEntree()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<string> type = new string[] { "Side", "Entree" };
            IEnumerable<IOrderItem> thing = Menu.FilterByItemType(items, type);
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thugs T-Bone"); });
        }
        [Fact]
        public void FilterByItemTypeFunctionShouldReturnCorrectListSideAndDrink()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<string> type = new string[] { "Side", "Drink" };
            IEnumerable<IOrderItem> thing = Menu.FilterByItemType(items, type);
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Markarth Milk"); });
        }
        [Fact]
        public void FilterByItemTypeFunctionShouldReturnCorrectListSideAndDrinkAndEntree()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<string> type = new string[] { "Side", "Drink", "Entree" };
            IEnumerable<IOrderItem> thing = Menu.FilterByItemType(items, type);
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Vokun Salad"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thugs T-Bone"); });
        }
        [Fact]
        public void FilterByCaloriesShouldReturnCorrectList()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<IOrderItem> thing = Menu.FilterByCalories(items, 0, 20);
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Warrior Water"); });
        }
        [Fact]
        public void FilterByPriceShouldReturnCorrectListToOne()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<IOrderItem> thing = Menu.FilterByPrice(items, 0, 1);
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Warrior Water"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Warrior Water"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Warrior Water"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Dragonborn Waffle Fries"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Aretino Apple Juice"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Aretino Apple Juice"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Candlehearth Coffee"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Vokun Salad"); });
        }
        [Fact]
        public void FilterByPriceShouldReturnCorrectListOneToTwo()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<IOrderItem> thing = Menu.FilterByPrice(items, 1, 2);
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Markarth Milk"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Blackberry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Cherry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Grapefruit Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Lemon Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Peach Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Small Watermelon Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Candlehearth Coffee"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Markarth Milk"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Vokun Salad"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Blackberry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Cherry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Grapefruit Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Lemon Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Peach Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Watermelon Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Aretino Apple Juice"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Candlehearth Coffee"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Markarth Milk"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Mad Otar Grits"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Vokun Salad"); });
        }
        [Fact]
        public void FilterByPriceShouldReturnCorrectListTwoToTen()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<IOrderItem> thing = Menu.FilterByPrice(items, 2, 10);
            Assert.Contains(thing, item => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thugs T-Bone"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Peach Sailor Soda"); });
        }
        [Fact]
        public void FilterByPriceShouldReturnCorrectListNull()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<IOrderItem> thing = Menu.FilterByPrice(items, null, null);
            Assert.Contains(thing, item => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thugs T-Bone"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Peach Sailor Soda"); });
        }
        [Fact]
        public void FilterByCalorieseShouldReturnCorrectListNull()
        {
            IEnumerable<IOrderItem> items = Menu.FullMenu();
            IEnumerable<IOrderItem> thing = Menu.FilterByCalories(items, null, null);
            Assert.Contains(thing, item => { return item.ToString().Equals("Briarheart Burger"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Double Draugr"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Garden Orc Omelette"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Philly Poacher"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Smokehouse Skeleton"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thalmor Triple"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Thugs T-Bone"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Medium Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Fried Miraak"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Blackberry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Cherry Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Grapefruit Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Lemon Sailor Soda"); });
            Assert.Contains(thing, item => { return item.ToString().Equals("Large Peach Sailor Soda"); });
        }
    }
}
