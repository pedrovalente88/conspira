using PedroConspira.Application.Interfaces;
using PedroConspira.Domain.Entities;
using PedroConspira.Domain.Interfaces.Repositories;
using PedroConspira.Domain.Interfaces.Services;
using System.Linq;

namespace PedroConspira.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteAppService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public bool NomeClienteExiste(Cliente cliente)
        {
            return _clienteRepository.GetAll().Where(x => x.Nome == cliente.Nome && x.Id != cliente.Id).Count() > 0;
        }
    }
}
