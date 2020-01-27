using DSWN.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSWN.Core.Worldbuilding.Entities.CelestialBodyAggregate
{
    public sealed class CelestialType : EnumClassBase<CelestialType>
    {
        public static CelestialType Star { get; } = new CelestialType(0, "Star", "Luminous spheroid of plasma held together by its own gravity");
        public static CelestialType BlackHole { get; } = new CelestialType(1, "Black Hole", "A region of spacetime exhibiting gravitational acceleration so strong that nothing, not even light can escape from it");
        public static CelestialType Planet { get; } = new CelestialType(2, "Planet", "Massive enough to be rounded by its own gravity, is not massive enough to cause thermonuclear fusion");
        public static CelestialType Moon { get; } = new CelestialType(3, "Moon", "Astronomical body that orbits a planet or minor planet");
        public static CelestialType Asteroid { get; } = new CelestialType(4, "Asteroid", "A small rocky object or even a larger planetoid that orbits a star instead of a planet");
        public static CelestialType AsteroidBelt { get; } = new CelestialType(5, "Asteroid Belt", "A torus shaped region of space occupied by many asteroids");
        public static CelestialType DustCloud { get; } = new CelestialType(6, "Dust Cloud", "A torus shaped region of space occupied by cosmic dust or other material");
        public static CelestialType Pulsar { get; } = new CelestialType(7, "Pulsar", "Highly magnetized rotating neutron star that emits beams of electromagnetic radiation out of its magnetic poles");
        public static CelestialType Trojan { get; } = new CelestialType(8, "Trojan", "A small celestial body that shares the orbit of a larger one, remaining in a stable orbit near one of its Lagrangian points");
        public static CelestialType Protostar { get; } = new CelestialType(9, "Protostar", "Very young star that is still gathering mass from its parent molecular cloud");
        public static CelestialType TTauriStar { get; } = new CelestialType(10, "T Tauri Star", "Young star beyond the protostar stage that has yet to ignite fusion of hydrogen and helium");
        public static CelestialType Protoplanet { get; } = new CelestialType(11, "Protoplanet", "A large body of matter in orbit of a star thought to be developing into a planet");
        public static CelestialType ProtoplanetaryDisc { get; } = new CelestialType(12, "Protoplanetary Disc", "Rotating circumstellar disk of dense gas and dust surrounding a young newly formed star");

        private CelestialType(int id, string name, string description) : base(id, name, description)
        {
        }
    }
}
