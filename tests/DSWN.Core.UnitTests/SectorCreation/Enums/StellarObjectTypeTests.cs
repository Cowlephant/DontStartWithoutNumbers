using DSWN.Core.SectorCreation.Enums;
using DSWN.SharedKernel.UnitTests;
using Xunit;

namespace DSWN.Core.UnitTests.SectorCreation.Enums
{
    public class StellarObjectTypeTests
    {
        [Fact]
        public void Enum_DefinitionsShouldBeValid_WhenDefined()
        {
            EnumTests<StellarObjectType>.Enum_ShouldNotHaveDuplicateIds();
            EnumTests<StellarObjectType>.Enum_ShouldHaveConsecutiveEnumIds();
        }
    }
}
