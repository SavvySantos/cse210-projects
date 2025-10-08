using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello World! This is the Shapes Project.");
        Console.WriteLine("");

        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 2.5));
        shapes.Add(new Rectangle("Pink", 3.2, 5.5));
        shapes.Add(new Circle("Purple", 3.5));

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            string color = shape.GetColor();

            Console.WriteLine($"The area for the {shape} is {area:F2} and the color is {color}.");
        }
        Console.WriteLine("");
    }
}