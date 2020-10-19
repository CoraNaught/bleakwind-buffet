using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Sides;
using System.Collections.Generic;

namespace DataTests
{
    public class CashDrawerView
    {
        [Fact]
        public void AbleToSetChangeValues()
        {
            BleakwindBuffet.Data.CashDrawerView cashDrawer = new BleakwindBuffet.Data.CashDrawerView();
            cashDrawer.Reset();
            cashDrawer.ChangeHundreds = 2;
            Assert.Equal(cashDrawer.ChangeHundreds, 2);
            cashDrawer.ChangeFifties = 2;
            Assert.Equal(cashDrawer.ChangeFifties, 2);
            cashDrawer.ChangeDimes = 2;
            cashDrawer.ChangeFives = 2;
            cashDrawer.ChangeHalfDollars = 2;
            cashDrawer.ChangeNickels = 2;
            cashDrawer.ChangeOnes = 2;
            cashDrawer.ChangePennies = 2;
            cashDrawer.ChangeTens = 2;
            cashDrawer.ChangeTwenties = 2;
            cashDrawer.ChangeTwos = 2;
            Assert.Equal(cashDrawer.ChangeTens, 2);
            Assert.Equal(cashDrawer.ChangeDimes, 2);
            Assert.Equal(cashDrawer.ChangeFives, 2);
            Assert.Equal(cashDrawer.ChangeHalfDollars, 2);
            Assert.Equal(cashDrawer.ChangeOnes, 2);
            Assert.Equal(cashDrawer.ChangePennies, 2);
            Assert.Equal(cashDrawer.ChangeTwos, 2);
            Assert.Equal(cashDrawer.ChangeTwenties, 2);
            Assert.Equal(cashDrawer.ChangeNickels, 2);
            cashDrawer.ChangeTwos = 2;
            Assert.Equal(cashDrawer.ChangeTwos, 2);
        }
        [Fact]
        public void AbleToSetCustomerValues()
        {
            BleakwindBuffet.Data.CashDrawerView cashDrawer = new BleakwindBuffet.Data.CashDrawerView();
            cashDrawer.Reset();
            cashDrawer.CustomerHundreds = 2;
            Assert.Equal(cashDrawer.CustomerHundreds, 2);
            cashDrawer.CustomerFifties = 2;
            Assert.Equal(cashDrawer.CustomerFifties, 2);
            cashDrawer.CustomerDimes = 2;
            cashDrawer.CustomerFives = 2;
            cashDrawer.CustomerHalfDollars = 2;
            cashDrawer.CustomerNickels = 2;
            cashDrawer.CustomerOnes = 2;
            cashDrawer.CustomerPennies = 2;
            cashDrawer.CustomerQuarters = 2;
            cashDrawer.CustomerTens = 2;
            cashDrawer.CustomerTwenties = 2;
            Assert.Equal(cashDrawer.CustomerDimes, 2);
            Assert.Equal(cashDrawer.CustomerFives, 2);
            Assert.Equal(cashDrawer.CustomerHalfDollars, 2);
            Assert.Equal(cashDrawer.CustomerNickels, 2);
            Assert.Equal(cashDrawer.CustomerOnes, 2);
            Assert.Equal(cashDrawer.CustomerPennies, 2);
            Assert.Equal(cashDrawer.CustomerQuarters, 2);
            Assert.Equal(cashDrawer.CustomerTens, 2);
            Assert.Equal(cashDrawer.CustomerTwenties, 2);
            cashDrawer.CustomerTwos = 2;
            Assert.Equal(cashDrawer.CustomerTwos, 2);
        }
        [Fact]
        public void GiveCorrectRemainingAmount()
        {
            BleakwindBuffet.Data.CashDrawerView cashDrawer = new BleakwindBuffet.Data.CashDrawerView();
            cashDrawer.Reset();
            cashDrawer.CustomerOnes = 2;
            Assert.Equal(cashDrawer.UpdateAmount(4), 2);
        }
        [Fact]
        public void GiveCorrectChangeAmount()
        {
            BleakwindBuffet.Data.CashDrawerView cashDrawer = new BleakwindBuffet.Data.CashDrawerView();
            cashDrawer.Reset();
            cashDrawer.CustomerOnes = 4;
            Assert.Equal(cashDrawer.UpdateChange(2), 2);
        }
        [Fact]
        public void GiveCorrectChange()
        {
            BleakwindBuffet.Data.CashDrawerView cashDrawer = new BleakwindBuffet.Data.CashDrawerView();
            cashDrawer.Reset();
            cashDrawer.CustomerOnes = 4;
            double change = cashDrawer.UpdateChange(2);
            cashDrawer.Change(change);
            Assert.Equal(cashDrawer.ChangeTwos, 1);
        }
        [Fact]
        public void AbleToSetValues()
        {
            BleakwindBuffet.Data.CashDrawerView cashDrawer = new BleakwindBuffet.Data.CashDrawerView();
            cashDrawer.Reset();
            cashDrawer.Hundreds = 2;
            Assert.Equal(cashDrawer.Hundreds, 2);
            cashDrawer.Fifties = 2;
            Assert.Equal(cashDrawer.Fifties, 2);
            cashDrawer.Dimes = 2;
            cashDrawer.Fives = 2;
            cashDrawer.HalfDollars = 2;
            cashDrawer.Nickels = 2;
            cashDrawer.Ones = 2;
            cashDrawer.Pennies = 2;
            cashDrawer.Quarters = 2;
            cashDrawer.Tens = 2;
            cashDrawer.Twenties = 2;
            cashDrawer.Twos = 2;
            Assert.Equal(cashDrawer.Twos, 2);
            Assert.Equal(cashDrawer.Dimes, 2);
            Assert.Equal(cashDrawer.Fives, 2);
            Assert.Equal(cashDrawer.HalfDollars, 2);
            Assert.Equal(cashDrawer.Nickels, 2);
            Assert.Equal(cashDrawer.Ones, 2);
            Assert.Equal(cashDrawer.Pennies, 2);
            Assert.Equal(cashDrawer.Quarters, 2);
            Assert.Equal(cashDrawer.Tens, 2);
            Assert.Equal(cashDrawer.Twenties, 2);
        }
        [Fact]
        public void TestFinalize()
        {
            BleakwindBuffet.Data.CashDrawerView cashDrawer = new BleakwindBuffet.Data.CashDrawerView();
            cashDrawer.Reset();
            cashDrawer.FinalizeSale();
        }
        
    }
}
