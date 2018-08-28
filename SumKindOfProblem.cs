// https://open.kattis.com/problems/sumkindofproblem
// Steve Jia
using System;

public class Solution{
    public static void Main(){
        int testCases = int.Parse(Console.ReadLine());
        for(int i = 1; i <= testCases; i++){
            int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int k = inputs[0];
            int n = inputs[1];
            // arithmetic progression: n * (a1 + an) / 2
            int sumFirstN = n * (1 + n) / 2;
            int sumFirstNOdd = Convert.ToInt32(Math.Pow(n, 2)); // n*(1+2(n-1)+1)/2
            int sumFirstNEven = Convert.ToInt32(Math.Pow(n, 2)) + n; // n*(2+2n)/2 => (2n+2n^2)/2 => n^2+n
            Console.WriteLine($"{k} {sumFirstN} {sumFirstNOdd} {sumFirstNEven}");
        }
    }
}