using PedroConspira.Application.Interfaces;
using PedroConspira.Domain.Entities;
using PedroConspira.Domain.Interfaces.Repositories;
using PedroConspira.Domain.Interfaces.Services;
using System.Linq;

namespace PedroConspira.Application
{
    public class ClienteProdutoAppService : AppServiceBase<ClienteProduto>, IClienteProdutoAppService
    {
        private readonly IClienteProdutoRepository _clienteProdutoRepository;

        public ClienteProdutoAppService(IClienteProdutoRepository clienteProdutoRepository)
            : base(clienteProdutoRepository)
        {
            _clienteProdutoRepository = clienteProdutoRepository;
        }
    }
}
