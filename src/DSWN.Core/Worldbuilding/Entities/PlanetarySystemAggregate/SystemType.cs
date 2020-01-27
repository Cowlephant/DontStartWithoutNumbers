using DSWN.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSWN.Core.Worldbuilding.Entities.PlanetarySystemAggregate
{
    public sealed class SystemType : EnumClassBase<SystemType>
    {
        public static SystemType Single { get; } = new SystemType(0, "Single System", "Planets orbit around a single gravitational body at the center of the system");
        public static SystemType Binary { get; } = new SystemType(1, "Binary System", "Planets orbit far away around the barycenter of a pair of bodies");
        public static SystemType Trinary { get; } = new SystemType(2, "Trinary System", "Planets orbit around a single gravitational body, itself orbiting around the barycenter of a body pair");
        public static SystemType Quaternary { get; } = new SystemType(3, "Quaternary System", "Planets orbit around the barycenter of a pair of gravitational bodies, themselves orbiting far away around the barycenter of a body pair");

        private SystemType(int id, string name, string description) : base(id, name, description)
        {
        }
    }
}
