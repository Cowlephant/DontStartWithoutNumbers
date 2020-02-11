using System.Collections.Generic;
using System.Linq;

namespace DSWN.SharedKernel
{
    //ncrunch: no coverage start
    public static class TestHelpers
    {
        public static bool IsConsecutive(this IEnumerable<int> valueList)
        {
            return !valueList.Select((i, j) => i - j).Distinct().Skip(1).Any();
        }
    }
    //ncrunch: no coverage end
}
