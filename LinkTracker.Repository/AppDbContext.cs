using LinkTracker.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkTracker.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)  
        {
            
        }

        public DbSet<Domain> Domains { get; set; }
        public DbSet<Link> Links { get; set; }
        public DbSet<LinkDetail> LinkDetails { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<SubAndOtherPage> SubAndOtherPages { get; set; }
        public DbSet<Group> Groups { get; set; }
    }
}
