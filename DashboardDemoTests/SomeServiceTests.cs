using DashboardDemo;
using FluentAssertions;

namespace DashboardDemoTests;

public class SomeServiceTests
{
    [Theory]
    [InlineData(10, false)]
    [InlineData(20, true)]
    [InlineData(30, false)]
    public void IsAdultWorks(int age, bool expected) => SomeService.IsAdult(age).Should().Be(expected);
}
