using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _12FileUpload.Models
{
    public class FileUploadDbContext:DbContext
    {
        public DbSet<FileInformation> Fileinformations { get; set; }
    }
}