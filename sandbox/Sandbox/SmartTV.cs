using System.Diagnostics;
using System.Globalization;

public class SmartTV : SmartDevice
{

    public SmartTV(string name) : base(name)
    {
        _name = name;
    }

    List<string> channels = new List<string>() {"news", "cartoon network", "pbs", "toonami", "crime tv", "espn"};
    private string _channel;
    private string _chosenChannel;
    private int _parsedChannel;

    public void ChangeChannel()
    {
        while (!channels.Contains(_chosenChannel) || (int.TryParse(_chosenChannel, out _parsedChannel) && channels.Contains(channels[_parsedChannel - 1])))
        {
            int listNum = 1;
            foreach (string channel in channels)
            {
                Console.WriteLine($"{listNum}. {channel}");
                listNum ++;
            }
            Console.WriteLine("What channel would you like to change to:");
            _chosenChannel = Console.ReadLine();

            if (channels.Contains(_chosenChannel.ToLower()))
            {
                _channel = _chosenChannel.ToLower();
                break;
            } else {
                if ((int.TryParse(_chosenChannel, out _parsedChannel) && channels.Contains(channels[_parsedChannel - 1])))
                {
                    _channel = channels[_parsedChannel - 1];
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid input '{_chosenChannel}'");
                }
            }
        }
    }

    public override void ChangeState()
    {
        if (_isOn)
        {
            _isOn = false;
            _howLong = stopwatch.ElapsedMilliseconds;
            _channel = channels[0];
        } 
        else 
        {
            _isOn = true;
            stopwatch.Start();
        }
    }

}