using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestaoCondominios.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoCondominios.DAL.Mapeamentos
{
    public class AluguerMap : IEntityTypeConfiguration<Aluguer>
    {
        public void Configure(EntityTypeBuilder<Aluguer> builder)
        {
            builder.HasKey(a => a.AlugarId);
            builder.Property(a => a.Valor).IsRequired();
            builder.Property(a => a.MesId).IsRequired();
            builder.Property(a => a.Ano).IsRequired();

            builder.HasOne(a => a.Mes).WithMany(a => a.Alugueres).HasForeignKey(a => a.MesId);
            builder.HasMany(a => a.Pagamentos).WithOne(a => a.Aluguer);

            builder.ToTable("Alugueres");
        }
    }
}
