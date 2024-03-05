namespace CalculatableAreas;

/// <summary>
/// Inherit it to define custom areas
/// </summary>
public interface ICalculatableArea
{
    /// <summary>
    /// Calculate area of the shape
    /// </summary>
    /// <returns>
    /// Area of the shape
    /// </returns>
    double CalculateArea();
}