using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mat3m.Models
{
    public class Mat3amContext : DbContext
    {
        public Mat3amContext(DbContextOptions<Mat3amContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Item> Itesm { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Offer> Offer { get; set; }
        public DbSet<ContactUs> ContactUs { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<Supply> Supplies { get; set; }

    }
}