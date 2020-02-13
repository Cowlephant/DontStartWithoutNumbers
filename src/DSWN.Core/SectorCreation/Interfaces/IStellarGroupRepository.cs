using DSWN.Core.SectorCreation.Entities.StellarGroupAggregate;
using DSWN.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;

namespace DSWN.Core.SectorCreation.Interfaces
{
    public class IStellarGroupRepository : IRepository<StellarGroup, Guid>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public StellarGroup? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(StellarGroup entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<StellarGroup> List()
        {
            throw new NotImplementedException();
        }

        public void Update(StellarGroup entity)
        {
            throw new NotImplementedException();
        }
    }
}
