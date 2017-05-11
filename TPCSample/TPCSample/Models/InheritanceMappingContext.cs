using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TPCSample.Models
{
    public class InheritanceMappingContext : DbContext
    {
        public InheritanceMappingContext() : base("name=CodeFirstTutorialTPCEntities")
        {

        }
        public DbSet<BillingDetail> BillingDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BankAccount>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("BankAccounts");
            });

            modelBuilder.Entity<CreditCard>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("CreditCards");
            });
        }
    }
}