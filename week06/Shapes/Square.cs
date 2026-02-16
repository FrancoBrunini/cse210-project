public class Square : Shape
{
    private double _side;
    public Square (string Color, double side) : base (Color)
    {
        _side = side;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}