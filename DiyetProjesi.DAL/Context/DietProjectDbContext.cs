using DiyetProjesi.DAL.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetProjesi.DAL.Context
{
    public class DietProjectDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<Process> Processes { get; set; }
        public DbSet<Repast> Repasts { get; set; }
        public DbSet<DailyActivity> DailyActivities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=DietProjectDb;Trusted_Connection=True;TrustServerCertificate=True;")
                .UseLazyLoadingProxies(true);
        }

    }
}

