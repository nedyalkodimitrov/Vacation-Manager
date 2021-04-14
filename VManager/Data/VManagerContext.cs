using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using VManager.Models;
using VManager.ViewModels.Project;

namespace VManager.Data
{
    public class VManagerContext : IdentityDbContext<IdentityUser>
    {
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Role> AppRoles { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual  DbSet<User> AppUsers { get; set; }
        public virtual  DbSet<Vacation> Vacations { get; set; }

        
        public VManagerContext(DbContextOptions<VManagerContext> options)
            : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=VManager;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseLazyLoadingProxies();
        }
        public DbSet<VManager.ViewModels.Project.ListOfProjectsViewModel> ListOfProjectsViewModel { get; set; }
    }
}
