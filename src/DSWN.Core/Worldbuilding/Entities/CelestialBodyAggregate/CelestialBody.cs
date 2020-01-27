using DSWN.Core.Worldbuilding.Entities.ValueObjects;
using DSWN.SharedKernel;
using System;

namespace DSWN.Core.Worldbuilding.Entities.CelestialBodyAggregate
{
    public sealed class CelestialBody : BaseEntity<Guid>
    {
        public Definition Definition { get; private set; }

        public CelestialBody(Definition definition)
        {
            Definition = definition;
        }
    }
}
