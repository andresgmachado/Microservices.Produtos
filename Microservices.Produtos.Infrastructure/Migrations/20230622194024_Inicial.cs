using Microsoft.EntityFrameworkCore.Migrations;

namespace Microservices.Produtos.Infrastructure.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ProdutoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeProduto = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Quantidade = table.Column<double>(type: "float", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    CodigoBarras = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ProdutoId);
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CodigoBarras", "NomeProduto", "Preco", "Quantidade", "descricao" },
                values: new object[] { 1, "79846546", "Camiseta Branca", 60.0, 500.0, "Camiseta Masculina" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CodigoBarras", "NomeProduto", "Preco", "Quantidade", "descricao" },
                values: new object[] { 2, "79846546", "Camiseta Branca", 60.0, 500.0, "Camiseta frminina" });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "ProdutoId", "CodigoBarras", "NomeProduto", "Preco", "Quantidade", "descricao" },
                values: new object[] { 3, "79846546", "Camiseta Azul", 60.0, 500.0, "Camiseta Masculina" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
