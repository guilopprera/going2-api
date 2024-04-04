
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VagasEmprego.Domain;

namespace VagasEmprego.Infra.Data.Configurations
{
    public class EmpregosConfiguration : IEntityTypeConfiguration<Emprego>
    {
        public void Configure(EntityTypeBuilder<Emprego> builder)
        {
            builder.ToTable("Emprego").HasKey(e => e.Id);
            builder.Property(a => a.Company).HasMaxLength(50).HasColumnType("varchar(50");
            builder.Property(a => a.New).HasColumnType("bit(1)");
            builder.Property(a => a.Featured).HasColumnType("bit(1)");
            builder.Property(a => a.Role).HasMaxLength(50).HasColumnType("varchar(50");
            builder.Property(a => a.Position).HasMaxLength(50).HasColumnType("varchar(50");
            builder.Property(a => a.Role).HasMaxLength(50).HasColumnType("varchar(50");
            builder.Property(a => a.Level).HasMaxLength(50).HasColumnType("varchar(50");
            builder.Property(a => a.PostedAt).HasMaxLength(50).HasColumnType("varchar(50");
            builder.Property(a => a.Contract).HasMaxLength(50).HasColumnType("varchar(50");
            builder.Property(a => a.Location).HasMaxLength(50).HasColumnType("varchar(50");
            builder.Property(a => a.Languages).HasMaxLength(500).HasColumnType("varchar(500");
            builder.Property(a => a.Tools).HasMaxLength(500).HasColumnType("varchar(500");

            //builder.HasData(new Emprego(1, "Photosnap", true, true, "Senior Frontend Developer", "Frontend", "Senior", "1d ago", "Full Time", "USA Only", new List<string> { "HTML", "CSS", "JavaScript" }, null));
        }
    }
}
