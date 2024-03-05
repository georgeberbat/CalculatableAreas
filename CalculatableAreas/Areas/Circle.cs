using System;
using CalculatableAreas.Exceptions;

namespace CalculatableAreas.Areas;

/// <summary>
/// Represents a circle
/// </summary>
public class Circle : ICalculatableArea
{
    private readonly double _radius;

    /// <summary>
    /// Creates a circle with given radius
    /// </summary>
    /// <param name="radius">Radius of the circle</param>
    /// <exception cref="NegativeValueException"> Thrown when radius is less than 0 </exception>
    public Circle(double radius)
    {
        if (radius < 0)
        {
            throw new NegativeValueException(nameof(radius), "Radius must be greater than 0 or equal 0");
        }

        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}