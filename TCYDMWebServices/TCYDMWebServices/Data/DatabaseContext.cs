using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCYDMWebServices.Models;

namespace TCYDMWebServices.Data
{
    public partial class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Country> countries { get; set; }
        public DbSet<Region> regions { get; set; }
        public DbSet<OnlineQuery> onlinequeries { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Gender> genders { get; set; }
        public DbSet<WhatWeDo> whatwedos { get; set; }
        public DbSet<WhoWeAre> whoweares { get; set; }
        public DbSet<HomePage> homepage { get; set; }
        public DbSet<ContactUs> contactuss { get; set; }
        public DbSet<Langluage> languages { get; set; }
        public DbSet<ServiceInfo> serviceinfos { get; set; }
        public DbSet<PDFClass> pdfbase { get; set; }
        public DbSet<AdminTable> admintables { get; set; } 
        public DbSet<ServiceAddition> serviceadditions { get; set; }
        public DbSet<ServiceAdditionText> serviceadditiontext { get; set; }
        public DbSet<ServiceAdditionNumber> serviceadditionnumber { get; set; }
        public DbSet<ServiceAdditionFile> serviceadditionfile { get; set; }
        public DbSet<VisionMissionValues> visionmissionvalues { get; set; }
        public DbSet<OurTeam> ourteams { get; set; }
        public DbSet<Blog> blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(p => p.Countries)
                .WithMany(b => b.Users);

            modelBuilder.Entity<User>()
                .HasOne(p => p.Regions)
                .WithMany(b => b.Users);
        }
    }
}
