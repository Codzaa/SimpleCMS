using System;
using Microsoft.EntityFrameworkCore;

namespace cms.Data
{
     public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<CustomPage> CustomPages { get; set; }
    }
    
}