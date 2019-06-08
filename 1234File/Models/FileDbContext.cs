using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using _1234File.Models;

namespace _1234File.Models
{
    public class FileDbContext:DbContext
    {
        public DbSet<Fileinfo> Fileinfos { get; set; }
    }
}