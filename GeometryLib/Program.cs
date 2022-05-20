// See https://aka.ms/new-console-template for more information

using Geometry.Shapes;
using Geometry.Shapes.Interfaces;

Console.WriteLine("Hello, World!");
var triangle = new Triangle(1, 1, 1);
var circle = new Circle(5);
LogArea(triangle);
LogArea(circle);
Console.WriteLine(triangle.IsRightTriangle);
Console.WriteLine(new Triangle(3,4,5).IsRightTriangle);

void LogArea(I2DShape shape)
{
    Console.WriteLine(shape.CalculateArea());
}