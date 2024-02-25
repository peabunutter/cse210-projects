public class Shape
{
    protected string _color;
    protected string _shape;
    
    public string Color()
    {
        return _color;
    }

    public virtual double GetArea()
    {
        double placeholder = 2;
        return placeholder;
    }
}