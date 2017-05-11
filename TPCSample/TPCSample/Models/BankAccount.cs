using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TPCSample.Models
{
    public class BankAccount : BillingDetail
    {
        //public int BankAccountId { get; set; }
        public string BankName { get; set; }
        public string Swift { get; set; }
    }
}