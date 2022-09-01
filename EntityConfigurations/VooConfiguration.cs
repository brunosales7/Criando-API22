using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirlines.Entities;

namespace VoeAirlines.EntityConfigurations
{
    public class VooConfiguration : IEntityTypeConfiguration<Voo>
    {
        public void Configure(EntityTypeBuilder<Voo> builder)
        {
            builder.ToTable("Voo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Origem).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Destino).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DataHoraPartida).IsRequired();
            builder.Property(x => x.DataHoraChegada).IsRequired();
            builder.HasOne(x => x.Aeronave).WithMany(x => x.Voos).HasForeignKey(x => x.AeronaveId);
            builder.HasOne(x => x.Piloto).WithMany(x => x.Voos).HasForeignKey(x => x.PilotoId);
            builder.HasOne(x => x.Cancelamento).WithOne(x => x.Voo).HasForeignKey<Cancelamento>(x => x.VooId);
        }
    }
}