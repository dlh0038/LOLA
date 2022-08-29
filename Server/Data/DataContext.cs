using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LOLA.Shared;

namespace LOLA.Server.Data
{

    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {

        }
        public DbSet<Order> Orders {get; set;}
        public DbSet<User> Users {get; set;}
        
        public DbSet<Restaurant> Restaurants {get; set;}
         //disabled users temporarily

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
            
            
        // }
    }
}