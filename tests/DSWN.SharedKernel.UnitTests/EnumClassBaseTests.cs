using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DSWN.SharedKernel.UnitTests
{
    public class EnumClassBaseTests
    {
        public class TestEnum : EnumClassBase<TestEnum>
        {
            private TestEnum(int id, string name, string description) : base(id, name, description) { }

            public static TestEnum Alpha { get { return new TestEnum(0, "Alpha", "Alpha"); } }
            public static TestEnum Beta { get { return new TestEnum(1, "Beta", "Beta"); } }
            public static TestEnum Gamma { get { return new TestEnum(2, "Gamma", "Gamma"); } }
            public static TestEnum Delta { get { return new TestEnum(3, "Delta", "Delta"); } }
        }

        [Fact]
        public void ToString_ShouldReturnEnumName()
        {
            var expected = "Alpha";

            var name = TestEnum.Alpha.ToString();

            Assert.Equal(expected, name);
        }

        [Fact]
        public void GetNames_ShouldReturnListOfNames()
        {
            var expected = new List<string> { "Alpha", "Beta", "Gamma", "Delta" };
            var expectedCount = expected.Count;

            var names = TestEnum.GetNames();
            var namesCount = names.ToList().Count;

            Assert.Equal(expectedCount, namesCount);
            Assert.Equal(expected, names);
        }

        [Fact]
        public void GetValue_ShouldReturnProperEnum_GivenId()
        {
            var id = 3;
            var expected = TestEnum.Delta;

            var value = TestEnum.GetValue(id);

            Assert.Equal(expected, value);
        }

        [Fact]
        public void GetValue_ShouldReturnProperEnum_GivenName()
        {
            var name = "Gamma";
            var expected = TestEnum.Gamma;

            var value = TestEnum.GetValue(name);

            Assert.Equal(expected, value);
        }

        [Fact]
        public void GetIds_ShouldReturnIds()
        {
            var expected = new List<int> { 0, 1, 2, 3 };

            var ids = TestEnum.GetIds();

            Assert.Equal(expected, ids);
        }

        [Fact]
        public void Enum_ShouldReturnEnumId_WhenExplicitlyToInt()
        {
            var testEnum = TestEnum.Beta;
            var expected = 1;

            var id = (int)testEnum;

            Assert.Equal(expected, id);
        }

        [Fact]
        public void Enum_ShouldReturnEnum_WhenExplicitlyCastFromEnumId()
        {
            var id = 3;
            var expected = TestEnum.Delta;

            var castEnum = (TestEnum)id;

            Assert.Equal(expected, castEnum);
        }
    }
}
