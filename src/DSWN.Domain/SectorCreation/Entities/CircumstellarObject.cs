using DSWN.Core.SectorCreation.Interfaces;
using DSWN.SharedKernel;
using System;

namespace DSWN.Core.SectorCreation.Entities
{
    /// <summary>
    /// Circumstellar Objects are Discs or Rings that orbit around a star or similarly massive object.
    /// They are comprised of thousands, millions or more small objects such as asteroids, or may even
    /// be fine stellar dust or gas.
    /// </summary>
    public class CircumstellarObject : BaseEntity<Guid>, IAggregateRoot
    {
        public Guid PlanetarySystemId { get; private set; }
    }
}
