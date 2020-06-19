using PedroConspira.Application.Interfaces;
using PedroConspira.Domain.Interfaces.Repositories;
using PedroConspira.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedroConspira.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _serviceBase;

        public AppServiceBase(IRepositoryBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public TEntity Add(TEntity obj)
        {
            return _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity Update(TEntity obj)
        {
            return _serviceBase.Update(obj);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
