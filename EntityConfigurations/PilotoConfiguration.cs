using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VoeAirlines.Entities;

namespace VoeAirlines.EntityConfigurations
{
    public class PilotoConfiguration : IEntityTypeConfiguration<Piloto>
    {
        public void Configure(EntityTypeBuilder<Piloto> builder)
        {
            builder.ToTable("Piloto");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Matricula).IsRequired().HasMaxLength(50);
            builder.HasIndex(x => x.Matricula).IsUnique();
            builder.HasMany(x => x.Voos).WithOne(x => x.Piloto).HasForeignKey(x => x.PilotoId);

        }
    }
}