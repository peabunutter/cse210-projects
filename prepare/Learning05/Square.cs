public class Square : Shape
{
    private double _side;

    public Square() : base()
    {
        Console.WriteLine("Choose a color for the Square");
        _color = Console.ReadLine();
        Console.WriteLine("Enter side");
        _side = Convert.ToDouble(Console.ReadLine());
    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}