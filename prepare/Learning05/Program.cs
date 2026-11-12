using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Yellow", 5);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Purple", 5, 4);
        shapes.Add(rectangle);

        Circle circle = new Circle("Orange", 2);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}");
            Console.WriteLine($"Area: {shape.GetArea()}");
            Console.WriteLine();
        }  



    }
}