﻿using Microsoft.EntityFrameworkCore;
using ProductApi.Models.Products;

namespace ProductApi.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

           // modelBuilder.Entity<Product>().HasData(
                               
   
        }
 }   }

