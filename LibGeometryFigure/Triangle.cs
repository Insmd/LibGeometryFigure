public class Triangle : IFigure
{
    private double sideA;
    private double sideB;
    private double sideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        //Проверяем что введенные данные имеют положительное значение
        if (sideA < 0 || sideB < 0 || sideC < 0)
            throw new ArgumentException("Длины сторон должны быть положительными.", nameof(sideA));

        this.sideA = sideA;
        this.sideB = sideB;
        this.sideC = sideC;
    }

    public static bool IsRightTriangle(double sideA, double sideB, double sideC) //Проверяем является ли треугольник прямоугольным
    {
        double[] sides = { sideA, sideB, sideC };
        Array.Sort(sides);

        return Math.Abs(Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) - Math.Pow(sides[2], 2)) < 1e-10;
    }

    public double CalculateArea() //Расчитываем площадь треугольника
    {        
        // Вычисляем полупериметр треугольника
        double semiPerimeter = (sideA + sideB + sideC) / 2;

        // Используем формулу Герона для вычисления площади
        return Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
    }
}
