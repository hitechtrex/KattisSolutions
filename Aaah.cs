/*****
 * Aaah!
 * https://open.kattis.com/problems/aaah
 * Difficulty - 1.7
 ******/
using System;

namespace Aaah
{
    class Program
    {
        static void Main(string[] args)
        {
            string say = Console.ReadLine();
            string want = Console.ReadLine();

            Console.WriteLine(say.Split('h')[0].Length >= want.Split('h')[0].Length ? "go" : "no");
        }
    }
}
