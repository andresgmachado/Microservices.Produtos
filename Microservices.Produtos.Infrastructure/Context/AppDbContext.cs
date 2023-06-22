using Microservices.Produtos.Domain.Entities;
using Microservices.Produtos.Infrastructure.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Microservices.Produtos.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProdutoConfiguration());
        }
    }
}
