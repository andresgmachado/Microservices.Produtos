using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservices.Produtos.Application.Services.Events
{
    public interface IEvent
    {
        Guid Id { get; }
        public string NomeProduto { get; }
    }
}
