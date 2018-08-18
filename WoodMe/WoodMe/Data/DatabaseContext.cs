using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WoodMe.Models;

namespace WoodMe.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<WoodMe.Models.Product> Product { get; set; }

        public DbSet<WoodMe.Models.Customer> Customer { get; set; }

        public DbSet<WoodMe.Models.Discount> Discount { get; set; }

        public DbSet<WoodMe.Models.Order> Order { get; set; }
    }
}
