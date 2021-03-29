using FoodApp.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Data
{
    public class FoodAppDbContext : DbContext
    {
        public FoodAppDbContext(DbContextOptions<FoodAppDbContext> options) : base(options)
        {

        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }
}
