using System.Linq;
using Xunit;

namespace DSWN.SharedKernel.UnitTests
{
    public abstract class EnumTests<T> where T : EnumClassBase<T>
    {
        public static void Enum_ShouldNotHaveDuplicateIds()
        {
            var ids = EnumClassBase<T>.GetIds();
            var distinctIds = ids.Distinct().Count();

            var expected = ids.Count();

            Assert.Equal(expected, distinctIds);
        }

        public static void Enum_ShouldHaveConsecutiveEnumIds()
        {
            var ids = EnumClassBase<T>.GetIds();

            var isConsecutive = TestHelpers.IsConsecutive(ids);

            Assert.True(isConsecutive);
        }
    }
}
