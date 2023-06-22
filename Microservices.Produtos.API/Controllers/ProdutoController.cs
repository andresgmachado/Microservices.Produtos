using MediatR;
using Microservices.Produtos.Application.Services.Commands;
using Microservices.Produtos.Application.Services.Queries;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Microservices.Produtos.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IMediator _mediator;
        public ProdutoController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProdutoCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new GetAllProdutosQuery());
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _mediator.Send(new GetProdutoByIdQuery { Id = id });
            if (result == null)
                return NotFound();
            else
                return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _mediator.Send(new DeleteProdutoByIdCommand { Id = id });
            return Ok(result);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProdutoCommand command)
        {
            if (id != command.ProdutoId)
            {
                return BadRequest();
            }

            var result = await _mediator.Send(command);

            return Ok(result);
        }
    }
}