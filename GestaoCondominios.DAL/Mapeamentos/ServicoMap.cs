﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestaoCondominios.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoCondominios.DAL.Mapeamentos
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.Property(s => s.ServicoId);
            builder.Property(s => s.Nome).IsRequired().HasMaxLength(30);
            builder.Property(s => s.Valor).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.Property(s => s.UtilizadorId).IsRequired();

            builder.HasOne(s => s.Utilizador).WithMany(s => s.Servicos).HasForeignKey(s => s.UtilizadorId);
            builder.HasMany (s => s.ServicoPredios).WithOne(s => s.Servico);

            builder.ToTable("Servicos");
        }
    }
}
