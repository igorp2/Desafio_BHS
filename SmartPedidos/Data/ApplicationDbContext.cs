using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using SmartPedidos.Models;

namespace SmartPedidos.Data
{

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){ }

        public DbSet<Item> Itens { get; set; }
            
        public DbSet<Pedido> Pedidos { get; set; }
    }
    
}