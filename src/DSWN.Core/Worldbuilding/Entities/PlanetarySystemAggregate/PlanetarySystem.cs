using DSWN.Core.Worldbuilding.Entities.ValueObjects;
using DSWN.SharedKernel;
using System;

namespace DSWN.Core.Worldbuilding.Entities.PlanetarySystemAggregate
{
    public sealed class PlanetarySystem : BaseEntity<Guid>
    {
        public Definition Definition { get; private set; }

        public PlanetarySystem(Definition definition)
        {
            Definition = definition;
        }
    }
}
