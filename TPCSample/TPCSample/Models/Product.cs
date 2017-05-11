using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPCSample.Models
{
    public abstract class Product
    {
        public int Id { get; set; }
        public string Caption { get; set; }

        public string TypeNumber { get; set; }
        public string Manufacturer { get; set; }
    }
}