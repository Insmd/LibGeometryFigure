using NUnit.Framework;

[TestFixture]
public class CircleTests
{
    [Test] //���� �� ����������� ������������� ��������
    public void CalculateArea_WithNegativeRadius_ThrowsArgumentException()
    {
        // Arrange
        double radius = -3;

        // Act        
        var ex = Assert.Throws<ArgumentException>(() => new Circle(radius));

        // Assert        
        Assert.That(ex.Message, Is.EqualTo("������ �� ����� ���� �������������. (Parameter 'radius')"));
    }

    [Test] //���� ������� ������� �����
    public void CalculateArea_WithPositiveRadius_ReturnsCorrectArea()
    {
        // Arrange
        double radius = 3;
        double expectedArea = Math.PI * Math.Pow(radius, 2);

        // Act
        var circle = new Circle(radius);
        double actualArea = circle.CalculateArea();

        // Assert        
        Assert.AreEqual(expectedArea, actualArea, 1e-10);
    }
}