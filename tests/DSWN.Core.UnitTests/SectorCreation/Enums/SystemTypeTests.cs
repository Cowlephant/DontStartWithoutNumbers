using DSWN.Core.SectorCreation.Enums;
using DSWN.SharedKernel.UnitTests;
using Xunit;

namespace DSWN.Core.UnitTests.SectorCreation.Enums
{
    public class SystemTypeTests
    {
        [Fact]
        public void Enum_DefinitionsShouldBeValid_WhenDefined()
        {
            EnumTests<SystemType>.Enum_ShouldNotHaveDuplicateIds();
            EnumTests<SystemType>.Enum_ShouldHaveConsecutiveEnumIds();
        }
    }
}
