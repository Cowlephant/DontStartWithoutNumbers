using System.Collections.Generic;

namespace DSWN.SharedKernel
{
    // source: https://github.com/ardalis/CleanArchitecture
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public List<BaseDomainEvent> Events = new List<BaseDomainEvent>();
    }
}
