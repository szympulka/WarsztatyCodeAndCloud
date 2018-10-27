using CodeAndCloud.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeAndCloud.Core
{
    public class DataContext : DbContext
    {

        public virtual DbSet<ContactModel> Contacts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=CodeAndCloud;Trusted_Connection=true;");
            optionsBuilder.UseSqlServer(@"Server=tcp:fdsakljfljkasdflk.database.windows.net,1433;Initial Catalog=warsztaty;Persist Security Info=False;User ID=szympulka;Password=P@ssw0rd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
