public class Circle : Shape
{
    private double _radius;

    public Circle() : base()
    {
        Console.WriteLine("Choose a color for the circle");
        _color = Console.ReadLine();
        Console.WriteLine("Enter radius");
        _radius = Convert.ToDouble(Console.ReadLine());
    }

    public override double GetArea()
    {
        double area = 3.14 * Math.Pow(_radius, 2);
        return area;
    }
}