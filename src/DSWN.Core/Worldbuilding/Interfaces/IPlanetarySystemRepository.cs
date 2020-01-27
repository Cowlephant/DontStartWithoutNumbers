using DSWN.SharedKernel;
using DSWN.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSWN.Core.Worldbuilding.Interfaces
{
    public class IPlanetarySystemRepository : IRepository<Guid>
    {
        public T Add<T>(T entity) where T : BaseEntity<Guid>
        {
            throw new NotImplementedException();
        }

        public void Delete<T>(T entity) where T : BaseEntity<Guid>
        {
            throw new NotImplementedException();
        }

        public T GetById<T>(Guid id) where T : BaseEntity<Guid>
        {
            throw new NotImplementedException();
        }

        public List<T> List<T>() where T : BaseEntity<Guid>
        {
            throw new NotImplementedException();
        }

        public void Update<T>(T entity) where T : BaseEntity<Guid>
        {
            throw new NotImplementedException();
        }
    }
}
