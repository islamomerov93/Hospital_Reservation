using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Welcome to the Islam's Hospital");
            Department Pediatrics = new Department("Department of Pediatrics");
            Pediatrics.doctors.Add(new Doctor("Tural", "Mustafayev", 15));
            Pediatrics.doctors.Add(new Doctor("Saleh", "Abdullayev", 20));
            Department Traumatology = new Department("Department of Traumatology");
            Traumatology.doctors.Add(new Doctor("Elvin", "Mustafayev", 15));
            Traumatology.doctors.Add(new Doctor("Samir", "Abdullayev", 20));
            Traumatology.doctors.Add(new Doctor("Kamran", "Mustafayev", 15));
            Traumatology.doctors.Add(new Doctor("Elshen", "Abdullayev", 20));
            Department Stomatology = new Department("Department of Stomatology");
            Stomatology.doctors.Add(new Doctor("Elsad", "Mustafayev", 15));
            Stomatology.doctors.Add(new Doctor("Davud", "Abdullayev", 20));
            Stomatology.doctors.Add(new Doctor("Erkin", "Mustafayev", 15));
            while (true)
            {
                try
                {
                    Console.WriteLine("1. Registrate   2. Exit");
                    var tmp = Console.ReadLine();
                    if (!int.TryParse(tmp, out int choice)) throw new Exception("Invalid entry ! Enter again.");
                    if (choice == 1)
                    {
                        Console.Clear();
                        while (true)
                        {
                            Console.Write("Your name             :  ");
                            var name = Console.ReadLine();
                            Console.Write("Your surname          :  ");
                            var surname = Console.ReadLine();
                            Console.Write("Your email            :  ");
                            var email = Console.ReadLine();
                            Console.Write("Your telephone number :  ");
                            var TelNum = Console.ReadLine();
                            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(surname) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(TelNum))
                            {
                                Console.Clear();
                                Console.WriteLine("There are empty fields in registration. Enter again.");
                            }
                            else
                            {
                                User user1 = new User(name, surname, email, TelNum);
                                break;
                            }
                        }
                        Console.Clear();
                        again:;
                        Console.WriteLine("Departments : ");
                        Console.WriteLine("1. Pediatrics");
                        Console.WriteLine("2. Travmatologiya");
                        Console.WriteLine("3. Stomotologiya");
                        Console.Write("\nYour choice :  ");
                        tmp = Console.ReadLine();
                        if (!int.TryParse(tmp, out choice))
                        {
                            Console.Clear();
                            Console.WriteLine("Invalid entry ! Enter again.");
                            goto again;
                        }
                        Console.Clear();
                        switch (choice)
                        {
                            case 1:
                                doctors1:;
                                Console.WriteLine($"{Pediatrics.name}. Doctors :");
                                Tools.Dostors(Pediatrics);
                                Console.WriteLine("\nYour choice : ");
                                tmp = Console.ReadLine();
                                if (!int.TryParse(tmp, out int DoctorChoice) || Convert.ToInt32(tmp) > Pediatrics.doctors.Count() || Convert.ToInt32(tmp) <= 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Invalid entry ! Enter again.");
                                    goto doctors1;
                                }
                                Console.Clear();
                                Console.WriteLine($"{Pediatrics.doctors[DoctorChoice - 1].name} {Pediatrics.doctors[DoctorChoice - 1].surname}");
                                Tools.TimeRegistration(Pediatrics, DoctorChoice);
                                break;
                            case 2:
                                doctors2:;
                                Console.WriteLine($"{Traumatology.name}. Doctors :");
                                Tools.Dostors(Traumatology);
                                Console.WriteLine("\nYour choice : ");
                                tmp = Console.ReadLine();
                                if (!int.TryParse(tmp, out DoctorChoice) || Convert.ToInt32(tmp) > Traumatology.doctors.Count() || Convert.ToInt32(tmp) <= 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Invalid entry ! Enter again.");
                                    goto doctors2;
                                }
                                Console.Clear();
                                Console.WriteLine($"{Traumatology.doctors[DoctorChoice - 1].name} {Traumatology.doctors[DoctorChoice - 1].surname}");
                                Tools.TimeRegistration(Traumatology, DoctorChoice);
                                break;
                            case 3:
                                Console.WriteLine($"{Stomatology.name}. Doctors :");
                                Tools.Dostors(Stomatology);
                                Console.WriteLine("\nYour choice : ");
                                tmp = Console.ReadLine();
                                if (!int.TryParse(tmp, out DoctorChoice) || Convert.ToInt32(tmp) > Stomatology.doctors.Count() || Convert.ToInt32(tmp) <= 0)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Invalid entry ! Enter again.");
                                    goto doctors2;
                                }
                                Console.Clear();
                                Console.WriteLine($"{Stomatology.doctors[DoctorChoice - 1].name} {Stomatology.doctors[DoctorChoice - 1].surname}");
                                Tools.TimeRegistration(Stomatology, DoctorChoice);
                                break;
                            default:
                                Console.WriteLine("Invalid choice! Enter again.");
                                goto again;
                        }
                    }
                    else if (choice == 2) break;
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Wrong choice. Enter again : ");
                    }

                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
