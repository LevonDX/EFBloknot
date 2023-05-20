using EFBloknot.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFBloknot.Data.Context
{
    public class BloknotDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;" +
                "Initial Catalog=EFBloknotDB; Integrated Security=true;" +
                "TrustServerCertificate=True");

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Record> Records { get; set; }

        public DbSet<City> Cities { get; set; }
    }
}
