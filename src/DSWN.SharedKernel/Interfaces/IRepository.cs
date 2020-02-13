using DSWN.Core.SectorCreation.Interfaces;
using System.Collections.Generic;

namespace DSWN.SharedKernel.Interfaces
{
    public interface IRepository<TEntity, TId> where TEntity : BaseEntity<TId>, IAggregateRoot
    {
        TEntity? GetById(TId id);
        IEnumerable<TEntity> List();
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TId id);
    }
}
