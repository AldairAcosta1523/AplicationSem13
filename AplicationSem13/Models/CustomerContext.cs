using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace AplicationSem13.Models
{
    public class CustomerContext : DbContext
    {

        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

