using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("blue", 2);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());
        
        Rectangle rectangle = new Rectangle("red", 2, 3);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle ("purple", 2);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {   
            string color = shape.GetColor();
            Console.WriteLine($"The color is {color}");

            double area = shape.GetArea();
            Console.WriteLine($"The shape's area is: {area}");
        }
    }
}