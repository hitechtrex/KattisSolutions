// https://open.kattis.com/problems/railroad2
// Steve Jia
using System;
public class Solution{
    public static void Main(){
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        int total = inputs[0] * 4 + inputs[1] * 3;
        Console.WriteLine($"{(total%2==0?"":"im")}possible");
    }
} 