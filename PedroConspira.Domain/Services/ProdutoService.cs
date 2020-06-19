using System.Collections.Generic;
using PedroConspira.Domain.Entities;
using PedroConspira.Domain.Interfaces.Repositories;
using PedroConspira.Domain.Interfaces.Services;

namespace PedroConspira.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
    }
}
