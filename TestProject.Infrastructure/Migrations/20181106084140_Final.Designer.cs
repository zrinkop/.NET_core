﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TestProject.Infrastructure;

namespace TestProject.Infrastructure.Migrations
{
    [DbContext(typeof(TestDbContext))]
    [Migration("20181106084140_Final")]
    partial class Final
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TestProject.Contracts.Entities.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatalogDescription")
                        .IsRequired();

                    b.Property<string>("CatalogName")
                        .IsRequired();

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDateUtc");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDateUtc");

                    b.HasKey("Id");

                    b.ToTable("Catalog");

                    b.HasData(
                        new { Id = 300, CatalogDescription = "Winter 2018", CatalogName = "W2018", CreatedBy = "Zrinko", CreatedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), IsDeleted = false, LastModifiedBy = "Irena", LastModifiedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local) },
                        new { Id = 400, CatalogDescription = "Summer 2018", CatalogName = "S2018", CreatedBy = "Zrinko", CreatedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), IsDeleted = false, LastModifiedBy = "Irena", LastModifiedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("TestProject.Contracts.Entities.CatalogItems", b =>
                {
                    b.Property<int>("ProductId");

                    b.Property<int>("CatalogId");

                    b.HasKey("ProductId", "CatalogId");

                    b.HasAlternateKey("CatalogId", "ProductId");

                    b.ToTable("CatalogItems");
                });

            modelBuilder.Entity("TestProject.Contracts.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("BasePrice");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("CreatedDateUtc");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("LastModifiedBy");

                    b.Property<DateTime>("LastModifiedDateUtc");

                    b.Property<string>("ProductDescription")
                        .IsRequired();

                    b.Property<string>("ProductName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new { Id = 51, BasePrice = 500m, CreatedBy = "Zrinko", CreatedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 416, DateTimeKind.Local), IsDeleted = false, LastModifiedBy = "Irena", LastModifiedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 415, DateTimeKind.Local), ProductDescription = "Running shoes", ProductName = "Nike Pegasus" },
                        new { Id = 52, BasePrice = 400m, CreatedBy = "Edi", CreatedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), IsDeleted = false, LastModifiedBy = "Ozana", LastModifiedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), ProductDescription = "Sport shoes", ProductName = "Nike AirMax" },
                        new { Id = 54, BasePrice = 1000m, CreatedBy = "Kristijan", CreatedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), IsDeleted = false, LastModifiedBy = "Luka", LastModifiedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), ProductDescription = "Sport watch", ProductName = "Garmin Fenix 3" },
                        new { Id = 55, BasePrice = 1050m, CreatedBy = "Kristijan", CreatedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), IsDeleted = false, LastModifiedBy = "Ozren", LastModifiedDateUtc = new DateTime(2018, 11, 6, 9, 41, 40, 417, DateTimeKind.Local), ProductDescription = "Sport watch", ProductName = "Suunto Spartann" }
                    );
                });

            modelBuilder.Entity("TestProject.Contracts.Entities.CatalogItems", b =>
                {
                    b.HasOne("TestProject.Contracts.Entities.Catalog", "Catalog")
                        .WithMany("CatalogItems")
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TestProject.Contracts.Entities.Product", "Product")
                        .WithMany("CatalogItems")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
