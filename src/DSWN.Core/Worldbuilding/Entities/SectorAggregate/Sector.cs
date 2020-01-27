using DSWN.Core.Worldbuilding.Entities.ValueObjects;
using DSWN.SharedKernel;
using System;

namespace DSWN.Core.Worldbuilding.Entities.SectorAggregate
{
    public sealed class Sector : BaseEntity<Guid>
    {
        public Definition Definition { get; private set; }

        public Sector(Definition definition)
        {
            Definition = definition;
        }
    }
}
