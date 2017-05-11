using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPTSample.Models
{
    [Table("CreditCards")]
    public class CreditCard : BillingDetail
    {
        public int CardType { get; set; }
        public string ExpiryMonth { get; set; }
        public string ExpiryYear { get; set; }
    }
}