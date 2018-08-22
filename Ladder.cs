// https://open.kattis.com/problems/ladder
using System;
public class Solution{
    public static void Main(string[] args){
        int[] inputs = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        Console.WriteLine(Math.Ceiling(inputs[0]/Math.Sin(inputs[1] * Math.PI / 180d)));
    }
} 