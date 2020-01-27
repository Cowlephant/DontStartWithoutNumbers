using System.Collections.Generic;

namespace DSWN.SharedKernel.Interfaces
{
    // source: https://github.com/ardalis/CleanArchitecture
    public interface IRepository<TId>
    {
        T GetById<T>(TId id) where T : BaseEntity<TId>;
        List<T> List<T>() where T : BaseEntity<TId>;
        T Add<T>(T entity) where T : BaseEntity<TId>;
        void Update<T>(T entity) where T : BaseEntity<TId>;
        void Delete<T>(T entity) where T : BaseEntity<TId>;
    }
}
