Console.WriteLine("Hello, World!");


var square = new Square(5);
var rectangle = new Rectangle(4, 6);
var circle = new Circle(3);

var shapes = new Shape[] { square, rectangle, circle };

var totalShapesAreas = ShapeUtils.CalculateTotalArea(shapes);
var shapesAreas = ShapeUtils.GetShapesAreas(shapes);
System.Console.WriteLine($"Total shapes areas = {totalShapesAreas}");

foreach (var area in shapesAreas)
{
  System.Console.WriteLine($"Shape {area}");

}
public static class ShapeUtils
{
  public static double CalculateTotalArea(Shape[] shapes)
  {
    double total = 0;
    foreach (var shape in shapes)
    {
      total += shape.CalculateArea();
    }
    return Math.Round(total, 2);
  }
  public static List<double> GetShapesAreas(Shape[] shapes)
  {
    var areas = new List<double>();
    foreach (var shape in shapes)
    {
      areas.Add(shape.CalculateArea());
    }
    return areas;
  }
}
public abstract class Shape
{
  public abstract double CalculateArea();
}

public class Square : Shape
{
  public double Side { get; }
  public Square(double side)
  {
    Side = side;
  }
  public override double CalculateArea()
  {
    return Side * Side;
  }
}

public class Rectangle : Shape
{
  public double Width { get; }
  public double Height { get; }

  public Rectangle(double width, double height)
  {
    Width = width;
    Height = height;
  }
  public override double CalculateArea()
  {
    return Width * Height;
  }
}

public class Circle : Shape
{
  public double Radius { get; }
  public Circle(double radius)
  {
    Radius = radius;
  }

  public override double CalculateArea()
  {
    return Math.Round(Math.PI * Radius * Radius, 2);
  }
}
