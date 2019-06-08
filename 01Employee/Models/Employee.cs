using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _01Employee.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Dob { get; set; }
        public long Mobile { get; set; }
    }
}