using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PIXIE_PHOTOS.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PIXIE_PHOTOS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet< Photos> Photos { get; set; }

    }
}
