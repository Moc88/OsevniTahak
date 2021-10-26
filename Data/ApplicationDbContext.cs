using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using OsevniTahak.Models;

namespace OsevniTahak.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<OsevniTahak.Models.Crop> Crop { get; set; }
        public DbSet<OsevniTahak.Models.Family> Family { get; set; }
    }
}
