using NodaTime;
using System;

namespace DSWN.SharedKernel
{
    public abstract class BaseDomainEvent
    {
        protected readonly IClock clock;

        public BaseDomainEvent(IClock clock)
        {
            this.clock = clock;
            DateOcurred = clock.GetCurrentInstant().InUtc().LocalDateTime;
        }

        public LocalDateTime DateOcurred { get; protected set; }
    }
}
