
using Architecture.Core.Data.Repositories;
using Architecture.Core.Entities.Foundation;
using System;
using System.Threading.Tasks;

namespace Architecture.Core.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity;
        
        void BeginTransaction();
        
        int Commit();
        
        Task<int> CommitAsync();

        void Rollback();

        void Dispose(bool disposing);

    }
}
