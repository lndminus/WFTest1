using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WorkFinder.Models
{
    public class WorkFinderContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<AdPost> AdPosts { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public WorkFinderContext(DbContextOptions<WorkFinderContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
