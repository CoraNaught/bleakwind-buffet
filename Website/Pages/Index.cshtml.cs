/*
 * Author: Corrie Naughton
 * Class: Index.cshtml.cs
 * Purpose: Filters the menu that will be displayed
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace Website.Pages
{
    /// <summary>
    /// Filters the search list
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        /// <summary>
        /// The list of IOrderItems that fit the filters
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; set; }
        /// <summary>
        /// The string the list of items is being filtered with
        /// </summary>
        public string SearchTerms { get; set; }
        /// <summary>
        /// The type of items we are filtering with
        /// </summary>
        public string[] ItemType { get; set; }
        /// <summary>
        /// logger
        /// </summary>
        /// <param name="logger"></param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// temp value for calories min
        /// </summary>
        public string CaloriesMinTemp { get; set; }
        private double caloriesMin = 0.0;
        /// <summary>
        /// bottom filter for calories
        /// </summary>
        public double CaloriesMin {
            get
            {
                return caloriesMin;
            }
            set
            {
                caloriesMin = value;
            }
        }
        /// <summary>
        /// temp value for calories max
        /// </summary>
        public string CaloriesMaxTemp { get; set; }
        private double caloriesMax = 1000.0;
        /// <summary>
        /// top filter for calories
        /// </summary>
        public double CaloriesMax {
            get
            {
                return caloriesMax;
            }
            set
            {
                caloriesMax = value;
            }
        }
        /// <summary>
        /// temp value for pice min
        /// </summary>
        public string PriceMinTemp { get; set; }
        private double priceMin = 0.0;
        /// <summary>
        /// bottom filter for price
        /// </summary>
        public double PriceMin
        {
            get
            {
                return priceMin;
            }
            set
            {
                priceMin = value;
            }
        }
        /// <summary>
        /// temp value for pice max
        /// </summary>
        public string PriceMaxTemp { get; set; }
        private double priceMax = 10.0;
        /// <summary>
        /// top filter for price
        /// </summary>
        public double PriceMax
        {
            get
            {
                return priceMax;
            }
            set
            {
                priceMax = value;
            }
        }
        /// <summary>
        /// retrieves filters and handles the filtering
        /// </summary>
        public void OnGet()
        {
            SearchTerms = Request.Query["SearchTerms"];
            ItemType = Request.Query["ItemType"];
            CaloriesMinTemp = Request.Query["CaloriesMin"];
            CaloriesMaxTemp = Request.Query["CaloriesMax"];
            PriceMinTemp = Request.Query["PriceMin"];
            PriceMaxTemp = Request.Query["PriceMax"];
            if (CaloriesMinTemp != null && !CaloriesMinTemp.Equals(""))
            {
               CaloriesMin = double.Parse(CaloriesMinTemp);
            }
            if (CaloriesMaxTemp != null && !CaloriesMaxTemp.Equals(""))
            {
               CaloriesMax = double.Parse(CaloriesMaxTemp);
            }
            if (PriceMinTemp != null && !PriceMinTemp.Equals(""))
            {
                PriceMin = double.Parse(PriceMinTemp);
            }
            if (PriceMaxTemp != null && !PriceMaxTemp.Equals(""))
            {
                PriceMax = double.Parse(PriceMaxTemp);
            }
            Items = Menu.FullMenu();
            // Search movie titles for the SearchTerms
            if (SearchTerms != null)
            {
                var searchterms = SearchTerms.Split(' ').ToList();
                Items = Items
                    .Where(x => searchterms.Any(y => x.ToString().Contains(y, StringComparison.InvariantCultureIgnoreCase) || x.Description.Contains(y, StringComparison.InvariantCultureIgnoreCase)));
            }
            Items = Menu.FilterByItemType(Items, ItemType);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
