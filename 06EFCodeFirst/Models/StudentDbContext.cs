﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _06EFCodeFirst.Models
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}