using Bistros.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Infrastructure.Persistance
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Food> Foods { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Special> Specials { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
    }
}
