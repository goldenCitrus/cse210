using System;

class Program
{
    static void Main(string[] args)
    {

        List<Shape> shapes = new List<Shape>();

        Square square = new Square("blue", 12);
        shapes.Add(square);

        // double squarea = square.GetArea();
        // string squolor = square.GetColor();

        // Console.WriteLine($"Squarea = {squarea}\nSquolor = {squolor}\n");


        Rectangle rectangle = new Rectangle("orple", 25.9, 38);
        shapes.Add(rectangle);

        // double rectarea = rectangle.GetArea();
        // string rectolor = rectangle.GetColor();

        // Console.WriteLine($"Rectarea = {rectarea}\nRectolor = {rectolor}\n");


        Circle circle = new Circle("Lellow", 8.5);
        shapes.Add(circle);

        // double circarea = circle.GetArea();
        // string circolor = circle.GetColor();

        // Console.WriteLine($"Circarea = {circarea}\nCircolor = {circolor}\n");

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape} is {shape.GetColor()}, and has a radius of {shape.GetArea()}");
        }


    }
}