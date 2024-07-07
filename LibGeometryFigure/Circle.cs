public class Circle : IFigure
{
    private double radius;

    public Circle(double radius)
    {   //Проверяем что введенные данные имеют положительное значение
        if (radius < 0)
            throw new ArgumentException("Радиус не может быть отрицательным.", nameof(radius));

        this.radius = radius;
    }

    public double CalculateArea()
    {   // Вычисляем площадь круга    
        return Math.PI * Math.Pow(radius, 2);
    }
}
