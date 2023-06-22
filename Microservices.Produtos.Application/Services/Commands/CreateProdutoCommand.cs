using MediatR;
using Microservices.Produtos.Domain.Entities;
using Microservices.Produtos.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.Produtos.Application.Services.Commands
{
    public class CreateProdutoCommand : IRequest<int>
    {
        public string NomeProduto { get; set; }
        public string CodigoBarras { get; set; }

        public class CreateProductCommandHandler : IRequestHandler<CreateProdutoCommand, int>
        {
            private readonly IProdutoRepository _context;
            private readonly IMediator _mediator;

            public CreateProductCommandHandler(IProdutoRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<int> Handle(CreateProdutoCommand command,
                CancellationToken cancellationToken)
            {
                var produto = new Produto();
                produto.NomeProduto = command.NomeProduto;
                produto.CodigoBarras = command.CodigoBarras;
                _context.Add(produto);
                return produto.ProdutoId;
            }
        }
    }
}
