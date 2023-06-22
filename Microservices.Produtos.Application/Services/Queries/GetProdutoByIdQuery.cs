using MediatR;
using Microservices.Produtos.Domain.Entities;
using Microservices.Produtos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.Produtos.Application.Services.Queries
{
    public class GetProdutoByIdQuery : IRequest<Produto>
    {
        public int Id { get; set; }
        public class GetProductByIdQueryHandler : IRequestHandler<GetProdutoByIdQuery, Produto>
        {
            private readonly IProdutoRepository _context;
            private readonly IMediator _mediator;
            public GetProductByIdQueryHandler(IProdutoRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<Produto> Handle(GetProdutoByIdQuery query, CancellationToken cancellationToken)
            {
                var produto = await _context.GetById(query.Id);

                if (produto == null) return default;

                return produto;
            }
        }
    }
}