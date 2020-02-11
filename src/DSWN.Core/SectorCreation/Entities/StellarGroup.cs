using DSWN.SharedKernel;
using System;
using System.Collections.Generic;

namespace DSWN.Core.SectorCreation.Entities
{
    /// <summary>
    /// A Stellar Group is the singlular or pair of stars in a Planetary System that all other objects
    /// in the system orbit around. These groups may themselves contain a Stellar Group to model
    /// trinary, quaternary or greater systems in a hierarchy.
    /// </summary>
    public class StellarGroup: BaseEntity<Guid>
    {
        public StellarObject Primary { get; private set; }
        public StellarObject? Secondary { get; private set; }

        public StellarGroup? ChildGroup { get; private set; }
        public bool HasChildGroup { get; private set; }
        public Guid PlanetarySystemId { get; private set; }

        public StellarGroup(StellarObject primary, StellarObject? secondary)
        {
            Primary = primary;
            Secondary = secondary;
        }

        public StellarGroup WithStellarGroup(StellarGroup childGroup)
        {
            ChildGroup = childGroup;
            HasChildGroup = true;
            return this;
        }

        public IReadOnlyList<StellarObject> GetStellarObjects()
        {
            var stellarObjects = new List<StellarObject> { Primary };
            if (Secondary is object) stellarObjects.Add(Secondary);

            return stellarObjects;
        }
    }
}
