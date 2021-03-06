﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Data.Entity;
using RawTorpedo.Models.Support;

namespace RawTorpedo.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Game> Game { get; set; }
        public DbSet<Collection> Collection { get; set; }
        public DbSet<Theme> Theme { get; set; }
        public DbSet<Designer> Designer { get; set; }
        public DbSet<Mechanic> Mechanic { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
    }
}
