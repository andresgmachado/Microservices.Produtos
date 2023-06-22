using MediatR;
using Microservices.Produtos.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;

namespace Microservices.Produtos.Application.Services.Commands
{
    public class UpdateProdutoCommand : IRequest<int>
    {
        public string NomeProduto { get; set; }
        public string CodigoBarras { get; set; }
        public int ProdutoId { get; set; }

        public class UpdateProductCommandHandler : IRequestHandler<UpdateProdutoCommand, int>
        {
            private readonly IProdutoRepository _context;
            private readonly IMediator _mediator;
            public UpdateProductCommandHandler(IProdutoRepository context, IMediator mediator)
            {
                _context = context;
                _mediator = mediator;
            }
            public async Task<int> Handle(UpdateProdutoCommand command, CancellationToken cancellationToken)
            {
                var produto = await _context.GetById(command.ProdutoId);
                if (produto == null) return default;
                produto.NomeProduto = command.NomeProduto;
                produto.CodigoBarras = command.CodigoBarras;
                _context.Update(produto);
                return produto.ProdutoId;
            }
        }
    }
}
