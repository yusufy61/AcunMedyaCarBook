﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AcunMedyaCarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AcunMedyaCarBook.Persistence.Context
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-C16NFR0;initial Catalog=AcunmedyaCarBookDB;integrated Security=true;TrustServerCertificate=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }

        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }

        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
