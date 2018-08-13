/******
 * R2
 * https://open.kattis.com/problems/r2
 * Difficulty - 1.2
 ******/
using System;

namespace R2
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            if(string.IsNullOrEmpty(line)){return;}

            int[] inputs = Array.ConvertAll(line.Split(' '), Int32.Parse);
            int R1 = inputs[0];
            int S = inputs[1];

            Console.WriteLine(S*2 - R1);
        }
    }
}
