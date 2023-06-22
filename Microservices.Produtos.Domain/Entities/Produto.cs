using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Produtos.Domain.Entities
{
    public partial class Produto
    {
        public int ProdutoId { get; set; }
        public string NomeProduto { get; set; }
        public double Quantidade { get; set; }
        public double Preco { get; set; }
        public string CodigoBarras { get; set; }
        public string descricao { get; set; }
    }
}
