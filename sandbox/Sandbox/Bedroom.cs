public class BedRoom : House
{
    
    public List<SmartDevice> smartDevices = new List<SmartDevice>();

    SmartLight _smartLight = new SmartLight("Light 1");
    SmartLight _smartLight2 = new SmartLight("Light 2");
    
    public BedRoom(string currentRoom) : base(currentRoom)
    {
        smartDevices.Add(_smartLight);
        smartDevices.Add(_smartLight2);
    }
    


}