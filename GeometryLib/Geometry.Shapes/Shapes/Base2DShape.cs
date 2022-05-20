using Geometry.Shapes.Interfaces;

namespace Geometry.Shapes;

public abstract class Base2DShape : I2DShape
{
    public abstract double CalculateArea();

    public abstract double CalculatePerimeter();

    protected void LengthsMoreThanZero(string message, params double[] args)
    {
        if (args.Any(d => d <= 0))
        {
            throw new ArgumentException(message);
        }
    }
}