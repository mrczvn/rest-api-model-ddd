using Microsoft.EntityFrameworkCore;
using rest_api_ddd.domain.entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace rest_api_ddd.infrastructure.data
{
    class SqlContext: DbContext
    {
        public SqlContext()
        {

        } 

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
            {
                if(entry.State == EntityState.Added)
                {
                    entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
                }
                if(entry.State == EntityState.Modified)
                {
                    entry.Property("RegistrationDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}
