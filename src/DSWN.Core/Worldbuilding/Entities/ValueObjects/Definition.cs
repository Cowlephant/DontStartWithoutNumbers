using DSWN.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSWN.Core.Worldbuilding.Entities.ValueObjects
{
    public sealed class Definition : ValueObject
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Definition(string name) : this(name, "")
        {
        }

        public Definition(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
