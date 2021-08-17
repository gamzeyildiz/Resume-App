using Microsoft.EntityFrameworkCore;
using ResumeApp.Entities;
using System;

namespace ResumeApp.DataAccess
{    
    public class ResumeDbContext : DbContext
    {
        public ResumeDbContext(DbContextOptions<ResumeDbContext> options) : base(options)
        {


        }
        public ResumeDbContext()
        {


        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB; Database = ResumeDb; Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<Bio> Bios { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Resume> Resume { get; set; }

    }
}  
