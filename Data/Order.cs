using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
/*
 * Author: Corrie Naughton
 * Class name: Order.cs
 * Purpose: Class used to single order
 */
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;

namespace Data
{
    /// <summary>
    /// the data contained within one order
    /// </summary>
    public class Order : ObservableCollection<IOrderItem>
    {
        /// <summary>
        /// add one item to order
        /// </summary>
        /// <param name="item">the item to add</param>
        /// <returns>the order</returns>
        public ObservableCollection<IOrderItem> Add(IOrderItem item)
        {
            ObservableCollection<IOrderItem> result = this;
            result.Add(item);
            return result;
        }
        /// <summary>
        /// remove one item from order
        /// </summary>
        /// <param name="item">the item to remove</param>
        /// <returns>the order</returns>
        public ObservableCollection<IOrderItem> Remove(IOrderItem item)
        {
            ObservableCollection<IOrderItem> result = this;
            result.Remove(item);
            return result;
        }

        private double salesTaxRate = .12;
        /// <summary>
        /// Sales tax
        /// </summary>
        public double SalesTaxRate
        {
            get => salesTaxRate;
            set
            {
                salesTaxRate = value;
            }
        }
        /// <summary>
        /// order number
        /// </summary>
        public int Number
        {
            get;
        }
        private static int nextOrderNumber = 1;
        /// <summary>
        /// instance of order
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }
        /// <summary>
        /// total before tax
        /// </summary>
        public double Subtotal
        {
            get
            {
                double result = 0;
                foreach(var item in this)
                {
                    result += item.Price;
                }
                return result;
            }
        }
        /// <summary>
        /// the amount of tax paid
        /// </summary>
        public double Tax
        {
            get
            {
                return Subtotal * SalesTaxRate;
            }
        }
        /// <summary>
        /// the total amount paid
        /// </summary>
        public double Total
        {
            get
            {
                return Subtotal + Tax;
            }
        }
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach (IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }

        void CollectionItemChangedListener(object sener, PropertyChangedEventArgs e)
        {
            OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
            OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            OnPropertyChanged(new PropertyChangedEventArgs("Total"));
        }
    }
}
