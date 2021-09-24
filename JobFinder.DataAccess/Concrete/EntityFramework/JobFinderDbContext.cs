using System;
using JobFinder.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace JobFinder.DataAccess.Concrete.EntityFramework
{
    public class JobFinderDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1433\\Catalog=JobFinderDbContext;Database=JobFinderDbContext;User=sa;Password=someThingComplicated1234;");
        }

        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<JobPost> JobPosts { get; set; }
        public DbSet<Application> Applications { get; set; }
        public DbSet<ApplicationState> ApplicationStates { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<EducationLevel> EducationLevels { get; set; }
        public DbSet<Sector> Sectors { get; set; }
        public DbSet<JobAbility> JobAbilities { get; set; }
        public DbSet<CandidateAbility> CandidateAbilities { get; set; }

    }
}
