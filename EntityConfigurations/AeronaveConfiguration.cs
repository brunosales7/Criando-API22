using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirlines.Entities;

namespace VoeAirlines.EntityConfigurations
{
    public class AeronaveConfiguration : IEntityTypeConfiguration<Aeronave>
    {
        public void Configure(EntityTypeBuilder<Aeronave> builder)
        {
            builder.ToTable("Aeronave");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Fabricante).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Modelo).IsRequired().HasMaxLength(60);
            builder.Property(x => x.Codigo).IsRequired().HasMaxLength(60);
            builder.HasMany(x => x.Manutencoes).WithOne(x => x.Aeronave).HasForeignKey(x => x.AeronaveId);
            builder.HasMany(x => x.Voos).WithOne(x => x.Aeronave).HasForeignKey(x => x.AeronaveId);
        }
    }
}