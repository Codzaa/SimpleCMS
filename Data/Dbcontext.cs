using System;
using Microsoft.EntityFrameworkCore;

namespace cms.Data
{
     public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<CustomPage>? CustomPages { get; set; }
        public DbSet<CustomUser>? CustomUsers {get;set;}
        public DbSet<CustomSite>? CustomSites {get;set;}
    }
    
}