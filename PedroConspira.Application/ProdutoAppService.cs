using PedroConspira.Application.Interfaces;
using PedroConspira.Domain.Entities;
using PedroConspira.Domain.Interfaces.Repositories;
using PedroConspira.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;

namespace PedroConspira.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoAppService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public bool NomeProdutoExiste(Produto produto)
        {
            return _produtoRepository.GetAll().Where(x => x.Nome == produto.Nome && x.Id != produto.Id).Count() > 0;
        }
    }
}