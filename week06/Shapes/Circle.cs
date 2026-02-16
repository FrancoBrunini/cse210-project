public class Circle : Shape
{
    private double _radius;
    public Circle (string Color, double radius) : base (Color)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}