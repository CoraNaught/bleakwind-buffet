using System;
using System.Collections.Generic;
using System.ComponentModel;
using RoundRegister;

namespace BleakwindBuffet.Data
{
    public class CashDrawerView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void FinalizeSale()
        {
            RoundRegister.CashDrawer.OpenDrawer();
        }
        public void Reset()
        {
            RoundRegister.CashDrawer.ResetDrawer();
        }
        public void Change(double amount)
        {
            while(amount > 0)
            {
                ChangeHundreds = (int)Math.Floor(amount / 100);
                amount -= ChangeHundreds * 100;
                ChangeFifties -= (int)Math.Floor(amount / 50);
                amount -= ChangeFifties * 50;
                ChangeTwenties = (int)Math.Floor(amount / 20);
                amount -= ChangeTwenties * 20;
                ChangeTens = (int)Math.Floor(amount / 10);
                amount -= ChangeTens * 10;
                ChangeFives = (int)Math.Floor(amount / 5);
                amount -= ChangeFives * 5;
                ChangeTwos = (int)Math.Floor(amount / 2);
                amount -= ChangeTwos * 2;
                ChangeOnes = (int)Math.Floor(amount / 1);
                amount -= ChangeOnes * 1;
                ChangeHalfDollars= (int)Math.Floor(amount / .5);
                amount -= ChangeHalfDollars * .5;
                ChangeQuarters = (int)Math.Floor(amount / .25);
                amount -= ChangeQuarters * .25;
                ChangeDimes = (int)Math.Floor(amount / .1);
                amount -= ChangeDimes * .1;
                ChangeNickels = (int)Math.Floor(amount / .05);
                amount -= ChangeNickels * .05;
                ChangePennies = (int)Math.Floor(amount / .01);
                amount -= ChangePennies * .01;
            }
        }
        public double UpdateAmount(double amount)
        {
            amount -= CustomerHundreds*100 + CustomerFifties*50 + CustomerTwenties*20 + CustomerTens*10 + CustomerFives*5 + CustomerTwos*2 + CustomerOnes + CustomerHalfDollars*.5 + CustomerQuarters*.25 + CustomerNickels*.05 + CustomerDimes*.1 + CustomerPennies * .01;
            if (amount < 0)
            {
                return 0;
            }
            else
            {
                return amount;
            }
        }
        public double UpdateChange(double amount)
        {
            amount -= CustomerHundreds * 100 + CustomerFifties * 50 + CustomerTwenties * 20 + CustomerTens * 10 + CustomerFives * 5 + CustomerTwos * 2 + CustomerOnes + CustomerHalfDollars * .5 + CustomerQuarters * .25 + CustomerNickels * .05 + CustomerDimes * .1 + CustomerPennies * .01;
            if (amount < 0)
            {
                return 0-amount;
            }
            else
            {
                return 0;
            }
        }
        private int hundreds;
        public int Hundreds
        {
            get
            {
                return RoundRegister.CashDrawer.Hundreds;
            }
            set
            {
                RoundRegister.CashDrawer.Hundreds = value;
            }
        }
        public int CustomerHundreds
        {
            get; set;
        }

        public int ChangeHundreds
        {
            get; set;
        }
        public int Fifties
        {
            get
            {
                return RoundRegister.CashDrawer.Fifties;
            }
            set
            {
                RoundRegister.CashDrawer.Fifties = value;
            }
        }
        public int CustomerFifties
        {
            get; set;
        }
        public int ChangeFifties
        {
            get;set;
        }
        public int Twenties
        {
            get
            {
                return RoundRegister.CashDrawer.Twenties;
            }
            set
            {
                RoundRegister.CashDrawer.Twenties = value;
            }
        }
        public int CustomerTwenties
        {
            get;set;
        }
        public int ChangeTwenties
        {
            get;set;
        }
        public int Tens
        {
            get
            {
                return RoundRegister.CashDrawer.Tens;
            }
            set
            {
                RoundRegister.CashDrawer.Tens = value;
            }
        }
        public int CustomerTens
        {
            get;set;
        }
        public int ChangeTens
        {
            get;set;
        }
        public int Fives
        {
            get
            {
                return RoundRegister.CashDrawer.Fives;
            }
            set
            {
                RoundRegister.CashDrawer.Fives = value;
            }
        }
        public int CustomerFives
        {
            get; set;
        }
        public int ChangeFives
        {
            get; set;
        }
        public int Twos
        {
            get
            {
                return RoundRegister.CashDrawer.Twos;
            }
            set
            {
                RoundRegister.CashDrawer.Twos = value;
            }
        }
        public int ChangeTwos
        {
            get;set;
        }
        public int CustomerTwos
        {
            get;set;
        }
        public int Ones
        {
            get
            {
                return RoundRegister.CashDrawer.Ones;
            }
            set
            {
                RoundRegister.CashDrawer.Ones = value;
            }
        }
        public int ChangeOnes
        {
            get;set;
        }
        public int CustomerOnes
        {
            get;set;
        }
        public int HalfDollars
        {
            get
            {
                return RoundRegister.CashDrawer.HalfDollars;
            }
            set
            {
                RoundRegister.CashDrawer.HalfDollars = value;
            }
        }
        public int CustomerHalfDollars
        {
            get;set;
        }
        public int ChangeHalfDollars
        {
            get;set;
        }
        public int Quarters
        {
            get
            {
                return RoundRegister.CashDrawer.Quarters;
            }
            set
            {
                RoundRegister.CashDrawer.Quarters = value;
            }
        }
        public int CustomerQuarters
        {
            get;set;
        }
        public int ChangeQuarters
        {
            get;set;
        }
        public int Dimes
        {
            get
            {
                return RoundRegister.CashDrawer.Dimes;
            }
            set
            {
                RoundRegister.CashDrawer.Dimes = value;
            }
        }
        public int CustomerDimes
        {
            get;set;
        }
        public int ChangeDimes
        {
            get;set;
        }
        public int Nickels
        {
            get
            {
                return RoundRegister.CashDrawer.Nickels;
            }
            set
            {
                RoundRegister.CashDrawer.Nickels = value;
            }
        }
        public int CustomerNickels
        {
            get;set;
        }
        public int ChangeNickels
        {
            get;set;
        }
        public int Pennies
        {
            get
            {
                return RoundRegister.CashDrawer.Pennies;
            }
            set
            {
                RoundRegister.CashDrawer.Pennies = value;
            }
        }
        public int CustomerPennies
        {
            get;set;
        }
        public int ChangePennies
        {
            get;set;
        }
    }
}
