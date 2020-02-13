using DSWN.Core.SectorCreation.Entities;
using DSWN.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;

namespace DSWN.Core.SectorCreation.Interfaces
{
    public class ISubstellarObjectRepository : IRepository<SubstellarObject, Guid>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public SubstellarObject? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(SubstellarObject entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SubstellarObject> List()
        {
            throw new NotImplementedException();
        }

        public void Update(SubstellarObject entity)
        {
            throw new NotImplementedException();
        }
    }
}
