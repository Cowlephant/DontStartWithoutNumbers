using DSWN.Core.SectorCreation.Interfaces;
using DSWN.SharedKernel;
using System;

namespace DSWN.Core.SectorCreation.Entities
{
    /// <summary>
    /// Substellar Objects are anything less massive than a Stellar Object, and usually orbit
    /// around a Stellar Group (either a single star or binary) as a circumbinary object (P-Type), but
    /// rarely they may orbit around an individual star of a binary pair as a 
    /// non-circumbinary object (S-Type).
    /// </summary>
    public class SubstellarObject : BaseEntity<Guid>, IAggregateRoot
    {
    }
}
