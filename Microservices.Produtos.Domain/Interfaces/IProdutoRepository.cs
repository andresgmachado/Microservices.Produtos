using Microservices.Produtos.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microservices.Produtos.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        Task<Produto> GetById(int id);
        Task<Produto> GetByNome(string NomeProduto);
        Task<Produto> GetByCodigoBarras(string codigoBarras);
        Task<IEnumerable<Produto>> GetAll();
        void Add(Produto produto);
        void Update(Produto produto);
        void Remove(Produto produto);
    }
}
