using System.Collections.Generic;
using PedroConspira.Domain.Entities;

namespace PedroConspira.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
