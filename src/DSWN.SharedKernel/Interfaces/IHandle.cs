using System.Threading.Tasks;

namespace DSWN.SharedKernel.Interfaces
{
    // source: https://github.com/ardalis/CleanArchitecture
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}
