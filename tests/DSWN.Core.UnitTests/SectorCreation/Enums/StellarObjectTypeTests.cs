using DSWN.Core.SectorCreation.Enums;
using DSWN.SharedKernel;
using System.Linq;
using Xunit;

namespace DSWN.Core.UnitTests.SectorCreation.Enums
{
    public class StellarObjectTypeTests
    {
        public StellarObjectTypeTests() { }

        [Fact]
        public void StellarObject_ShouldNotHaveDuplicateEnumIds()
        {
            var ids = SystemType.GetIds();
            var distinctIds = ids.Distinct().Count();

            var expected = ids.Count();

            Assert.Equal(expected, distinctIds);
        }

        [Fact]
        public void StellarObject_ShouldHaveConsecutiveEnumIds()
        {
            var ids = SystemType.GetIds();

            var isConsecutive = TestHelpers.IsConsecutive(ids);

            Assert.True(isConsecutive);
        }
    }
}
