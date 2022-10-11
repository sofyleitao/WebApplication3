using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Data
{
    public class DJContext : DbContext
    {
        public DJContext(DbContextOptions<DJContext> options) : base(options)
        {
        }
        public DbSet<Gig> Gig { get; set; }
        public DbSet<DJ> DJ { get; set; }
        public DbSet<Venue> Venue { get; set; }
    }
}

