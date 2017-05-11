using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPHSample.Models
{
    public abstract class BillingDetail
    {
        public int BillingDetailId { get; set; }
        public string Owner { get; set; }
        public string Number { get; set; }
    }
}