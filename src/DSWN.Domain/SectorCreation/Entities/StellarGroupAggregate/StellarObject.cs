using DSWN.Core.SectorCreation.ValueObjects;
using DSWN.SharedKernel;
using System;

namespace DSWN.Core.SectorCreation.Entities.StellarGroupAggregate
{
    /// <summary>
    /// A Stellar Object is a sun or other massive space object such as a black hole. These objects
    /// are massive enough to interrupt metadimensional travel and pull ships into the
    /// real space of the Planetary System.
    /// </summary>
    public sealed class StellarObject : BaseEntity<Guid>
    {
        public Definition Definition { get; private set; }

        public StellarObject(Definition definition)
        {
            Definition = definition;
        }
    }
}
