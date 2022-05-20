using Geometry.Shapes.Interfaces;

namespace Geometry.Shapes;

public class Circle : Base2DShape, I2DShape
{
    public Circle(double r)
    {
        R = r;
        D = r * 2;
        LengthsMoreThanZero("радиус окружности не может быть <= нулю",R);
    }

    public double R { get;}
    public double D { get;}
    
    public override double CalculateArea()
    {
        return Math.PI * R * R;
    }

    public override double CalculatePerimeter()
    {
        return 2 * Math.PI * R;
    }
}