using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HRApplication.Models
{
    public class HRContext : DbContext
    {
        public HRContext(DbContextOptions<HRContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<JobPosition> JobPositions { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
