public abstract class Shape
{

    public Shape(string color)
    {
        SetColor(color);
    }

    protected string _color;

    public string GetColor()
    {
        return _color;
    }
    
    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

}