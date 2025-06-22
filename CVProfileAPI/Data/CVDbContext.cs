using Microsoft.EntityFrameworkCore;
using CVProfileAPI.Models;

namespace CVProfileAPI.Data
{
    public class CVDbContext : DbContext
    {
        public CVDbContext(DbContextOptions<CVDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
