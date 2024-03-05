**Area Calculator** is a client library that provides a set of classes and methods to calculate the area of different geometric shapes.

Example of usage:
```csharp
using AreaCalculator;
...
var circle = new Circle(5);
var area = circle.CalculateArea();

var triangle = new Triangle(3, 4, 5);
area = triangle.CalculateArea();
```

Define your own shapes by implementing the `ICalculatableArea` interface:

```csharp
public class Rectangle : ICalculatableArea
{
    public double CalculateArea()
    {
        // Your implementation goes here
    }
}
```