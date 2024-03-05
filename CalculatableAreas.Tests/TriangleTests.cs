using CalculatableAreas.Areas;
using CalculatableAreas.Exceptions;
using FluentAssertions;
using Xunit;

namespace CalculatableAreas.Tests;

public class TriangleTests
{
    [Theory]
    [InlineData(-1, 2, 3)]
    [InlineData(1, -2, 3)]
    [InlineData(1, 2, -3)]
    public void ShouldValidateTriangleSides_Negative(double sideA, double sideB, double sideC)
    {
        var action = () => new Triangle(sideA, sideB, sideC);
        var wrongSideName = sideA <= 0 ? nameof(sideA) : sideB <= 0 ? nameof(sideB) : nameof(sideC);
        action.Should().ThrowExactly<NegativeValueException>().WithParameterName(wrongSideName);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 4, 5)]
    [InlineData(5, 12, 13)]
    public void ShouldValidateTriangleSides_Positive(double sideA, double sideB, double sideC)
    {
        var action = () => new Triangle(sideA, sideB, sideC);
        action.Should().NotThrow<NegativeValueException>();
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 4, 8)]
    [InlineData(5, 12, 25)]
    public void ShouldValidateTriangleExistence_Negative(double sideA, double sideB, double sideC)
    {
        var action = () => new Triangle(sideA, sideB, sideC);
        action.Should().Throw<InvalidShapeException>()
            .WithMessage("Triangle with such sides does not exist");
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(3, 4, 5)]
    [InlineData(5, 12, 13)]
    public void ShouldValidateTriangleExistence_Positive(double sideA, double sideB, double sideC)
    {
        var action = () => new Triangle(sideA, sideB, sideC);
        action.Should().NotThrow<InvalidShapeException>();
    }
    
    [Fact]
    public void ShouldCalculateTriangleArea()
    {
        var triangle = new Triangle(3, 4, 5);
        triangle.CalculateArea().Should().Be(6);
    }
}