using DigitalRetailer.Models;
using DigitalRetailer.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DigitalRetailer.Models
{
    public class Effect
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }


        public string ImageUrl { get; set; }
    }
}
