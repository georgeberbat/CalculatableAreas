using System;
using System.Collections.Generic;
using System.Linq;
using CalculatableAreas.Exceptions;

namespace CalculatableAreas.Areas;

/// <summary>
/// Represents a triangle
/// </summary>
public class Triangle : ICalculatableArea
{
    private readonly IEnumerable<double> _sides;

    /// <summary>
    /// Creates a triangle with given sides
    /// </summary>
    /// <param name="sideA">Side of the triangle</param>
    /// <param name="sideB">Side of the triangle</param>
    /// <param name="sideC">Side of the triangle</param>
    /// <exception cref="NegativeValueException"> Thrown when any of the sides is less than or equal to 0 </exception>
    /// <exception cref="InvalidShapeException"> Thrown when triangle with such sides does not exist </exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
        {
            throw new NegativeValueException(
                sideA <= 0 ? nameof(sideA) : sideB <= 0 ? nameof(sideB) : nameof(sideC),
                "Sides must be greater than 0");
        }

        var sides = new[] { sideA, sideB, sideC };

        var isTriangle = sides.OrderBy(x => x).Take(2).Sum() > sides.Max();

        if (!isTriangle)
        {
            throw new InvalidShapeException("Triangle with such sides does not exist");
        }

        _sides = sides;
    }

    public double CalculateArea()
    {
        var isRightTriangle =
            Math.Abs(_sides
                .OrderBy(x => x)
                .Take(2)
                .Aggregate((a, b) => Math.Pow(a, 2) + Math.Pow(b, 2)) - Math.Pow(_sides.Max(), 2))
            <= double.Epsilon;

        if (isRightTriangle)
            return _sides.OrderBy(x => x).Take(2).Aggregate((a, b) => a * b) / 2;

        var halfPerimeter = _sides.Sum() / 2;
        return Math.Sqrt(halfPerimeter * _sides.Aggregate((a, b) => a * (halfPerimeter - b)));
    }
}