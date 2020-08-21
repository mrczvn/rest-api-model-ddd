using Microsoft.EntityFrameworkCore;
using rest_api_ddd.domain.entitys;
using System;
using System.Linq;

namespace rest_api_ddd.infrastructure.data
{
    public class SqlContext : DbContext
    {
        /// <summary>
        ///
        /// </summary>
        public SqlContext()
        {
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="options"></param>
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        /// <summary>
        ///
        /// </summary>
        public DbSet<Client> Clients { get; set; }

        /// <summary>
        ///
        /// </summary>
        public DbSet<Product> Products { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("RegistrationDate") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("RegistrationDate").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("RegistrationDate").IsModified = false;
                }
            }
            return base.SaveChanges();
        }
    }
}