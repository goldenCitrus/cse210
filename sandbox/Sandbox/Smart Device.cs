using System.Diagnostics;

public abstract class SmartDevice
{

    public SmartDevice(string name)
    {
        _name = name;
    }
    public bool _isOn;
    public string _name;
    protected Stopwatch stopwatch = new Stopwatch();
    protected long _howLong;

    public abstract void ChangeState(); // turn on or off



}