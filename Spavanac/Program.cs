/******
 * Spavanac
 * https://open.kattis.com/problems/spavanac
 * Difficulty - 1.3
 ******/
using System;

namespace Spavanac
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            if (!string.IsNullOrEmpty(line))
            {
                string[] inputs = line.Split(' ');
                int hour = Int32.Parse(inputs[0]);
                int minutes = Int32.Parse(inputs[1]);

                int temp = minutes;
                minutes = (minutes >= 45) ? (minutes - 45) : (minutes + 60 - 45);
                hour = (temp >= 45) ? hour : ((--hour < 0) ? 23 : hour);

                Console.WriteLine($"{hour} {minutes}");
            }
        }
    }
}
