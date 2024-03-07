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
                    Console.WriteLine("1. Turn on all lights\n2. Turn all lights off\n3. Turn on all devices\n4. Turn off all devices\n5. Status report all devices\n6. Status report all on devices\n7.Report longest powered on devices\n8. Exit\nWhat would you like to do");
                    string input = Console.ReadLine();
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

                    } else if (input == "3"){

                    } else if (input == "4"){

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
                            }
                        }
                        foreach (SmartDevice device in livingRoom.smartDevices)
                        {
                            if (device._isOn)
                            {
                                Console.WriteLine($"{device._name} is on");
                            }
                        }
                    } else if (input == "7"){

                    } else if (input == "8"){

                    } else {Console.WriteLine($"Invalid input '{input}'");}
                }
            }
            else if (house._curerntRoom == "bedroom")
            {
                BedRoom bedRoom = new BedRoom("bedroom");
                bool pelasepelaseplaese = true;
                while (pelasepelaseplaese == true)
                {
                    Console.WriteLine("1. Turn on all lights\n2. Turn all lights off\n3. Turn on all devices\n4. Turn off all devices\n5. Status report all devices\n6. Status report all on devices\n7.Report longest powered on devices\n8. Exit\nWhat would you like to do");
                    string input = Console.ReadLine();
                    if (input == "1")
                    {

                    } else if (input == "2"){

                    } else if (input == "3"){

                    } else if (input == "4"){

                    } else if (input == "5"){

                    } else if (input == "6"){

                    } else if (input == "7"){

                    } else if (input == "8"){

                    } else {Console.WriteLine($"Invalid input '{input}'");}
                }
            }
        }
    }
}