using CalculatableAreas.Areas;
using CalculatableAreas.Exceptions;
using FluentAssertions;
using Xunit;

namespace CalculatableAreas.Tests;

public class CircleTests
{
    [Fact]
    public void ShouldValidateCircleRadius_Negative()
    {
        var action = () => new Circle(-1);
        action.Should().ThrowExactly<NegativeValueException>().WithParameterName("radius");
    }
    
    [Fact]
    public void ShouldValidateCircleRadius_Positive()
    {
        var action = () => new Circle(1);
        action.Should().NotThrow<NegativeValueException>();
    }
    
    [Fact]
    public void ShouldCalculateCircleArea()
    {
        var circle = new Circle(3);
        circle.CalculateArea().Should().Be(28.274333882308138);
    }
}