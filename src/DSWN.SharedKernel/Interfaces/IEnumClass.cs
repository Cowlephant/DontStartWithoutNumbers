using System;
using System.Collections.Generic;
using System.Text;

namespace DSWN.SharedKernel.Interfaces
{
    public interface IEnumClass
    {
        int Id { get; }
        string Name { get; }
        string Description { get; }
    }
}
