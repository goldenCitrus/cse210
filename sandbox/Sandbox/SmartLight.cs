using System.Diagnostics;

public class SmartLight : SmartDevice
{

    public SmartLight(string name) : base(name)
    {
        _name = name;
    }

    public override void ChangeState()
    {
        if (_isOn)
        {
            _isOn = false;
            _howLong = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"{_name} off");
        } 
        else 
        {
            _isOn = true;
            stopwatch.Start();
            Console.WriteLine($"{_name} on");
        }
    }

}