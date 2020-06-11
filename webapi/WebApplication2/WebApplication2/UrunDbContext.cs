using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2
{
    public class UrunDbContext : DbContext
    {
        public UrunDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Urun> Uruns { get; set; }
    }
}
