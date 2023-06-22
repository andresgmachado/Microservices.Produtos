using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Microservices.Produtos.Domain.Entities;

namespace Microservices.Produtos.Infrastructure.EntityConfiguration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.Property(b => b.NomeProduto).HasMaxLength(100);
            builder.Property(b => b.CodigoBarras).HasMaxLength(20);
            builder.HasData(
                new Produto
                {
                    ProdutoId = 1,
                    NomeProduto = "Camiseta Branca",
                    CodigoBarras = "79846546",
                    descricao = "Camiseta Masculina",
                    Preco = 60.00,
                    Quantidade = 500
                    
                },
                new Produto
                {
                    ProdutoId = 2,
                    NomeProduto = "Camiseta Branca",
                    CodigoBarras = "79846546",
                    descricao = "Camiseta frminina",
                    Preco = 60.00,
                    Quantidade = 500
                },
                new Produto
                {
                    ProdutoId = 3,
                    NomeProduto = "Camiseta Azul",
                    CodigoBarras = "79846546",
                    descricao = "Camiseta Masculina",
                    Preco = 60.00,
                    Quantidade = 500
                }
           );
        }
    }
}
