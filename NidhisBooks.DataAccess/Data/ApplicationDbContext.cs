﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NidhisBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NidhiBookStore.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
         
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CoverType> CoverType { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}
