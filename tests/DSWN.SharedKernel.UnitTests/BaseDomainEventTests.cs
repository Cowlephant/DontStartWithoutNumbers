using NodaTime;
using NodaTime.Testing;
using Xunit;

namespace DSWN.SharedKernel.UnitTests
{
    public class BaseDomainEventTesting : BaseDomainEvent
    {
        public BaseDomainEventTesting(IClock clock) : base(clock) { }
    }

    public class BaseDomainEventTests
    {
        private FakeClock fakeClock;

        public BaseDomainEventTests()
        {
            fakeClock = new FakeClock(Instant.FromUtc(2020, 1, 20, 12, 0, 0)); // 1/20/2020 12:00PM UTC
        }

        [Fact]
        public void DateOcurred_ShouldBeCurrentUtcSystemTime_When_Created()
        {
            var testEvent = new BaseDomainEventTesting(fakeClock);
            var expected = new LocalDateTime(2020, 1, 20, 12, 0, 0);

            Assert.Equal(expected, testEvent.DateOcurred);
        }
    }
}
