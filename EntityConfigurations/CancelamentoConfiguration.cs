using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirlines.Entities;

namespace VoeAirlines.EntityConfigurations
{
    public class CancelamentoConfiguration : IEntityTypeConfiguration<Cancelamento>
    {
        public void Configure(EntityTypeBuilder<Cancelamento> builder)
        {
            builder.ToTable("Cancelamento");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Motivo).IsRequired().HasMaxLength(50);
            builder.Property(x => x.DataHoraNotificacao).IsRequired();
            builder.Property(x => x.VooId).IsRequired();

        }
    }
}