using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroConspira.Application.Interfaces
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        TEntity Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();
    }
}
