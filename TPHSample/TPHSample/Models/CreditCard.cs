﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPHSample.Models
{
    public class CreditCard : BillingDetail
    {
        public int CardType { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
    }
}