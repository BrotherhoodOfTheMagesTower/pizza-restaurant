using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PizzaRestaurant.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaRestaurant.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Account> Account { get; set; }
        //public DbSet<Client> Client { get; set; }
        public DbSet<CompanyCar> CompanyCar { get; set; }
        //public DbSet<ErrorViewModel> ErrorViewModel { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Pizza> Pizza { get; set; }
        public DbSet<Restaurant> Restaurant { get; set; }
        public DbSet<Table> Table { get; set; }
        //public DbSet<Worker> Worker { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Account>().ToTable("account").HasKey(c => c.AccountID);
            //builder.Entity<Client>().ToTable("client").HasKey(c => c.ClientID);
            builder.Entity<CompanyCar>().ToTable("company_car").HasKey(c => c.CarID);
            //builder.Entity<ErrorViewModel>().ToTable("error_view_model").HasKey(c => c.ShowRequestId);
            builder.Entity<Order>().ToTable("order").HasKey(c => c.OrderID);
            builder.Entity<Pizza>().ToTable("pizza").HasKey(c => c.PizzaID);
            builder.Entity<Restaurant>().ToTable("restaurant").HasKey(c => c.RestaurantID);
            builder.Entity<Table>().ToTable("table").HasKey(c => c.TableID);
            //builder.Entity<Worker>().ToTable("worker").HasKey(c => c.WorkerID);

            base.OnModelCreating(builder);
        }
    }
}
