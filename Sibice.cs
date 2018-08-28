// https://open.kattis.com/problems/sibice
// Steve Jia
using System;
using System.Collections.Generic;
using System.Linq;

namespace Sibice
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            if(string.IsNullOrEmpty(line)){ return; }
            List<int> firstInputs = Array.ConvertAll(line.Split(' '), Int32.Parse).ToList();

            int matchLength;
            List<int> matchLengths = new List<int>();
            for(int i = 0; i < firstInputs[0] && ((line = Console.ReadLine()) != null); i++){
                if(Int32.TryParse(line, out matchLength)){
                    matchLengths.Add(matchLength);
                }
            }

            List<int> dimensions = firstInputs.GetRange(1, 2);
            double h = Math.Sqrt(Math.Pow(firstInputs[1], 2d) + Math.Pow(firstInputs[2], 2d));
            int hypotenuse = (int)Math.Floor(h);
            dimensions.Add(hypotenuse);

            foreach (int length in matchLengths)
            {
                Console.WriteLine(dimensions.Any(d => length <= d) ? "DA" : "NE"); 
            }
        }
    }
}
