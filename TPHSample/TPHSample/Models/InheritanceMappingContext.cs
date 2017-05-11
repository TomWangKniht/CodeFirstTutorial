using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TPHSample.Models
{
    public class InheritanceMappingContext : DbContext
    {
        public InheritanceMappingContext() : base("name=CodeFirstTutorialTPHEntities")
        {

        }
        public DbSet<BillingDetail> BillingDetails { get; set; }
    }
}