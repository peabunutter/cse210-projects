public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle() : base()
    {
        Console.WriteLine("Choose a color for the Rectangle");
        _color = Console.ReadLine();
        Console.WriteLine("Enter Length");
        _length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter width");
        _width = Convert.ToDouble(Console.ReadLine());
    }

    public override double GetArea()
    {
        double area = _length * _width;
        return area;
    }
}