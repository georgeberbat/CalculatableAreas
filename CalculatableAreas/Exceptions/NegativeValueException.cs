using System;

namespace CalculatableAreas.Exceptions;

/// <summary>
/// Purpose: Exception class for values that are not allowed to be negative
/// </summary>
public class NegativeValueException : ArgumentOutOfRangeException
{
    public NegativeValueException(string paramName) : base(paramName,
        "Negative values are not allowed for geometric shapes.")
    {
    }

    public NegativeValueException(string paramName, string message) : base(paramName, message)
    {
    }
}