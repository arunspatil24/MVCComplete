using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _08Scaffolding.Models
{
    public class CricketDbContext:DbContext
    {
        public DbSet<Cricketer> cricketers { get; set; }
    }
}