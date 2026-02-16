using System.Security.Cryptography;

public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle (string Color, double length, double width) : base (Color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}