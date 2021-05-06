using FoodThy.Application.Models;
using FoodThy.Domain.Configurations;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace FoodThy.Domain.DataContexts
{
    public partial class FoodThyContext : DbContext
    {
        public FoodThyContext()
        {
        }

        public FoodThyContext(DbContextOptions<FoodThyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblUsuario> TblUsuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TblUsuarioConfiguration());            
        }
    }
}
