// https://open.kattis.com/problems/leftbeehind
// Steve Jia
using System;
using System.Collections.Generic;

namespace LeftBeehind
{
    class Program
    {
        static void Main(string[] args)
        {
            string line;
            List<Tuple<int, int>> inputPairs = new List<Tuple<int, int>>();
            while((line = Console.ReadLine()) != "0 0")
            {
                var temp = Array.ConvertAll(line.Split(' '), Int32.Parse);
                inputPairs.Add(new Tuple<int, int>(temp[0], temp[1]));
            }

            string output;
            foreach (var pair in inputPairs)
            {
                if (pair.Item1 + pair.Item2 == 13) output = "Never speak again.";
                else if (pair.Item1 == pair.Item2) output = "Undecided.";
                else output = (pair.Item1 - pair.Item2 > 0) ? "To the convention." : "Left beehind.";
                Console.WriteLine(output);
            }
        }
    }
}
