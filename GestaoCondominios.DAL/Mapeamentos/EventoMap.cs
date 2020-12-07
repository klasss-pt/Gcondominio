using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestaoCondominios.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoCondominios.DAL.Mapeamentos
{
    public class EventoMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(e => e.EventoId);
            builder.Property(e => e.Nome).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Data).IsRequired();
            builder.Property(e => e.UtilizadorId).IsRequired();

            builder.HasOne(e => e.Utilizador).WithMany(e => e.Eventos).HasForeignKey(e => e.UtilizadorId);

            builder.ToTable("Eventos");
        }
    }
}
