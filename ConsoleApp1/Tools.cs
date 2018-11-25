using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Tools
    {
        public static void Color(string str, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(str);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
        public static void Dostors(Department sec)
        {
            int sequence = 1;
            foreach (var item in sec.doctors)
            {
                Console.WriteLine($"{sequence++}. {item.name} {item.surname}. Experience {item.experience} year");
            }
        }
        public static void DoctorTimes(Department sec, int DoctorChoice)
        {
            int sequence = 1;
            foreach (var item in sec.doctors[DoctorChoice - 1].WorkTimes)
            {
                if (item.Value)
                {
                    Console.Write($"{sequence++}. {item.Key} : ");
                    Color("Busy", ConsoleColor.Red);
                }
                else
                {
                    Console.Write($"{sequence++}. {item.Key} : ");
                    Color("Available", ConsoleColor.Green);
                }
            }
        }
        public static void TimeRegistration(Department sec, int DoctorChoice)
        {
            while (true) {
                DoctorTimes(sec, DoctorChoice);
                if (sec.doctors[DoctorChoice - 1].WorkTimes["09:00-11:00"] && sec.doctors[DoctorChoice - 1].WorkTimes["12:00-14:00"] && sec.doctors[DoctorChoice - 1].WorkTimes["15:00-17:00"])
                {
                    Color("Doctor doesn't have spare time today !", ConsoleColor.DarkRed);
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    break;
                }
                Console.Write("\nYour choice : ");
                var tmp = Console.ReadLine();
                if (!int.TryParse(tmp, out int TimeChoice))
                {
                    Console.Clear();
                    Console.WriteLine("Invalid entry ! Enter again.");
                }
                if (TimeChoice == 1)
                {
                    if (sec.doctors[DoctorChoice - 1].WorkTimes["09:00-11:00"])
                    {
                        Console.Clear();
                        Color("ERROR : Doctor is busy in that time", ConsoleColor.Red);
                    }
                    else
                    {
                        Console.Clear();
                        Color($"You have been successfully registered for Doctor {sec.doctors[DoctorChoice-1].name} !", ConsoleColor.Green);
                        sec.doctors[DoctorChoice - 1].WorkTimes["09:00-11:00"] = true;
                        break;
                    }
                }
                else if (TimeChoice == 2)
                {
                    if (sec.doctors[DoctorChoice - 1].WorkTimes["12:00-14:00"])
                    {
                        Console.Clear();
                        Color("ERROR : Doctor is busy in that time", ConsoleColor.Red);
                    }
                    else
                    {
                        Console.Clear();
                        Color($"You have been successfully registered for Doctor {sec.doctors[DoctorChoice-1].name} !", ConsoleColor.Green);
                        sec.doctors[DoctorChoice - 1].WorkTimes["12:00-14:00"] = true;
                        break;
                    }
                }
                else if (TimeChoice == 3)
                {
                    if (sec.doctors[DoctorChoice - 1].WorkTimes["15:00-17:00"])
                    {
                        Console.Clear();
                        Color("ERROR : Doctor is busy in that time", ConsoleColor.Red);
                    }
                    else
                    {
                        Console.Clear();
                        Color($"You have been successfully registered for Doctor {sec.doctors[DoctorChoice-1].name} !", ConsoleColor.Green);
                        sec.doctors[DoctorChoice - 1].WorkTimes["15:00-17:00"] = true;
                        break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.Write("Wrong choice. Enter again : ");
                }
            }
        }
    }
}
