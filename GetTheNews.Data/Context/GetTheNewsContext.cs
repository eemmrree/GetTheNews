using GetTheNews.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GetTheNews.Data.Context
{
    public class GetTheNewsContext : DbContext
    {

        public GetTheNewsContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connStr = "Server=(localdb)\\mssqllocaldb;Database=GetTheNews;Trusted_Connection=True;";
                optionsBuilder.UseSqlServer(connStr, opt =>
                {
                    opt.EnableRetryOnFailure();
                });
            }
        }
    }
}
