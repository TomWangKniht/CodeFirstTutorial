using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TPTSample.Models
{
    [Table("BankAccounts")]
    public class BankAccount : BillingDetail
    {
        public string BankName { get; set; }
        public string Swift { get; set; }
    }
}