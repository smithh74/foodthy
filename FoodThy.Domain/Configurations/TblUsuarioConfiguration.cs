using FoodThy.Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodThy.Domain.Configurations
{
    public class TblUsuarioConfiguration : IEntityTypeConfiguration<TblUsuario>
    {
        public void Configure(EntityTypeBuilder<TblUsuario> builder)
        {
            builder.HasKey(e => e.UsuarioId);

            builder.ToTable("tblUsuarios");

            builder.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            builder.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

            builder.Property(e => e.Contrasena)
                    .HasMaxLength(250)
                    .IsUnicode(false);

            builder.Property(e => e.Correo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

            builder.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);           
        }
    }
}
