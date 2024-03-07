public class House
{
    public House(string currentRoom)
    {
        _curerntRoom = currentRoom;
    }
    List<string> _rooms = new List<string>() {"living room", "bedroom"};
    public string _curerntRoom;

    private string _chosenRoom;
    private int _parsedRoom;

    public void ChangeRoom()
    {
        while (!_rooms.Contains(_chosenRoom) || (int.TryParse(_chosenRoom, out _parsedRoom) && _rooms.Contains(_rooms[_parsedRoom - 1])))
        {
            int listNum = 1;
            foreach (string room in _rooms)
            {
                Console.WriteLine($"{listNum}. {room}");
                listNum ++;
            }
            Console.WriteLine("Which room would you like to move to:");
            _chosenRoom = Console.ReadLine();

            if (_rooms.Contains(_chosenRoom.ToLower()))
            {
                _curerntRoom = _chosenRoom.ToLower();
                break;
            } else {
                if ((int.TryParse(_chosenRoom, out _parsedRoom) && _rooms.Contains(_rooms[_parsedRoom - 1])))
                {
                    _curerntRoom = _rooms[_parsedRoom - 1];
                    break;
                }
                else
                {
                    Console.WriteLine($"Invalid input '{_chosenRoom}'");
                }
            }
        }
    }


}