using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using DotNetCoreExample.DTO;

namespace DotNetCoreExample.DL
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<UserDto> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=testProj.db");
        }
    }
}