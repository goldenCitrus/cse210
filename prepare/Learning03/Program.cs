using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        Fraction oneOne = new Fraction();
        Console.WriteLine(oneOne.GetFractionString());
        Console.WriteLine(oneOne.GetDecimalValue());

        Fraction fiveOne =new Fraction(5);
        Console.WriteLine(fiveOne.GetFractionString());
        Console.WriteLine(fiveOne.GetDecimalValue());

        Fraction threeFour =new Fraction(3, 4);
        Console.WriteLine(threeFour.GetFractionString());
        Console.WriteLine(threeFour.GetDecimalValue());

        Fraction oneThree =new Fraction(1, 3);
        Console.WriteLine(oneThree.GetFractionString());
        Console.WriteLine(oneThree.GetDecimalValue());
    }
}