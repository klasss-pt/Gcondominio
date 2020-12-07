using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestaoCondominios.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoCondominios.DAL.Mapeamentos
{
    public class UtilizadorMap : IEntityTypeConfiguration<Utilizador>
    {
        public void Configure(EntityTypeBuilder<Utilizador> builder)
        {
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
            builder.Property(u => u.Contribuinte).IsRequired().HasMaxLength(30);
            builder.HasIndex(u => u.Contribuinte).IsUnique();
            builder.Property(u => u.Foto).IsRequired();
            builder.Property(u => u.PrimeiroAcesso).IsRequired();
            builder.Property(u => u.Status).IsRequired();

            builder.HasMany(u => u.ProprietariosApartamentos).WithOne(u => u.Proprietario);
            builder.HasMany(u => u.MoradoresApartamentos).WithOne(u => u.Morador);
            builder.HasMany(u => u.Veiculos).WithOne(u => u.Utilizador);
            builder.HasMany(u => u.Eventos).WithOne(u => u.Utilizador);
            builder.HasMany(u => u.Pagamentos).WithOne(u => u.Utilizador);
            builder.HasMany(u => u.Servicos).WithOne(u => u.Utilizador);

            builder.ToTable("Utilizador");

        }
    }
}
