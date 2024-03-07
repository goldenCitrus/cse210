using System.Diagnostics;

public abstract class SmartDevice
{

    public SmartDevice(string name)
    {
        _name = name;
    }

    public string SinceWhen(SmartDevice device)
    {
        return $"{device._name} has been on for {stopwatch.ElapsedMilliseconds/100} seconds";
    }

    public bool _isOn;
    public string _name;
    protected Stopwatch stopwatch = new Stopwatch();
    public long _howLong;

    public abstract void ChangeState(); // turn on or off



}