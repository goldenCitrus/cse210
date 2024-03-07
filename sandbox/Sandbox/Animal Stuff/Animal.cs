using System;
using System.Security.Cryptography.X509Certificates;

public abstract class Animal
{

    public string name;
    public string noise;
    public Animal(string name, string noise)
    {
        this.name = name;
        this.noise = noise;
    }
    public virtual void MakeSound() {
        Console.WriteLine("noise");
    }
    
}