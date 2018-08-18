using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WoodMe.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext (DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<WoodMe.Models.Product> Product { get; set; }
    }
}
