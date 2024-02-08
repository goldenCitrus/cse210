using System;

class Program
{
    static void Main(string[] args)
    {
        BaldEagle joey = new BaldEagle("Joey", "boing!");
        BaldEagle dragon = new BaldEagle("Dragon", "Shpipple");

        joey.MakeSound();
        dragon.MakeSound();
    }
}