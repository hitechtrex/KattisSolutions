// https://open.kattis.com/problems/quadrant
// Steve Jia
using System;
using System.Linq;

namespace QuadrantSelection
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputs = new int[2];
            string line;
            for(int i = 0; i < 2 && ((line = Console.ReadLine()) != null); i++){
                inputs[i] = Int32.Parse(line);
            }

            if(inputs.Any(i => i == 0)){return;}

            Console.WriteLine(inputs[0] > 0 ? (inputs[1] > 0 ? 1 : 4) : (inputs[1] > 0 ? 2 : 3));
        }
    }
}
