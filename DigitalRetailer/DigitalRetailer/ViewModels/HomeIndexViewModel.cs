using System.Collections.Generic;
using System;
using DigitalRetailer.Models;
using System.Linq;

namespace DigitalRetailer.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<Laptop> Laptops { get; set; }
        public IEnumerable<Effect> Effects { get; set; }
    }
}
