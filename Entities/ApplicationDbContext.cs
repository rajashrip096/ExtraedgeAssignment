using ExtraedgeAssignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Entities
{
    public class ApplicationDbContext:DbContext
    {
            public ApplicationDbContext(DbContextOptions options) : base(options) { }
             public DbSet<Customer> Customer { get; set; }
        public DbSet<MobileBrand> MobileBrand { get; set; }
        public DbSet<OrderPlace> OrderPlace { get; set; }

    }
}
