using SquareShapeLibrary.Interfaces;
using SquareShapeLibrary.Models;
using SquareShapeLibrary.Services;

namespace SquareShapeLibrary;
public class Program
{
    private static void Main(string[] args)
    {
        #region Написал хуйню
        //Console.WriteLine("Введите фигуру  Circle или Triagnle");
        //var result = Console.ReadLine();

        //if (result == "Circle")
        //{
        //    Console.WriteLine("Введите радиус окружности: ");

        //    var shapeCircle = new Circle();
        //    shapeCircle.Radius = double.Parse(Console.ReadLine());
        //}

        //if(result == "Triagnle")
        //{
        //    Console.WriteLine("Введите стороны треугольника: ");

        //    var shapeTriangle = new Triangle();

        //    var sideA = shapeTriangle.SideA = double.Parse(Console.ReadLine());
        //    var sideB = shapeTriangle.SideB = double.Parse(Console.ReadLine());
        //    var sideC = shapeTriangle.SideC = double.Parse(Console.ReadLine());
        //}

        //var shape = new ShapeCalculator().AreaCalculate()
        #endregion

        IShapeCalculator shapeCalculator = new ShapeCalculator();

        var circle = new Circle { Type = "Circle", Radius = 10 };
        var triangle = new Triangle { Type = "Triangle", SideA = 5, SideB = 3, SideC = 8 };
        var isRightTriangle = new Triangle { Type = "Triangle", SideA = 1, SideB = 2, SideC = 3 };

        var resultShapeCircle = shapeCalculator.AreaCalculate(circle);
        Console.WriteLine($"Площадь окрудности : {resultShapeCircle}");

        var resultShapeTriangle = shapeCalculator.AreaCalculate(triangle);
        Console.WriteLine($"Площадь треугольника : {resultShapeTriangle}");

        var resultIsRightTriangle = shapeCalculator.IsRightTriangle(isRightTriangle);
        Console.WriteLine($"Треугольник прямоугольный? : {resultIsRightTriangle}");




    }


}