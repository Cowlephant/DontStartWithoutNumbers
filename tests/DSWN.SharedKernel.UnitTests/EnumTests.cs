using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DSWN.SharedKernel.UnitTests
{
    public abstract class EnumTests<T> where T : EnumClassBase<T>
    {
        private IEnumerable<int> ids;

        public EnumTests()
        {
            ids = EnumClassBase<T>.GetIds();
        }

        [Fact]
        public void Enum_ShouldStartWithZero()
        {
            var minId = ids.Min();

            Assert.Equal(0, minId);
        }

        [Fact]
        public void Enum_ShouldNotHaveDuplicateIds()
        {
            var distinctIds = ids.Distinct().Count();

            var expected = ids.Count();

            Assert.Equal(expected, distinctIds);
        }

        [Fact]
        public void Enum_ShouldHaveConsecutiveEnumIds()
        {
            var idsAreConsecutive = TestHelpers.IsConsecutive(ids);

            Assert.True(idsAreConsecutive);
        }
    }
}
