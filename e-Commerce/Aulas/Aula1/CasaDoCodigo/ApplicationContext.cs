using CasaDoCodigo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CasaDoCodigo
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Produto>().HasKey(k => k.Id);

            modelBuilder.Entity<Pedido>().HasKey(k => k.Id);
            modelBuilder.Entity<Pedido>().HasMany(k => k.Itens).WithOne(k => k.Pedido);
            modelBuilder.Entity<Pedido>().HasOne(k => k.Cadastro).WithOne(k => k.Pedido).IsRequired();


            modelBuilder.Entity<ItemPedido>().HasKey(k => k.Id);
            modelBuilder.Entity<ItemPedido>().HasOne(k => k.Pedido);
            modelBuilder.Entity<ItemPedido>().HasOne(k => k.Produto);


            modelBuilder.Entity<Cadastro>().HasKey(k => k.Id);
            modelBuilder.Entity<Cadastro>().HasOne(k => k.Pedido);
        }
    }
}
