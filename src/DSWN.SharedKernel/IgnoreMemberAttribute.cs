using System;
using System.Collections.Generic;
using System.Text;

namespace DSWN.SharedKernel
{
    // source: https://github.com/ardalis/CleanArchitecture
    // source: https://github.com/jhewlett/ValueObject
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public sealed class IgnoreMemberAttribute : Attribute
    {
    }
}
