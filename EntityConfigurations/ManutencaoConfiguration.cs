using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirlines.Entities;

namespace VoeAirlines.EntityConfigurations
{
    public class ManutencaoConfiguration : IEntityTypeConfiguration<Manutencao>
    {
        public void Configure(EntityTypeBuilder<Manutencao> builder)
        {
            builder.ToTable("Manutencao");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.DataHora).IsRequired();
            builder.Property(x => x.TipoManutencao).IsRequired();
            builder.Property(x => x.Observacao).HasMaxLength(50);
            builder.Property(x => x.AeronaveId);
        }
    }
}