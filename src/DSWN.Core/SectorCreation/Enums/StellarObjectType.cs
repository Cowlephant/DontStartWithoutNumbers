using DSWN.SharedKernel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSWN.Core.SectorCreation.Enums
{
    public sealed class StellarObjectType : EnumClassBase<StellarObjectType>
    {
        private StellarObjectType(int id, string name, string description) : base(id, name, description) { }

        public static StellarObjectType Star { get; } = new StellarObjectType(0, "Star", 
            "Luminous spheroid of plasma held together by its own gravity");
        public static StellarObjectType BlackHole { get; } = new StellarObjectType(1, 
            "Black Hole", "A region of spacetime exhibiting gravitational acceleration so strong that nothing, not even light can escape from it");
        public static StellarObjectType Planet { get; } = new StellarObjectType(2, "Planet", 
            "Massive enough to be rounded by its own gravity, is not massive enough to cause thermonuclear fusion");
        public static StellarObjectType Moon { get; } = new StellarObjectType(3, "Moon", 
            "Astronomical body that orbits a planet or minor planet");
        public static StellarObjectType Asteroid { get; } = new StellarObjectType(4, "Asteroid", 
            "A small rocky object or even a larger planetoid that orbits a star instead of a planet");
        public static StellarObjectType AsteroidBelt { get; } = new StellarObjectType(5, "Asteroid Belt", 
            "A torus shaped region of space occupied by many asteroids");
        public static StellarObjectType DustCloud { get; } = new StellarObjectType(6, "Dust Cloud", 
            "A torus shaped region of space occupied by cosmic dust or other material");
        public static StellarObjectType Pulsar { get; } = new StellarObjectType(7, "Pulsar", 
            "Highly magnetized rotating neutron star that emits beams of electromagnetic radiation out of its magnetic poles");
        public static StellarObjectType Trojan { get; } = new StellarObjectType(8, "Trojan", 
            "A small celestial body that shares the orbit of a larger one, remaining in a stable orbit near one of its Lagrangian points");
        public static StellarObjectType Protostar { get; } = new StellarObjectType(9, "Protostar", 
            "Very young star that is still gathering mass from its parent molecular cloud");
        public static StellarObjectType TTauriStar { get; } = new StellarObjectType(10, "T Tauri Star", 
            "Young star beyond the protostar stage that has yet to ignite fusion of hydrogen and helium");
        public static StellarObjectType Protoplanet { get; } = new StellarObjectType(11, "Protoplanet", 
            "A large body of matter in orbit of a star thought to be developing into a planet");
        public static StellarObjectType ProtoplanetaryDisc { get; } = new StellarObjectType(12, "Protoplanetary Disc", 
            "Rotating circumstellar disk of dense gas and dust surrounding a young newly formed star");
    }
}
