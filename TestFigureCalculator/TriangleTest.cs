using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;

[TestFixture]
public class TriangleTests
{
    [Test] //Тест на расчет площади треугольника
    public void CalculateArea_WithRightTriangle_ReturnsCorrectArea() 
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.CalculateArea();

        // Assert
        Assert.AreEqual(6, result);
    }

    [Test] //Тест на определение является ли треугольник прямоугольным (true)
    public void IsRightTriangle_WithRightTriangle_ReturnsTrue() 
    {
        // Arrange & Act
        var result = Triangle.IsRightTriangle(3, 4, 5);

        // Assert
        Assert.IsTrue(result);
    }

    [Test] //Тест на определение является ли треугольник прямоугольным (false)
    public void IsRightTriangle_WithNonRightTriangle_ReturnsFalse() 
    {
        // Arrange & Act
        var result = Triangle.IsRightTriangle(3, 4, 6);

        // Assert
        Assert.IsFalse(result);
    }

    [Test] //Тест на определение отрицательных значений
    public void CalculateArea_WithNegativeSides_ThrowsArgumentException()
    {
        // Arrange
        double sideA = -3;
        double sideB = -4;
        double sideC = -5;

        // Act        
        var ex = Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));

        // Assert: Проверяем результат        
        Assert.That(ex.Message, Is.EqualTo("Длины сторон должны быть положительными. (Parameter 'sideA')"));
    }


}
