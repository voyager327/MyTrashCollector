﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Models;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public object Customers { get; internal set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                     new IdentityRole
                     {
                         Name = "Admin",
                         NormalizedName = "ADMIN"
                     }
                 );
            
        }
        //public DbSet<TrashCollector.Models.Customer> Customers { get; set; } 
        //public DbSet<TrashCollector.Models.Employee> Employees { get; set; }
    
    }
}
