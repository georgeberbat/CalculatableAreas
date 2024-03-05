using System.Collections.Generic;
using System.Linq;
using CalculatableAreas.Areas;
using FluentAssertions;
using Xunit;

namespace CalculatableAreas.Tests;

public class DeveloperTests
{
    [Fact]
    public void ShouldCalculateArea()
    {
        var areas = new List<ICalculatableArea>
        {
            new Circle(3),
            new Triangle(3, 4, 5)
        };

        areas.First().CalculateArea().Should().Be(28.274333882308138);
        areas.Last().CalculateArea().Should().Be(6);
    }
}