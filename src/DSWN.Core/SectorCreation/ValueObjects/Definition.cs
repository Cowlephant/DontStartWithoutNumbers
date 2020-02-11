using DSWN.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSWN.Core.SectorCreation.ValueObjects
{
    public sealed class Definition : ValueObject
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        public Definition(string name, string description = "")
        {
            Name = name;
            Description = description;
        }

        //ncrunch: no coverage start
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Description;
        }
        //ncrunch: no coverage end
    }
}
