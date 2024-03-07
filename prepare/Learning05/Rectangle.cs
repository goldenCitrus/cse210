using System.Reflection.Metadata.Ecma335;

public class Rectangle : Shape
{

    public Rectangle(string color, double recBase, double height) : base(color)
    {
        _recBase = recBase;
        _height = height;
    }

    private double _recBase;
    private double _height;

    public override double GetArea()
    {
        return _recBase * _height;
    }

}