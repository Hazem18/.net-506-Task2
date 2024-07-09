using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Security.Permissions;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            char choice = '\0';
            do
            {
                Console.WriteLine("\nP - Print numbers.");
                Console.WriteLine("A - Add a number.");
                Console.WriteLine("M - Display mean of the numbers.");
                Console.WriteLine("S - Display the smallest number.");
                Console.WriteLine("L - Display the largest number.");
                Console.WriteLine("F - Find a number.");
                Console.WriteLine("E - Even numbers of the list.");
                Console.WriteLine("O - Odd numbers of the list.");
                Console.WriteLine("C - Clear the list.");
                Console.WriteLine("Q - Quit.");
                Console.Write("Select an option from the menu: ");
                choice = char.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 'p':
                    case 'P':
                        {
                            if (list.Count == 0)
                                Console.WriteLine("[] - the list is empty");
                            else
                            {
                                Console.Write("Elements of the list : ");
                                Console.Write("[");
                                for (int i = 0; i < list.Count; i++)
                                {
                                    Console.Write($" {list[i]}");
                                }
                                Console.WriteLine(" ]");
                            }
                            break;
                        }
                    case 'a':
                    case 'A':
                        {
                            Console.Write("Enter a number: ");
                            bool exist = false;
                            int num = int.Parse(Console.ReadLine());
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (num == list[i])
                                {
                                    exist = true;
                                    break;
                                }
                            }

                            if (exist)
                                Console.WriteLine($"Number {num} is already in the list.");
                            else
                            {
                                list.Add(num);
                                Console.WriteLine($"Number {num} added...");
                            }

                            break;
                        }
                    case 'm':
                    case 'M':
                        {
                            int sum = 0;
                            double mean = 0;
                            if (list.Count == 0)
                                Console.WriteLine("[] - the list is empty");
                            else
                            {
                                for (int i = 0; i < list.Count; i++)
                                    sum += list[i];
                                mean = (double)sum / list.Count;
                                Console.WriteLine($"The mean of the numbers = {mean}");
                            }
                            break;
                        }
                    case 's':
                    case 'S':
                        {
                            if (list.Count == 0)
                                Console.WriteLine("[] - the list is empty");
                            else
                            {
                                int min = list[0];
                                for (int i = 1; i < list.Count; i++)
                                   if (min > list[i])
                                        min = list[i];

                                Console.WriteLine($"The smallest number is: {min}");
                            }

                            break;
                        }
                    case 'l':
                    case 'L':
                        {
                            if (list.Count == 0)
                                Console.WriteLine("[] - the list is empty");
                            else
                            {
                                int max = list[0];
                                for (int i = 1; i < list.Count; i++)
                                    if (max < list[i])
                                        max = list[i];

                                Console.WriteLine($"The largest number is: {max}");
                            }
                            break;
                        }
                    case 'f':
                    case 'F':
                        {
                            if (list.Count == 0)
                                Console.WriteLine("[] - the list is empty");
                            else
                            {
                                Console.Write("Enter a number: ");
                                int num = int.Parse(Console.ReadLine());
                                bool exist = false;

                                for (int i = 0; i < list.Count(); i++)
                                {
                                    if (num == list[i])
                                    {
                                        exist = true;
                                        break;
                                    }

                                }
                                if (exist)
                                    Console.WriteLine($"Number {num} is found...");
                                else
                                    Console.WriteLine($"Number {num} is not found..");

                            }

                            break;
                        }
                    case 'e':
                    case 'E':
                        {
                            if (list.Count == 0)
                                Console.WriteLine("[] - the list is empty");

                            else
                            {
                                List<int> evenList = new List<int>();
                                for (int i = 0;i < list.Count;i++)
                                {
                                    if (list[i] % 2 == 0 && list[i] >= 0)
                                        evenList.Add(list[i]);
                                }

                                if (evenList.Count == 0)
                                    Console.WriteLine("No even numbers found");
                                else
                                {
                                    Console.Write("Even number of the list : ");
                                    Console.Write("[");
                                    for (int i = 0; i < evenList.Count; i++)
                                    {
                                        Console.Write($" {evenList[i]}");
                                    }
                                    Console.WriteLine(" ]");

                                }
                            }
                            break;
                        }
                    case 'o':
                    case 'O':
                        {
                            if (list.Count == 0)
                                Console.WriteLine("[] - the list is empty");

                            else
                            {
                                List<int> oddList = new List<int>();
                                for (int i = 0; i < list.Count; i++)
                                {
                                    if (!(list[i] % 2 == 0) && list[i] > 0)
                                        oddList.Add(list[i]);
                                }
                                if (oddList.Count == 0)
                                    Console.WriteLine("No odd numbers found");
                                else
                                {
                                    Console.Write("Odd number of the list : ");
                                    Console.Write("[");
                                    for (int i = 0; i < oddList.Count; i++)
                                    {
                                        Console.Write($" {oddList[i]}");
                                    }
                                    Console.WriteLine(" ]");
                                }
                            }
                            break;
                        }
                    case 'q':
                    case 'Q':
                        Console.WriteLine("Goodbye");
                        break;
                    case 'c':
                    case 'C':
                        {
                            if (list.Count == 0)
                                Console.WriteLine("[] - the list is already empty");
                            else
                            {
                                list.Clear();
                                Console.WriteLine("List cleared...");
                                
                            }
                            break;
                        }

                        default: Console.WriteLine("Error... Invalid option...");
                         break;
                        
                }
            } while (choice != 'Q' && choice != 'q');
        }
    }
}
