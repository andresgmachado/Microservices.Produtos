using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Produtos.Application.Services.Events
{
    public class ProdutoCreateEvent : IEvent
    {
        public ProdutoCreateEvent(Guid id, string nomeProduto)
        {
            Id = id;
            NomeProduto = nomeProduto;
        }

        public Guid Id { get; }
        public string NomeProduto { get; }
    }
}

