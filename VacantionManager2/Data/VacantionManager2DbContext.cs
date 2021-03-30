using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VacantionManager2.Models;

namespace VacantionManager2.Data
{
    public class VacantionManager2DbContext : IdentityDbContext
    {
        public VacantionManager2DbContext(DbContextOptions<VacantionManager2DbContext> options)
            : base(options)
        {
        }
        public DbSet<VacantionManager2.Models.UserApplication> User { get; set; }

    }
}
