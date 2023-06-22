using Microservices.Produtos.Domain.Entities;
using Microservices.Produtos.Domain.Interfaces;
using Microservices.Produtos.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Produtos.Infrastructure.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        protected readonly AppDbContext db;
        public ProdutoRepository(AppDbContext context)
        {
            db = context;
        }
        public void Add(Produto produto)
        {
            db.Produtos.Add(produto);
            db.SaveChanges();
        }

        public async Task<IEnumerable<Produto>> GetAll()
        {
            return await db.Produtos.ToListAsync();
        }

        public async Task<Produto> GetByCodigoBarras(string codigoBarras)
        {
            return await db.Produtos.AsNoTracking().FirstOrDefaultAsync(x => x.CodigoBarras == codigoBarras);
        }

        public async Task<Produto> GetById(int id)
        {
            return await db.Produtos.FindAsync(id);
        }

        public  async Task<Produto> GetByNome(string nomeProduto)
        {
            return await db.Produtos.AsNoTracking().FirstOrDefaultAsync(x => x.NomeProduto == nomeProduto);
        }

        public void Remove(Produto produto)
        {
            db.Produtos.Remove(produto);
            db.SaveChanges();
        }

        public void Update(Produto produto)
        {
            db.Produtos.Update(produto);
            db.SaveChanges();
        }
    }
}

