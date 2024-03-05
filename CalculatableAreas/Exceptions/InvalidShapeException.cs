using System;

namespace CalculatableAreas.Exceptions;

/// <summary>
/// Purpose: Exception class for invalid shape dimensions
/// </summary>
public class InvalidShapeException : ArgumentException
{
    public InvalidShapeException() : base("Invalid shape dimensions. The shape cannot exist.")
    {
    }

    public InvalidShapeException(string message) : base(message)
    {
    }

    public InvalidShapeException(string message, Exception innerException) : base(message, innerException)
    {
    }
}