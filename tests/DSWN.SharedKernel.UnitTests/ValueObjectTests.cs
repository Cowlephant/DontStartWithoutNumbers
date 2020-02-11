using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace DSWN.SharedKernel.UnitTests
{
    public class ValueObjectTests
    {
        private ValueObjectTest valueObjectA;
        private ValueObjectTest valueObjectAclone;

        public ValueObjectTests()
        {
            valueObjectA = new ValueObjectTest("Value Object A", 10)
            .WithChildObjects(new List<ValueObjectTest> {
                new ValueObjectTest("Child A", 5),
                new ValueObjectTest("Child B", 20)
            });

            valueObjectAclone = new ValueObjectTest("Value Object A", 10)
                .WithChildObjects(new List<ValueObjectTest> {
                    new ValueObjectTest("Child A", 5),
                    new ValueObjectTest("Child B", 20)
            });
        }

        [Fact]
        public void ValueObjectTest_ShouldBeEqual_WhenPropertiesAreEqual()
        {
            var valueObjectA = this.valueObjectA;

            var expected = valueObjectAclone;

            Assert.Equal(expected, valueObjectA);
        }

        [Fact]
        public void ValueObjectTest_ShouldBeEqual_WhenCollectionsHaveCollections()
        {
            var valueObjectA = new ValueObjectTest("Value Object A", 10)
            .WithChildObjects(new List<ValueObjectTest> {
                new ValueObjectTest("Child A", 5)
                    .WithChildObjects(new List<ValueObjectTest> {
                        new ValueObjectTest("Child A.1", 5),
                        new ValueObjectTest("Child A.2", 20)
                    })
            });

            var expected = new ValueObjectTest("Value Object A", 10)
                .WithChildObjects(new List<ValueObjectTest> {
                new ValueObjectTest("Child A", 5)
                    .WithChildObjects(new List<ValueObjectTest> {
                        new ValueObjectTest("Child A.1", 5),
                        new ValueObjectTest("Child A.2", 20)
                    })
            });

            Assert.Equal(expected, valueObjectA);
        }

        [Fact]
        public void ValueObjectTest_ShouldBeEqual_WhenCollectionsAreNull()
        {
            var valueObjectA = new ValueObjectTest("Value Object A", 10);

            var expected = new ValueObjectTest("Value Object A", 10);

            Assert.Equal(expected, valueObjectA);
        }

        [Fact]
        public void GetHashCode_ShouldBeEqual_WhenPropertiesAreEqual()
        {
            var hashA = valueObjectA.GetHashCode();
            var hashB = valueObjectAclone.GetHashCode();

            Assert.Equal(hashB, hashA);
        }

        [Fact]
        public void GetHashCode_ShouldNotBeEqual_WhenTypesAreDifferent()
        {
            var hashA = new ValueObjectDiffATest("Value Object A", 10).GetHashCode();
            var hashB = new ValueObjectDiffBTest("Value OBject A", 10).GetHashCode();

            Assert.NotEqual(hashB, hashA);
        }

        [Fact]
        public void EqualityOperator_ShouldBeTrue_WhenPropertiesAreEqual()
        {
            var result = valueObjectA == valueObjectAclone;

            Assert.True(result);
        }

        [Fact]
        public void ShallowCopy_ShouldBeEqual_WhenCompared()
        {
            var valueObjectA = new ValueObjectTest("Value Object A", 10)
            .WithChildObjects(new List<ValueObjectTest> {
                new ValueObjectTest("Child A", 5)
                    .WithChildObjects(new List<ValueObjectTest> {
                        new ValueObjectTest("Child A.1", 5),
                        new ValueObjectTest("Child A.2", 20)
                    })
            });

            var copy = valueObjectA.ShallowCopy();

            Assert.Equal(copy, valueObjectA);
        }

#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        [Fact]
        public void ValueObjectTest_ShouldNotBeEqual_WhenOneIsNull()
        {
            var valueObjectA = this.valueObjectA;
            ValueObject? valueObjectB = null;

            Assert.NotEqual(valueObjectB, valueObjectA);
            Assert.False(valueObjectA.Equals(valueObjectB));
        }

        [Fact]
        public void ValueObjectTest_ShouldNotBeEqual_WhenTypesAreDifferent()
        {
            var diffValueObjectA = new ValueObjectDiffATest("Value Object A", 10);
            var diffValueObjectB = new ValueObjectDiffBTest("Value OBject A", 10);

            Assert.NotEqual((ValueObject)diffValueObjectA, (ValueObject)diffValueObjectB);
            Assert.False(diffValueObjectA.Equals(diffValueObjectB));
        }

        [Fact]
        public void EqualityOperator_ShouldBeTrue_WhenBothAreNull()
        {

            ValueObjectTest valueObjectA = null;
            ValueObjectTest valueObjectB = null;

            var result = valueObjectA == valueObjectB;

            Assert.True(result);
        }

        [Fact]
        public void EqualityOperator_ShouldBeFalse_WhenOneIsNull()
        {
            var valueObjectA = this.valueObjectA;
            ValueObjectTest valueObjectB = null;

            var result = valueObjectA == valueObjectB;

            Assert.False(result);
        }

        [Fact]
        public void InequalityOperator_ShouldBeFalse_WhenBothAreNull()
        {

            ValueObjectTest valueObjectA = null;
            ValueObjectTest valueObjectB = null;

            var result = valueObjectA != valueObjectB;

            Assert.False(result);
        }

        [Fact]
        public void InequalityOperator_ShouldBeTrue_WhenOneIsNull()
        {
            var valueObjectA = this.valueObjectA;
            ValueObjectTest valueObjectB = null;

            var result = valueObjectA != valueObjectB;

            Assert.True(result);
        }
#pragma warning restore CS8604 // Possible null reference argument.
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    }

    public class ValueObjectTest : ValueObject
    {
        public string Name { get; private set; }
        public int Value { get; private set; }
        public IReadOnlyList<ValueObjectTest> ChildObjects { get; private set; } =
            new List<ValueObjectTest>().AsReadOnly();
        public ValueObjectTest(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public ValueObjectTest WithChildObjects(IEnumerable<ValueObjectTest> children)
        {
            ChildObjects = children.ToList().AsReadOnly();
            return this;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Value;
            foreach (var child in ChildObjects)
                yield return child;
        }
    }

    // This is used for comparison with ValueObjectDiffBTest
    // The properties are the exact same, but it's a different ValueObject class
    public class ValueObjectDiffATest : ValueObject
    {
        public string Name { get; private set; }
        public int Value { get; private set; }

        public ValueObjectDiffATest(string name, int value)
        {
            Name = name;
            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Value;
        }
    }

    // See ValueObjectDiffATest
    public class ValueObjectDiffBTest : ValueObject
    {
        public string Name { get; private set; }
        public int Value { get; private set; }

        public ValueObjectDiffBTest(string name, int value)
        {
            Name = name;
            Value = value;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return Value;
        }
    }
}
