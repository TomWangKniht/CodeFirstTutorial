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

        public virtual DbSet<Camera> Cameras { get; set; }
        public virtual DbSet<SingleReflexCamera> SingleReflexCameras { get; set; }
        public virtual DbSet<Lens> Lenses { get; set; }
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

            //modelBuilder.Entity<Product>();

            modelBuilder.Entity<Camera>()
                .Map(m => m.MapInheritedProperties().ToTable("Cameras"));

            modelBuilder.Entity<SingleReflexCamera>().Map(m => m.MapInheritedProperties().ToTable("SingleReflexCameras"));

            modelBuilder.Entity<Lens>().Map(m => m.MapInheritedProperties().ToTable("Lenses"));

        }
    }
}