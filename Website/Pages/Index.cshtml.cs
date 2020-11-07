using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BleakwindBuffet.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<IOrderItem> Items { get; set; }
        public string SearchTerms { get; set; }
        public string[] ItemType { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public string CaloriesMinTemp { get; set; }
        private double caloriesMin = 0.0;
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
        public string CaloriesMaxTemp { get; set; }
        private double caloriesMax = 1000.0;
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
        public string PriceMinTemp { get; set; }
        private double priceMin = 0.0;
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
        public string PriceMaxTemp { get; set; }
        private double priceMax = 10.0;
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
            Items = Menu.Search(SearchTerms);
            Items = Menu.FilterByItemType(Items, ItemType);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }
    }
}
