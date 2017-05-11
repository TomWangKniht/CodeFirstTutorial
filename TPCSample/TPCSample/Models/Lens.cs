using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPCSample.Models
{
    public class Lens : Product
    {
        public string FocalLength { get; set; }
        public string MaxAperture { get; set; }
    }
}