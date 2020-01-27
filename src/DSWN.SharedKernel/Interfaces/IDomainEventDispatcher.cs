using System.Threading.Tasks;

namespace DSWN.SharedKernel.Interfaces
{
    // source: https://github.com/ardalis/CleanArchitecture
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}
