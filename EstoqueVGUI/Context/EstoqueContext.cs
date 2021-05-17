using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data;


namespace Estoque
{
    public class EstoqueContext : DbContext
    {
        private const string connectionString = "Server=localhost;Database=estoque;User=root;";
 
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    => optionsBuilder.UseMySQL();

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Peca> Pecas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<PedidoServico> PedidosServico { get; set; }
        public DbSet<PedidoPeca> PedidosPeca { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PedidoServico>()
                .HasNoKey();
            modelBuilder.Entity<PedidoPeca>()
                .HasNoKey();
        }

    }
}