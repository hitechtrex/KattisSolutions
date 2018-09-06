// https://open.kattis.com/problems/heartrate
// Steve Jia

using System;
public class Solution{
    public static void Main(){
        int testCases = int.Parse(Console.ReadLine());
        for(int i = 0; i < testCases; i++){
            double[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);
            double x = 60d / inputs[1];
            double xb = inputs[0] * x;
            Console.WriteLine("{0:0.0000} {1:0.0000} {2:0.0000}", xb-x, xb, xb+x);
        }
    }
} 