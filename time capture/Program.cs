using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace time_capture
{
    class Program
    {
        static void Main()
        {
            var timeListing = new List<DateTime>();
            while (true)
            {
                string option = MainMenu();
                switch (option)
                {
                    case "c":
                        Console.WriteLine("C is selected!");
                        var currentDate = DateTime.Now;
                        timeListing.Add(currentDate);
                        Console.Clear();
                        continue;
                    case "l":
                        Console.WriteLine("L is selected!");
                        foreach (var time in timeListing)
                        {
                            Console.WriteLine(time);
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter a Command!");
                        break;
                }
                Console.WriteLine("Press Enter to return to MainMenu");
                Console.ReadKey();
            }

            static string MainMenu()
            {
                Console.WriteLine("-- Time Capture Device --");
                Console.WriteLine("");
                Console.WriteLine("c - Capture Current time");
                Console.WriteLine("l - List Captured times catagorized by day");
                return Console.ReadLine();
            }

        }
    }
}
