using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Metadata;
using System;

namespace RentrAPI.Models
{
    public class UserDbContext
    {

        public UserDbContext(DbContextOptions<UserDbContext> options) 
            : base(options) 
        { 
        }

        public DbSet<User> Users { get; set; }
    }
}
