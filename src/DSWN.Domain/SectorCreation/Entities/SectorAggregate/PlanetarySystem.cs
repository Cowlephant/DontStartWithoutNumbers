using DSWN.Core.SectorCreation.ValueObjects;
using DSWN.SharedKernel;
using System;

namespace DSWN.Core.SectorCreation.Entities.SectorAggregate
{
    /// <summary>
    /// Planetary Systems are the building blocks of a Sector, usually connected together via
    /// known, undiscovered or lost metadimensional travel paths. The most interesting ones which
    /// can be travelled to contain a star, stars, or other exceptionally massive or dense object
    /// that can interrupt metadimensional travel. These usually contain planets but may not always.
    /// </summary>
    public sealed class PlanetarySystem : BaseEntity<Guid>
    {
        public Definition Definition { get; private set; }

        public PlanetarySystem(Definition definition)
        {
            Definition = definition;
        }
    }
}
