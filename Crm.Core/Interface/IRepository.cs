using Crm.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Crm.Core.Interface
{
    public interface IRepository : IReadOnlyRepository
    {
        void Create<TEntity>(TEntity entity, int createdBy = 0)
        where TEntity : class, IEntity;

        void Update<TEntity>(TEntity entity, int modifiedBy = 0)
            where TEntity : class, IEntity;

        void Delete<TEntity>(object id)
            where TEntity : class, IEntity;

        void Delete<TEntity>(TEntity entity)
            where TEntity : class, IEntity;

        void Save();

        Task SaveAsync();
    }
}
