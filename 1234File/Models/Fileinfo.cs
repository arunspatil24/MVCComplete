using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1234File.Models
{
    public class Fileinfo
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public byte[] Context { get; set; }
        public byte[] Content { get; internal set; }
    }
}