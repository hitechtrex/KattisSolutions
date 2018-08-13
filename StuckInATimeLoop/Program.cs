/**************************************
 * Stuck In A Time Loop
 * https://open.kattis.com/problems/timeloop
 * Difficulty - 1.2
 **************************************/
using System;

namespace StuckInATimeLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int spellCount = 0;
            string input;
            while (spellCount < 1 || spellCount > 100)
            {
                if ((input = Console.ReadLine()) != null)
                {
                    spellCount = Int32.Parse(input);
                }
            }

            for (int i = 1; i <= spellCount; Console.WriteLine($"{i} Abracadabra"), i++)
            { /*empty body*/ }
        }
    }
}
