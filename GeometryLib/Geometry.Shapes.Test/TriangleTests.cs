using System;
using NUnit.Framework;

namespace Geometry.Shapes.Test;

public class TriangleTests
{
    [TestCase(-1, 1, 1)]
    [TestCase(1, -1, 1)]
    [TestCase(1, 1, -1)]
    [TestCase(1, 1, 0)]
    [TestCase(1, 0, 1)]
    [TestCase(0, 1, 1)]
    [TestCase(10, 1, 1)]
    [TestCase(1, 10, 1)]
    [TestCase(1, 1, 10)]
    public void TriangleValidation_InvalidEdges_ThrowsException(double a, double b, double c)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
    }

    [TestCase(1, 1, 1, ExpectedResult = false)]
    [TestCase(3, 4, 5, ExpectedResult = true)]
    public bool IsRightTriangle_Edges_CorrectResult(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);
        return triangle.IsRightTriangle;
    }

    [TestCase(2.5,4.6,5.7)]
    [TestCase(3,4,5)]
    public void CalculateArea_Edges_CorrectResult(double a, double b, double c)
    {
        var p = (a + b + c) / 2;
        var result = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        Assert.AreEqual(result, new Triangle(a,b,c).CalculateArea());
    }

}