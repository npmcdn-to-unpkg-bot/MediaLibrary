using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AngularTestRunApp.Models
{
    public class AppDBContext : DbContext
    {
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }
    }
}
