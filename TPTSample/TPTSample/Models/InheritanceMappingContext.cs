using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TPTSample.Models
{
    public class InheritanceMappingContext: DbContext
    {
        public InheritanceMappingContext():base("name=CodeFirstTutorialTPTEntities")
        {

        }
        public DbSet<BillingDetail> BillingDetails { get; set; }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    //如果跟annotation衝到，會以這邊的設定為主
        //    modelBuilder.Entity<BankAccount>().ToTable("BankAccounts2");
        //    modelBuilder.Entity<CreditCard>().ToTable("CreditCards2");
        //}
    }
}