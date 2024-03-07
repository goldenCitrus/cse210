using System;

class Program
{
    static void Main(string[] args)
    {
        House house = new House("living room");
        bool pleaseworkwplease = true;
        while (pleaseworkwplease == true)
        {
            house.ChangeRoom();
            if (house._curerntRoom == "living room")
            {
                LivingRoom livingRoom = new LivingRoom("living room");
                bool pelasepelaseplaese = true;
                while (pelasepelaseplaese == true)
                {
                    List<string> numbers = new List<string>() {"1","2","3","4","5","6","7","8"};
                    Console.WriteLine("1. Turn on all lights\n2. Turn all lights off\n3. Turn on all devices\n4. Turn off all devices\n5. Status report all devices\n6. Status report all on devices\n7. Report longest powered on devices\n8. Exit\nWhat would you like to do");
                    string input = Console.ReadLine();
                    Console.Clear();
                    if (input == "1")
                    {
                        foreach (SmartDevice light in livingRoom.smartDevices)
                        {
                            if (!light._isOn && light.GetType() == typeof(SmartLight))
                            {
                                light.ChangeState();
                            }
                        }
                    } else if (input == "2"){
                         foreach (SmartDevice light in livingRoom.smartDevices)
                        {
                            if (light._isOn && light.GetType() == typeof(SmartLight))
                            {
                                light.ChangeState();
                            }
                        }
                    } else if (input == "3"){
                         foreach (SmartDevice device in livingRoom.smartDevices)
                        {
                            if (!device._isOn)
                            {
                                device.ChangeState();
                            }
                        }
                    } else if (input == "4"){
                        foreach (SmartDevice device in livingRoom.smartDevices)
                        {
                            if (device._isOn)
                            {
                                device.ChangeState();
                            }
                        }
                    } else if (input == "5"){
                        foreach (SmartDevice light in livingRoom.smartDevices)
                        {
                            if (light._isOn)
                            {
                                Console.WriteLine($"{light._name} is on");
                            }
                            else
                            {
                                Console.WriteLine($"{light._name} is off");
                            }
                        }
                    } else if (input == "6"){
                        foreach (SmartDevice device in livingRoom.smartDevices)
                        {
                            if (device._isOn)
                            {
                                Console.WriteLine($"{device._name} is on");
                            } else {
                                Console.WriteLine($"{device._name} is off");
                            }
                        }
                    } else if (input == "7"){
                        List<string> times = new List<string>();
                        foreach (SmartDevice device in livingRoom.smartDevices)
                        {
                            if (device._isOn)
                            {
                                    times.Add($"{device._name} has been on for {device.SinceWhen(device)} seconds");
                            } else {
                                Console.WriteLine("There are no devices powered on");
                                break;
                            }
                        }
                        foreach (string item in times)
                        {
                            Console.WriteLine(item);
                        }
                    } else if (input == "8"){
                        pelasepelaseplaese = false;
                    } else if (!numbers.Contains(input)){
                        Console.WriteLine($"Invalid input '{input}'");
                    }
                }
                break;
            }
            else if (house._curerntRoom == "bedroom")
            {
                BedRoom bedRoom = new BedRoom("bedroom");
                bool idekman = true;
                while (idekman == true)
                {
                    List<string> numbers = new List<string>() {"1","2","3","4","5","6","7","8"};
                    Console.WriteLine("1. Turn on all lights\n2. Turn all lights off\n3. Turn on all devices\n4. Turn off all devices\n5. Status report all devices\n6. Status report all on devices\n7. Report longest powered on devices\n8. Exit\nWhat would you like to do");
                    string input = Console.ReadLine();
                    Console.Clear();
                    if (input == "1")
                    {
                        foreach (SmartDevice light in bedRoom.smartDevices)
                        {
                            if (!light._isOn && light.GetType() == typeof(SmartLight))
                            {
                                light.ChangeState();
                            }
                        }
                    } else if (input == "2"){
                         foreach (SmartDevice light in bedRoom.smartDevices)
                        {
                            if (light._isOn && light.GetType() == typeof(SmartLight))
                            {
                                light.ChangeState();
                            }
                        }
                    } else if (input == "3"){
                         foreach (SmartDevice device in bedRoom.smartDevices)
                        {
                            if (!device._isOn)
                            {
                                device.ChangeState();
                            }
                        }
                    } else if (input == "4"){
                        foreach (SmartDevice device in bedRoom.smartDevices)
                        {
                            if (device._isOn)
                            {
                                device.ChangeState();
                            }
                        }
                    } else if (input == "5"){
                        foreach (SmartDevice light in bedRoom.smartDevices)
                        {
                            if (light._isOn)
                            {
                                Console.WriteLine($"{light._name} is on");
                            }
                            else
                            {
                                Console.WriteLine($"{light._name} is off");
                            }
                        }
                    } else if (input == "6"){
                        foreach (SmartDevice device in bedRoom.smartDevices)
                        {
                            if (device._isOn)
                            {
                                Console.WriteLine($"{device._name} is on");
                            } else {
                                Console.WriteLine($"{device._name} is off");
                            }
                        }
                    } else if (input == "7"){
                        List<string> times = new List<string>();
                        foreach (SmartDevice device in bedRoom.smartDevices)
                        {
                            if (device._isOn)
                            {
                                    times.Add($"{device._name} has been on for {device.SinceWhen(device)} seconds");
                            } else {
                                Console.WriteLine("There are no devices powered on");
                                break;
                            }
                        }
                        foreach (string item in times)
                        {
                            Console.WriteLine(item);
                        }
                    } else if (input == "8"){
                        idekman = false;
                    } else if (!numbers.Contains(input)){
                        Console.WriteLine($"Invalid input '{input}'");
                    }
                }
                break;
            }
        }
    }
}