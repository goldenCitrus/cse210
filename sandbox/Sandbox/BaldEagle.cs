class BaldEagle : Animal 
{
    public BaldEagle(string name, string noise) : base(name, noise)
    {

    }
    public override void MakeSound()
    {
        Console.WriteLine($"{this.name} says: {this.noise}");
    }
}