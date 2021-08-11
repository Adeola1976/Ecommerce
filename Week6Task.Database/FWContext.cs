using System;
using System.Collections.Generic;
using System.Text;
using Week6Task.Model;
using Microsoft.EntityFrameworkCore;
using System.IO;
using Newtonsoft.Json;


namespace Week6Task.Database
{
    public class FWContext:DbContext
    {

        public FWContext(DbContextOptions<FWContext> options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Shipper> Shipper { get; set; }

        public DbSet<Supplier> Supplier { get; set; } 

        /* protected override void OnModelCreating(ModelBuilder builder)
         {
             var data = File.ReadAllText(@"C:\Users\hp\Desktop\AllProjects\Week6Task\Week6Task.Database\JsonFiles\Address.json");
             var listofUser = JsonConvert.DeserializeObject<List<Customer>> (data);
             builder.Entity<Customer>().HasData(data);

         }*/
    } 
}
