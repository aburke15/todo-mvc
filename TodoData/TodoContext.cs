using System;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;

namespace TodoData
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions options) 
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UserConfiguration());
        }

        public DbSet<User> Users { get; set; }
    }
}