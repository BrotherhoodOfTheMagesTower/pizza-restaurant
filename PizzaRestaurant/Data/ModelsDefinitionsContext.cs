using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PizzaRestaurant.Models
{
    public class ModelsDefinitionsContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql("Host=localhost;Database=pizza_db;Username=pizza-admin;Password=pizza");
    }
}