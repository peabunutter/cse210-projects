using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square();
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        List<Shape> shapes = new List<Shape> {square, circle, rectangle};
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.Color());
            Console.WriteLine("");
        }
    }
}