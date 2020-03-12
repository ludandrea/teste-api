using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Senac.Core.Models;

namespace Senac.Data.Configurations
{
    public class ColaboradorConfiguration : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.HasKey(m => m.Id);

            // builder.Property(m => m.Id).UseIdentityColumn();

            builder.Property(m => m.Nome).IsRequired().HasMaxLength(200);

            builder.Property(m => m.Indicador).IsRequired();

            builder.Property(m => m.Registro).IsRequired();

            builder.ToTable("Colaboradores");
        }
    }
}