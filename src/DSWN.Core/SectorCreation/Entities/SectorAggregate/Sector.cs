using DSWN.Core.SectorCreation.Interfaces;
using DSWN.Core.SectorCreation.ValueObjects;
using DSWN.SharedKernel;
using System;

namespace DSWN.Core.SectorCreation.Entities.SectorAggregate
{
    /// <summary>
    /// Sectors encompass the game world by representing a region of space connected via metadimensional
    /// travel navigation paths. They are comprised of Planetary Systems which may or may not contain
    /// Stars or other metadimensional gravity well that usually but not always contains planets.
    /// </summary>
    public sealed class Sector : BaseEntity<Guid>, IAggregateRoot
    {
        public Definition Definition { get; private set; }

        public Sector(Definition definition)
        {
            Definition = definition;
        }
    }
}
