namespace Geometry.Shapes.Interfaces;

public interface ITriangle : I2DShape
{
    double A { get; }
    double B { get; }
    double C { get; }
    bool IsRightTriangle { get; }
}