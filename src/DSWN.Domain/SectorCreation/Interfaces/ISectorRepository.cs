using DSWN.Core.SectorCreation.Entities.SectorAggregate;
using DSWN.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;

namespace DSWN.Core.SectorCreation.Interfaces
{
    public class ISectorRepository : IRepository<Sector, Guid>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public Sector? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Sector entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sector> List()
        {
            throw new NotImplementedException();
        }

        public void Update(Sector entity)
        {
            throw new NotImplementedException();
        }
    }
}
