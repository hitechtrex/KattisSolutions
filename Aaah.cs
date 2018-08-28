// https://open.kattis.com/problems/aaah
// Steve Jia
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
