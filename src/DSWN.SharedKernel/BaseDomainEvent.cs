using System;

namespace DSWN.SharedKernel
{
    // source: https://github.com/ardalis/CleanArchitecture
    public abstract class BaseDomainEvent
    {
        public DateTime DateOccurred { get; protected set; } = DateTime.UtcNow;
    }
}
