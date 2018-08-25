using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WriteAway.Core.Domain.Files;
using WriteAway.Core.Domain.Users;

namespace WriteAway.Data
{
    public class WriteAwayContext : DbContext
    {

        public WriteAwayContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<UploadedFile> UploadedFiles { get; set; }
        public DbSet<FileType> AllowedFileTypes { get; set; }

    }
}
