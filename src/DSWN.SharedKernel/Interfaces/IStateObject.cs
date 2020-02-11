using DSWN.SharedKernel.Enums;

namespace DSWN.SharedKernel.Interfaces
{
    public interface IStateObject
    {
        ObjectState State { get; }
    }
}
