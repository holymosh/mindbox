using System;
using NUnit.Framework;

namespace Geometry.Shapes.Test;

public class CircleTests
{
    [TestCase(-4)]
    [TestCase(0)]
    public void CircleValidation_InvalidRadiusLessThanZero_ThrowsException(double r)
    {
        Assert.Catch<ArgumentException>(() => new Circle(r));
    }

    [TestCase(1)]
    [TestCase(2.5)]
    public void CalcArea_RaduisMoreThanZero_CorrectResult(double r)
    {
        var result = Math.PI * r * r;
        Assert.AreEqual(result, new Circle(r).CalculateArea());
    }


}