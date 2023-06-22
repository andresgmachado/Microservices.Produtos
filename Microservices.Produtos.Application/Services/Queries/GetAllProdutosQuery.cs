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
    public class GetAllProdutosQuery : IRequest<IEnumerable<Produto>>
    {
        public class GetAllCustomersQueryHandler : IRequestHandler<GetAllProdutosQuery,
            IEnumerable<Produto>>
        {
            private readonly IProdutoRepository _context;
            private readonly IMediator _mediator;
            public GetAllCustomersQueryHandler(IProdutoRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<IEnumerable<Produto>> Handle(GetAllProdutosQuery query,
                CancellationToken cancellationToken)
            {
                var produtosList = await _context.GetAll();
                if (produtosList == null) return default;

                return produtosList;
            }
        }
    }
}
