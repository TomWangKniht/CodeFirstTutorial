using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPCSample.Models
{
    public class CreditCard : BillingDetail
    {
        //public int CreditCardId { get; set; }
        public int CardType { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
    }
}