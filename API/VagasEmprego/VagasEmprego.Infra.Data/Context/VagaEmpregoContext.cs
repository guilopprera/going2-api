using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using VagasEmprego.Domain;
using VagasEmprego.Infra.Data.Configurations;

namespace VagasEmprego.Infra.Data.Context
{
    public class VagaEmpregoContext : DbContext
    {
        public VagaEmpregoContext(DbContextOptions<VagaEmpregoContext> option) : base(option) {
        }

        public DbSet<Emprego> Empregos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Configurations

            modelBuilder.ApplyConfiguration(new EmpregosConfiguration());

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}