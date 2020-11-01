using DSWN.Core.SectorCreation.Entities;
using DSWN.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;

namespace DSWN.Core.SectorCreation.Interfaces
{
    public class ICircumstellarObjectRepository : IRepository<CircumstellarObject, Guid>
    {
        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public CircumstellarObject? GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(CircumstellarObject entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CircumstellarObject> List()
        {
            throw new NotImplementedException();
        }

        public void Update(CircumstellarObject entity)
        {
            throw new NotImplementedException();
        }
    }
}
