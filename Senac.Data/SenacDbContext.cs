using Microsoft.EntityFrameworkCore;
using Senac.Core.Models;
using Senac.Data.Configurations;

namespace Senac.Data
{
    public class SenacDbContext : DbContext
    {
        public DbSet<Colaborador> Colaboradores { get; set; }

        public SenacDbContext(DbContextOptions<SenacDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ColaboradorConfiguration());
        }
    }
}