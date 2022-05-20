using Geometry.Shapes.Interfaces;

namespace Geometry.Shapes;

public class Triangle : Base2DShape, ITriangle
{
    private void ValidateEdges()
    {
        LengthsMoreThanZero("Стороны треугольника должны быть больше нуля", A, B, C);
        var sum = A + B + C;
        if (new []{A, B, C}.Any((d => sum - d < d)))
            throw new ArgumentException("Сумма двух других сторон должна быть больше третьей стороны");
    }

    public Triangle(double a, double b, double c)
    {
        A = a;
        B = b;
        C = c;
        ValidateEdges();
    }

    public double A { get; }
    public double B { get; }
    public double C { get; }

    public bool IsRightTriangle
    {
        get
        {
            var values = new[] {A, B, C}.OrderBy(d => d).Select(d => d * d).ToArray();
            return values[2] == values[0] + values[1];
        }
    }

    public override double CalculatePerimeter()
    {
        return A + B + C;
    }

    public override double CalculateArea()
    {
        var p = CalculatePerimeter() / 2; // halfperimeter
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}