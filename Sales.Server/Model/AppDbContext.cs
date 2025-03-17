using Microsoft.EntityFrameworkCore;
using Sales.Server.Model.Entities;
using System;

namespace Sales.Server.Model
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }
        public DbSet <Users> Users { get; set; }
        public DbSet<UserLogs> UserLog { get; set; }
         

    }
}
