using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace VacantionManager2.Data
{
    public class VacantionManager2DbContext : IdentityDbContext
    {
        public VacantionManager2DbContext(DbContextOptions<VacantionManager2DbContext> options)
            : base(options)
        {
        }
    }
}
