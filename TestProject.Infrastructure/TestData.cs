using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TestProject.Contracts.Entities;

namespace TestProject.Infrastructure
{
    class TestData
    {
        public static void SeedProducts(ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new
                {
                    Id = 51,
                    ProductName = "Nike Pegasus",
                    ProductDescription = "Running shoes",
                    BasePrice = 500m,
                    CreatedBy = "Zrinko",
                    LastModifiedBy = "Irena",
                    IsDeleted = false,
                    LastModifiedDateUtc = System.DateTime.Now,
                    CreatedDateUtc = System.DateTime.Now
                });
            builder.Entity<Product>().HasData(
                new
                {
                    Id = 52,
                    ProductName = "Nike AirMax",
                    ProductDescription = "Sport shoes",
                    BasePrice = 400m,
                    CreatedBy = "Edi",
                    LastModifiedBy = "Ozana",
                    IsDeleted = false,
                    LastModifiedDateUtc = System.DateTime.Now,
                    CreatedDateUtc = System.DateTime.Now
                });
            builder.Entity<Product>().HasData(
                new
                {
                    Id = 54,
                    ProductName = "Garmin Fenix 3",
                    ProductDescription = "Sport watch",
                    BasePrice = 1000m,
                    CreatedBy = "Kristijan",
                    LastModifiedBy = "Luka",
                    IsDeleted = false,
                    LastModifiedDateUtc = System.DateTime.Now,
                    CreatedDateUtc = System.DateTime.Now
                });
            builder.Entity<Product>().HasData(
                 new
                 {
                     Id = 55,
                     ProductName = "Suunto Spartann",
                     ProductDescription = "Sport watch",
                     BasePrice = 1050m,
                     CreatedBy = "Kristijan",
                     LastModifiedBy = "Ozren",
                     IsDeleted = false,
                     LastModifiedDateUtc = System.DateTime.Now,
                     CreatedDateUtc = System.DateTime.Now
                 });
        }

        public static void SeedCatalogs(ModelBuilder builder)
        {
            builder.Entity<Catalog>().HasData(
                new
                {
                    Id = 333,
                    CatalogName = "W2018",
                    CatalogDescription = "Winter 2018",
                    CreatedBy = "Zrinko",
                    LastModifiedBy = "Irena",
                    IsDeleted = false,
                    LastModifiedDateUtc = System.DateTime.Now,
                    CreatedDateUtc = System.DateTime.Now
                });
            builder.Entity<Catalog>().HasData(
                new
                {
                    Id = 444,
                    CatalogName = "S2018",
                    CatalogDescription = "Summer 2018",
                    CreatedBy = "Zrinko",
                    LastModifiedBy = "Irena",
                    IsDeleted = false,
                    LastModifiedDateUtc = System.DateTime.Now,
                    CreatedDateUtc = System.DateTime.Now
                });
        }
    }
}
