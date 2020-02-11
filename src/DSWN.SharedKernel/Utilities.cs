using DSWN.SharedKernel.Enums;
using DSWN.SharedKernel.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace DSWN.SharedKernel
{
    public static class Utilities
    {
        // reference: Julie Lerman's Entity Framework in the Enterprise on Pluralsight.com
        [ExcludeFromCodeCoverage]
        private static EntityState ConvertState(ObjectState state)
        {
            switch (state)
            {
                case ObjectState.Added:
                    return EntityState.Added;
                case ObjectState.Modified:
                    return EntityState.Modified;
                case ObjectState.Deleted:
                    return EntityState.Deleted;

                default:
                    return EntityState.Unchanged;
            }
        }

        // reference: Julie Lerman's Entity Framework in the Enterprise on Pluralsight.com
        [ExcludeFromCodeCoverage]
        public static void FixState(this DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries<IStateObject>())
            {
                IStateObject stateInfo = entry.Entity;
                entry.State = ConvertState(stateInfo.State);
            }
        }
    }
}
