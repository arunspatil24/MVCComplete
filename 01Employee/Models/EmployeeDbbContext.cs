﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _01Employee.Models
{
    public class EmployeeDbbContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}