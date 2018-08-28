// https://open.kattis.com/problems/parking2
// Steve Jia
using System;
using System.Linq;
public class Solution{
    public static void Main(){
        int testCases = int.Parse(Console.ReadLine());
        for(int i = 0; i < testCases; i++){
            Console.ReadLine();
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            var sorted = inputs.OrderBy(x => x);
            Console.WriteLine((sorted.Last() - sorted.First()) * 2);
        }
    }
} 