using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_02_09_new
{
    internal class ApplicationContext:DbContext
    {

        public DbSet<Company> Companies { get; set; }
        public DbSet<Shop> Shops { get; set; }

        public DbSet<Buyer> Buyers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-R3LQDV9;Database = testDB1;Trusted_Connection =True;TrustServerCertificate=True");
        }
    }
}
