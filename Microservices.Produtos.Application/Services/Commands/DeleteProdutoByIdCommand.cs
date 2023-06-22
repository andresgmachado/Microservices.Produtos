using MediatR;
using Microservices.Produtos.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.Produtos.Application.Services.Commands
{
    public class DeleteProdutoByIdCommand : IRequest<int>
    {
        public int Id { get; set; }

        public class DeleteProductByIdCommandHandler : IRequestHandler<DeleteProdutoByIdCommand, int>
        {
            private readonly IProdutoRepository _context;
            private readonly IMediator _mediator;
            public DeleteProductByIdCommandHandler(IProdutoRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }

            public async Task<int> Handle(DeleteProdutoByIdCommand command, CancellationToken cancellationToken)
            {
                var produto = await _context.GetById(command.Id);
                if (produto == null) return default;
                _context.Remove(produto);
                return produto.ProdutoId;
            }
        }
    }
}