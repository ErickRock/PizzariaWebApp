using Microsoft.EntityFrameworkCore;
using PizzariaWebApp.Models;

namespace PizzariaWebApp.Data{

    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Definindo os DbSet para cada entidade
        public DbSet<Pizza> Pizzas { get; set; } 
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Cliente> Clientes { get; set;}
    }
}