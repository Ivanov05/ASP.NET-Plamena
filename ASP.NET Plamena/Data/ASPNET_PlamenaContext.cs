using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NET_Plamena.Models;

namespace ASP.NET_Plamena.Data
{
    public class ASPNET_PlamenaContext : DbContext
    {
        public ASPNET_PlamenaContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json",optional: true, reloadOnChange: true);
            IConfigurationRoot config = builder.Build();
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
        public ASPNET_PlamenaContext (DbContextOptions<ASPNET_PlamenaContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NET_Plamena.Models.Artist> Artist { get; set; } = default!;

        public DbSet<ASP.NET_Plamena.Models.Genre>? Genre { get; set; }

        public DbSet<ASP.NET_Plamena.Models.Song>? Song { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
