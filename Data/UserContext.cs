﻿using System;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options) { Database.EnsureCreated();  }

    

    public DbSet<User> Users { get; set; }
    }
}
