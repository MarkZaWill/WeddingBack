using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WeddingBack.Models
{
    public class PictureDbContext: DbContext
    {
        public PictureDbContext(DbContextOptions<PictureDbContext> options)
                  : base(options)
        { }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
