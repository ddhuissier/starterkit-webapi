﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using StarterKit.Domain.Models.Data;

namespace StarterKit.Infrastructure.Data
{
    public partial class StarterKitContext : DbContext
    {
        public StarterKitContext()
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Guitar> Guitars { get; set; }
        public DbSet<Product> Products { get; set; }
        public StarterKitContext(DbContextOptions<StarterKitContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
               new User
               {
                   Id=1,
                   Name = "Me",
               }
           );
            modelBuilder.Entity<Guitar>().HasData(
                new Guitar
                {
                    Id = 1,
                    Model = "Gibson",
                },
                 new Guitar
                 {
                     Id = 2,
                     Model = "Fender",
                 }
            );
            modelBuilder.Entity<Product>().HasData(
               new Product
               {
                   Id = 1,
                   Label = "Fretboard",
               },
                new Product
                {
                    Id = 2,
                    Label = "Trussrod",
                }
           );
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}