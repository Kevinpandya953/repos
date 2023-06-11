﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Testapp.Models;

namespace Testapp.Data
{
    public partial class testdbContext : DbContext
    {
        public testdbContext()
        {
        }

        public testdbContext(DbContextOptions<testdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductionBrands> ProductionBrands { get; set; }
        public virtual DbSet<ProductionCategories> ProductionCategories { get; set; }
        public virtual DbSet<ProductionProducts> ProductionProducts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductionBrands>(entity =>
            {
                entity.HasKey(e => e.BrandId);

                entity.ToTable("production.brands");

                entity.Property(e => e.BrandId)
                    .HasColumnName("Brand_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandName)
                    .IsRequired()
                    .HasColumnName("Brand_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionCategories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("production.categories");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("Category_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("Category_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductionProducts>(entity =>
            {
                entity.HasKey(e => e.ProductId);

                entity.ToTable("production.products");

                entity.Property(e => e.ProductId)
                    .HasColumnName("Product_Id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BrandId).HasColumnName("Brand_Id");

                entity.Property(e => e.CategoryId).HasColumnName("Category_Id");

                entity.Property(e => e.ListPrice)
                    .HasColumnName("List_Price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ModelYear).HasColumnName("Model_Year");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("Product_Name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithOne(p => p.ProductionProducts)
                    .HasForeignKey<ProductionProducts>(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_production.products_production.brands");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}